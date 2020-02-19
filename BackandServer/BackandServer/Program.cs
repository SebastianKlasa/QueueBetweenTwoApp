using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using BackandServer.Controllers;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BackandServer
{
    class Program
    {
        public static Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

        static void Main(string[] args)
        {
            DBController dbcontr = new DBController();
            string queueName = "orders_queue";


            Console.WriteLine("Trwa uruchamianie servera backendowego...");

            var factory = new ConnectionFactory()
            {
                UserName = "guest",
                Password = "guest",
                HostName = "localhost",
                VirtualHost = "/"
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queueName, false, false, false, null);
                // send/receive message
                var consumer = new EventingBasicConsumer(channel);
                channel.QueuePurge(queueName);

                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    //var message = Encoding.UTF8.GetString(body);
                    var obj = ByteArrayToObject(body);
                    string objectType = Encoding.UTF8.GetString((byte[])(ea.BasicProperties.Headers["object_type"]));
                    string orderType = Encoding.UTF8.GetString((byte[])(ea.BasicProperties.Headers["order_type"]));
                    // show message
                    //dbcontr.manage(message);
                    Console.WriteLine("");
                    Console.WriteLine("Odebrano polecenie");
                    dbcontr.manage(orderType, obj);
                    Console.WriteLine("Wykonano polecenie " + orderType+" "+objectType);

                    IBasicProperties properties = ea.BasicProperties;
                    var responseBytes = Encoding.UTF8.GetBytes("przetworzono");
                    var replyProps = channel.CreateBasicProperties();
                    replyProps.CorrelationId = properties.CorrelationId;
                    channel.BasicPublish("", properties.ReplyTo, replyProps, responseBytes);
                    Console.WriteLine("Wyslano odpowiedz");

                };
                channel.BasicConsume(queueName, true, consumer);


                Console.WriteLine("kolejka zainicjowana, oczekuje na komunikaty...");
                Console.WriteLine("Wcisnij dowolny przycisk, aby zakonczyc dzialanie programu...");
                Console.ReadKey();
            }
        }
    }
}
