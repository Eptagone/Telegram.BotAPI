using HelloBotNET.AppService;
using HelloBotNET.AppService.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        // Add bot properties service.
        services.AddSingleton<HelloBotProperties>();

        // Add bot service.
        services.AddScoped<HelloBot>();

        // Add long polling service
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
