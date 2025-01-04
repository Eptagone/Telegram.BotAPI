// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class InlineModeExtensions
{
    /// <summary>
    /// Stores a message that can be sent by a user of a Mini App. Returns a <see cref="PreparedInlineMessage"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SavePreparedInlineMessage" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static PreparedInlineMessage SavePreparedInlineMessage(this ITelegramBotClient client, SavePreparedInlineMessageArgs args) =>
        client.SavePreparedInlineMessageAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Stores a message that can be sent by a user of a Mini App. Returns a <see cref="PreparedInlineMessage"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SavePreparedInlineMessage" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<PreparedInlineMessage> SavePreparedInlineMessageAsync(this ITelegramBotClient client, SavePreparedInlineMessageArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<PreparedInlineMessage>(MethodNames.SavePreparedInlineMessage, args, cancellationToken);
    }

    /// <summary>
    /// Stores a message that can be sent by a user of a Mini App. Returns a <see cref="PreparedInlineMessage"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user that can use the prepared message</param>
    /// <param name="result">A JSON-serialized object describing the message to be sent</param>
    /// <param name="allowUserChats">Pass <em>True</em> if the message can be sent to private chats with users</param>
    /// <param name="allowBotChats">Pass <em>True</em> if the message can be sent to private chats with bots</param>
    /// <param name="allowGroupChats">Pass <em>True</em> if the message can be sent to group and supergroup chats</param>
    /// <param name="allowChannelChats">Pass <em>True</em> if the message can be sent to channel chats</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static PreparedInlineMessage SavePreparedInlineMessage(this ITelegramBotClient client, long userId, InlineQueryResult result, bool? allowUserChats = null, bool? allowBotChats = null, bool? allowGroupChats = null, bool? allowChannelChats = null) =>
        client.SavePreparedInlineMessageAsync(userId, result, allowUserChats, allowBotChats, allowGroupChats, allowChannelChats).GetAwaiter().GetResult();

    /// <summary>
    /// Stores a message that can be sent by a user of a Mini App. Returns a <see cref="PreparedInlineMessage"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user that can use the prepared message</param>
    /// <param name="result">A JSON-serialized object describing the message to be sent</param>
    /// <param name="allowUserChats">Pass <em>True</em> if the message can be sent to private chats with users</param>
    /// <param name="allowBotChats">Pass <em>True</em> if the message can be sent to private chats with bots</param>
    /// <param name="allowGroupChats">Pass <em>True</em> if the message can be sent to group and supergroup chats</param>
    /// <param name="allowChannelChats">Pass <em>True</em> if the message can be sent to channel chats</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<PreparedInlineMessage> SavePreparedInlineMessageAsync(this ITelegramBotClient client, long userId, InlineQueryResult result, bool? allowUserChats = null, bool? allowBotChats = null, bool? allowGroupChats = null, bool? allowChannelChats = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.Result, result ?? throw new ArgumentNullException(nameof(result)) }
        };
        if (allowUserChats is not null)
        {
            args.Add(PropertyNames.AllowUserChats, allowUserChats);
        }
        if (allowBotChats is not null)
        {
            args.Add(PropertyNames.AllowBotChats, allowBotChats);
        }
        if (allowGroupChats is not null)
        {
            args.Add(PropertyNames.AllowGroupChats, allowGroupChats);
        }
        if (allowChannelChats is not null)
        {
            args.Add(PropertyNames.AllowChannelChats, allowChannelChats);
        }

        return client.CallMethodAsync<PreparedInlineMessage>(MethodNames.SavePreparedInlineMessage, args, cancellationToken);
    }
}
