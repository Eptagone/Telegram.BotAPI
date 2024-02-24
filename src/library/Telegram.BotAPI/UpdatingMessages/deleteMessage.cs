// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to delete a message, including service messages, with the following limitations:<br />- A message can only be deleted if it was sent less than 48 hours ago.<br />- Service messages about a supergroup, channel, or forum topic creation can't be deleted.<br />- A dice message in a private chat can only be deleted if it was sent more than 24 hours ago.<br />- Bots can delete outgoing messages in private chats, groups, and supergroups.<br />- Bots can delete incoming messages in private chats.<br />- Bots granted <em>can_post_messages</em> permissions can delete outgoing messages in channels.<br />- If the bot is an administrator of a group, it can delete any message there.<br />- If the bot has <em>can_delete_messages</em> permission in a supergroup or a channel, it can delete any message there.<br />Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Identifier of the message to delete</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteMessage(this ITelegramBotClient client, long chatId, int messageId) =>
        client.DeleteMessageAsync(chatId, messageId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to delete a message, including service messages, with the following limitations:<br />- A message can only be deleted if it was sent less than 48 hours ago.<br />- Service messages about a supergroup, channel, or forum topic creation can't be deleted.<br />- A dice message in a private chat can only be deleted if it was sent more than 24 hours ago.<br />- Bots can delete outgoing messages in private chats, groups, and supergroups.<br />- Bots can delete incoming messages in private chats.<br />- Bots granted <em>can_post_messages</em> permissions can delete outgoing messages in channels.<br />- If the bot is an administrator of a group, it can delete any message there.<br />- If the bot has <em>can_delete_messages</em> permission in a supergroup or a channel, it can delete any message there.<br />Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Identifier of the message to delete</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteMessageAsync(this ITelegramBotClient client, long chatId, int messageId, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.MessageId, messageId }
        };

        return client.CallMethodAsync<bool>(MethodNames.DeleteMessage, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to delete a message, including service messages, with the following limitations:<br />- A message can only be deleted if it was sent less than 48 hours ago.<br />- Service messages about a supergroup, channel, or forum topic creation can't be deleted.<br />- A dice message in a private chat can only be deleted if it was sent more than 24 hours ago.<br />- Bots can delete outgoing messages in private chats, groups, and supergroups.<br />- Bots can delete incoming messages in private chats.<br />- Bots granted <em>can_post_messages</em> permissions can delete outgoing messages in channels.<br />- If the bot is an administrator of a group, it can delete any message there.<br />- If the bot has <em>can_delete_messages</em> permission in a supergroup or a channel, it can delete any message there.<br />Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Identifier of the message to delete</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteMessage(this ITelegramBotClient client, string chatId, int messageId) =>
        client.DeleteMessageAsync(chatId, messageId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to delete a message, including service messages, with the following limitations:<br />- A message can only be deleted if it was sent less than 48 hours ago.<br />- Service messages about a supergroup, channel, or forum topic creation can't be deleted.<br />- A dice message in a private chat can only be deleted if it was sent more than 24 hours ago.<br />- Bots can delete outgoing messages in private chats, groups, and supergroups.<br />- Bots can delete incoming messages in private chats.<br />- Bots granted <em>can_post_messages</em> permissions can delete outgoing messages in channels.<br />- If the bot is an administrator of a group, it can delete any message there.<br />- If the bot has <em>can_delete_messages</em> permission in a supergroup or a channel, it can delete any message there.<br />Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Identifier of the message to delete</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteMessageAsync(this ITelegramBotClient client, string chatId, int messageId, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.MessageId, messageId }
        };

        return client.CallMethodAsync<bool>(MethodNames.DeleteMessage, args, cancellationToken);
    }
}
