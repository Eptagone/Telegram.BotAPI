using HelloBotNET.Webhook;
using HelloBotNET.Webhook.Services;

var builder = WebApplication.CreateBuilder(args);

// Add bot properties service.
builder.Services.AddSingleton<HelloBotProperties>();

// Add bot service.
builder.Services.AddScoped<HelloBot>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
