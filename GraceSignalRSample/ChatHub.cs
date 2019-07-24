
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace GraceSignalRSample
{
    
    public class ChatHub : Hub<IChatClient>
    {

        public Task BroadcastMessageAsync(string message)
        {
            return this.Clients.All.MessagereceivedAsync(message);
        }
    }
}
