using Microsoft.AspNetCore.SignalR;

namespace UniversalChatGateway.Hubs;

public class TextChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        string messageToSend = $"{user}: {message}";
        await Clients.All.SendAsync("ReceiveMessage", messageToSend);
    }
}