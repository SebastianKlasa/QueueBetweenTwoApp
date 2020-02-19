using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ServerApplication.Hubs
{
    public class ListHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
