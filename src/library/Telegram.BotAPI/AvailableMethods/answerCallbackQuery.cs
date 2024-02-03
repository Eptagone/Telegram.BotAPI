// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Games;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to send answers to callback queries sent from <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboards</a>. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerCallbackQuery" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AnswerCallbackQuery(this ITelegramBotClient client, AnswerCallbackQueryArgs args) =>
        client.AnswerCallbackQueryAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send answers to callback queries sent from <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboards</a>. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerCallbackQuery" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AnswerCallbackQueryAsync(this ITelegramBotClient client, AnswerCallbackQueryArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.AnswerCallbackQuery, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send answers to callback queries sent from <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboards</a>. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="callbackQueryId">Unique identifier for the query to be answered</param>
    /// <param name="text">Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters</param>
    /// <param name="showAlert">If <em>True</em>, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to <em>false</em>.</param>
    /// <param name="url">URL that will be opened by the user's client. If you have created a <see cref="Game"/> and accepted the conditions via <a href="https://t.me/botfather">@BotFather</a>, specify the URL that opens your game - note that this will only work if the query comes from a <a href="https://core.telegram.org/bots/api#inlinekeyboardbutton">callback_game</a> button.<br /><br />Otherwise, you may use links like <em>t.me/your_bot?start=XXXX</em> that open your bot with a parameter.</param>
    /// <param name="cacheTime">The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AnswerCallbackQuery(this ITelegramBotClient client, string callbackQueryId, string? text = null, bool? showAlert = null, string? url = null, int? cacheTime = null) =>
        client.AnswerCallbackQueryAsync(callbackQueryId, text, showAlert, url, cacheTime).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send answers to callback queries sent from <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboards</a>. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="callbackQueryId">Unique identifier for the query to be answered</param>
    /// <param name="text">Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters</param>
    /// <param name="showAlert">If <em>True</em>, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to <em>false</em>.</param>
    /// <param name="url">URL that will be opened by the user's client. If you have created a <see cref="Game"/> and accepted the conditions via <a href="https://t.me/botfather">@BotFather</a>, specify the URL that opens your game - note that this will only work if the query comes from a <a href="https://core.telegram.org/bots/api#inlinekeyboardbutton">callback_game</a> button.<br /><br />Otherwise, you may use links like <em>t.me/your_bot?start=XXXX</em> that open your bot with a parameter.</param>
    /// <param name="cacheTime">The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AnswerCallbackQueryAsync(this ITelegramBotClient client, string callbackQueryId, string? text = null, bool? showAlert = null, string? url = null, int? cacheTime = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.CallbackQueryId, callbackQueryId ?? throw new ArgumentNullException(nameof(callbackQueryId)) }
        };
        if (text is not null)
        {
            args.Add(PropertyNames.Text, text);
        }
        if (showAlert is not null)
        {
            args.Add(PropertyNames.ShowAlert, showAlert);
        }
        if (url is not null)
        {
            args.Add(PropertyNames.Url, url);
        }
        if (cacheTime is not null)
        {
            args.Add(PropertyNames.CacheTime, cacheTime);
        }

        return client.CallMethodAsync<bool>(MethodNames.AnswerCallbackQuery, args, cancellationToken);
    }
}
