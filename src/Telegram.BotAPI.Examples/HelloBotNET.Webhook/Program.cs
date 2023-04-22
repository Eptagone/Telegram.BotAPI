// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using HelloBotNET.Webhook;
using HelloBotNET.Webhook.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add bot properties service.
builder.Services.AddSingleton<HelloBotProperties>();

// Add bot service.
builder.Services.AddScoped<HelloBot>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
