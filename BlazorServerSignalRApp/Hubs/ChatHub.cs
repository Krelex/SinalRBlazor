using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(ChatMessage chatMessage)
        {
            await Clients.All.SendAsync("ReceiveMessage", chatMessage);
        }
    }
}