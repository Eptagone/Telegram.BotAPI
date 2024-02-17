// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using HelloBotNET.Webhook.Services;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace HelloBotNET.Webhook.Extensions;

/// <summary>
/// Extension methods for <see cref="IApplicationBuilder"/>.
/// </summary>
public static class ApplicationBuilderExtensions
{
    /// <summary>
    /// Registers the Telegram Webhook.
    /// </summary>
    /// <param name="app">The <see cref="IApplicationBuilder"/> instance this method extends.</param>
    /// <returns>The <see cref="IApplicationBuilder"/> instance this method extends.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static IApplicationBuilder UseTelegramWebhook(this IApplicationBuilder app)
    {
        if (app is null)
        {
            throw new ArgumentNullException(nameof(app));
        }

        var configuration = app.ApplicationServices.GetRequiredService<IConfiguration>();
        var bot = app.ApplicationServices.GetRequiredService<HelloBot>();

        var webhookToken = configuration["Telegram:WebhookToken"]; // ENV: Telegram__WebhookToken, JSON: "Telegram:WebhookToken"
        var webhookUrl = configuration["Telegram:WebhookUrl"]; // ENV: Telegram__WebhookUrl, JSON: "Telegram:WebhookUrl"

        // Delete my old commands
        bot.Client.DeleteMyCommands();
        // Set my commands
        bot.Client.SetMyCommands([new BotCommand("hello", "Hello world!")]);

        // Delete webhook
        bot.Client.DeleteWebhook();

        // Set webhook
        bot.Client.SetWebhook(webhookUrl + "/bot", secretToken: webhookToken);

        return app;
    }
}
