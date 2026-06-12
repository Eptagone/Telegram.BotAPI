// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to process a received chat join request query by showing a Mini App to the user before deciding the outcome. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatJoinRequestQueryId">Unique identifier of the join request query</param>
    /// <param name="webAppUrl">The URL of the Mini App to be opened</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendChatJoinRequestWebApp(this ITelegramBotClient client, string chatJoinRequestQueryId, string webAppUrl) =>
        client.SendChatJoinRequestWebAppAsync(chatJoinRequestQueryId, webAppUrl).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to process a received chat join request query by showing a Mini App to the user before deciding the outcome. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatJoinRequestQueryId">Unique identifier of the join request query</param>
    /// <param name="webAppUrl">The URL of the Mini App to be opened</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendChatJoinRequestWebAppAsync(this ITelegramBotClient client, string chatJoinRequestQueryId, string webAppUrl, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatJoinRequestQueryId, chatJoinRequestQueryId ?? throw new ArgumentNullException(nameof(chatJoinRequestQueryId)) },
            { PropertyNames.WebAppUrl, webAppUrl ?? throw new ArgumentNullException(nameof(webAppUrl)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.SendChatJoinRequestWebApp, args, cancellationToken);
    }
}
