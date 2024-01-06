// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using HelloBotNET.AppService;
using HelloBotNET.AppService.Services;
using Telegram.BotAPI;

IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices((context, services) =>
	{
		// Add bot service.
		services.AddSingleton<HelloBot>();

		// Add long polling service
		services.AddHostedService<Worker>();
	})
	.Build();

await host.RunAsync();
