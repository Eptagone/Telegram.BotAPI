// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.AvailableMethods;
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
		var bot = app.ApplicationServices.GetRequiredService<HelloBotProperties>();

		var webhookToken = configuration["Telegram:WebhookToken"]; // ENV: Telegram__WebhookToken, JSON: "Telegram:WebhookToken"
		var webhookUrl = configuration["Telegram:WebhookUrl"]; // ENV: Telegram__WebhookUrl, JSON: "Telegram:WebhookUrl"

		// Delete my old commands
		bot.Api.DeleteMyCommands();
		// Set my commands
		bot.Api.SetMyCommands(
			new BotCommand("hello", "Hello world!"));

		// Delete webhook
		bot.Api.DeleteWebhook();

		// Set webhook
		bot.Api.SetWebhook(webhookUrl + "/bot", secretToken: webhookToken);

		return app;
	}
}
