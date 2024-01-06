// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using HelloBotNET.Webhook.Extensions;
using HelloBotNET.Webhook.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add bot service.
builder.Services.AddSingleton<HelloBot>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers();

// Register que webhook
app.UseTelegramWebhook();

app.Run();
