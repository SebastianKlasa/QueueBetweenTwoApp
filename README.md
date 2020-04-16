# QueueBetweenTwoApp
2 apps: Backend server and Appliction server communicate by queue system

Repo contains 3 applications:
- "Backand server" - server side application which receives communicates from rabbitMQ queue and execute actions on the database
- "Server application" - server side application which represent backend logic of the web application for car rental. To communicate with
database application use RabbitMQ queue
- "jsonEdit" - .NET application to process initialization data  
