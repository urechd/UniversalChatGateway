using Microsoft.AspNetCore.ResponseCompression;
using UniversalChatGateway.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddResponseCompression(opts =>
    {
        opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(["application/octet-stream"]);
    }
);

var app = builder.Build();
app.UseResponseCompression();
app.MapHub<TextChatHub>("/textChatHub"); 
app.Run();
