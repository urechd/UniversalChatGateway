using Microsoft.AspNetCore.SignalR;

namespace UniversalChatGateway.Hubs;

public class TextChatHub : Hub
{
    public async Task SendMessage(byte[] message)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}