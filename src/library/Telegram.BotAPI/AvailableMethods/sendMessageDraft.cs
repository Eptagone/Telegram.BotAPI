// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to stream a partial message to a user while the message is being generated; supported only for bots with forum topic mode enabled. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendMessageDraft" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendMessageDraft(this ITelegramBotClient client, SendMessageDraftArgs args) =>
        client.SendMessageDraftAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to stream a partial message to a user while the message is being generated; supported only for bots with forum topic mode enabled. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendMessageDraft" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendMessageDraftAsync(this ITelegramBotClient client, SendMessageDraftArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SendMessageDraft, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to stream a partial message to a user while the message is being generated; supported only for bots with forum topic mode enabled. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target private chat</param>
    /// <param name="draftId">Unique identifier of the message draft; must be non-zero. Changes of drafts with the same identifier are animated</param>
    /// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendMessageDraft(this ITelegramBotClient client, long chatId, int draftId, string text, int? messageThreadId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null) =>
        client.SendMessageDraftAsync(chatId, draftId, text, messageThreadId, parseMode, entities).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to stream a partial message to a user while the message is being generated; supported only for bots with forum topic mode enabled. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target private chat</param>
    /// <param name="draftId">Unique identifier of the message draft; must be non-zero. Changes of drafts with the same identifier are animated</param>
    /// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendMessageDraftAsync(this ITelegramBotClient client, long chatId, int draftId, string text, int? messageThreadId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.DraftId, draftId },
            { PropertyNames.Text, text ?? throw new ArgumentNullException(nameof(text)) }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (parseMode is not null)
        {
            args.Add(PropertyNames.ParseMode, parseMode);
        }
        if (entities is not null)
        {
            args.Add(PropertyNames.Entities, entities);
        }

        return client.CallMethodAsync<bool>(MethodNames.SendMessageDraft, args, cancellationToken);
    }
}
