using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_chat_simple_asp_net_core_mvc_5.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string chatuser, string chatmessage)
        {
            await Clients.All.SendAsync("ReceiveMessage", chatuser, chatmessage);
        }
    }
}
