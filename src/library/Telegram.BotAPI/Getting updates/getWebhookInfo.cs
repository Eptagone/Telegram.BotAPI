// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.GettingUpdates;

public static partial class GettingUpdatesExtensions
{
	/// <summary>Use this method to get current webhook status. On success, returns a <see cref="WebhookInfo"/> object. If the bot is using getUpdates, will return an object with the url field empty.</summary>
	/// <param name="bot">Bot Client</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static WebhookInfo GetWebhookInfo(this ITelegramBotClient bot)
	{
		if (bot == default)
		{
			throw new System.ArgumentNullException(nameof(bot));
		}

		return bot.CallMethod<WebhookInfo>(MethodNames.GetWebhookInfo);
	}
	/// <summary>Use this method to get current webhook status. On success, returns a <see cref="WebhookInfo"/> object. If the bot is using getUpdates, will return an object with the url field empty.</summary>
	/// <param name="bot">Bot Client</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<WebhookInfo> GetWebhookInfoAsync(this ITelegramBotClient bot, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return await bot.CallMethodAsync<WebhookInfo>(MethodNames.GetWebhookInfo, cancellationToken).ConfigureAwait(false);
	}
}