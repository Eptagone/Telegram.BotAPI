// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using HelloBotNET.AppService;
using HelloBotNET.AppService.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(
        (_, services) =>
        {
            // Add bot service.
            services.AddSingleton<HelloBot>();

            // Add long polling service
            services.AddHostedService<Worker>();
        }
    )
    .Build();

await host.RunAsync();
