// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class GettingUpdatesExtensions
{
    /// <summary>
    /// Use this method to get current webhook status. Requires no parameters. On success, returns a <see cref="WebhookInfo"/> object. If the bot is using <a href="https://core.telegram.org/bots/api#getupdates">getUpdates</a>, will return an object with the <em>url</em> field empty.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static WebhookInfo GetWebhookInfo(this ITelegramBotClient client) =>
        client.GetWebhookInfoAsync().GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get current webhook status. Requires no parameters. On success, returns a <see cref="WebhookInfo"/> object. If the bot is using <a href="https://core.telegram.org/bots/api#getupdates">getUpdates</a>, will return an object with the <em>url</em> field empty.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<WebhookInfo> GetWebhookInfoAsync(this ITelegramBotClient client, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<WebhookInfo>(MethodNames.GetWebhookInfo, cancellationToken: cancellationToken);
    }
}
