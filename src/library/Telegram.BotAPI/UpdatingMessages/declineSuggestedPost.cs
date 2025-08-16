// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to decline a suggested post in a direct messages chat. The bot must have the 'can_manage_direct_messages' administrator right in the corresponding channel chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target direct messages chat</param>
    /// <param name="messageId">Identifier of a suggested post message to decline</param>
    /// <param name="comment">Comment for the creator of the suggested post; 0-128 characters</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeclineSuggestedPost(this ITelegramBotClient client, long chatId, int messageId, string? comment = null) =>
        client.DeclineSuggestedPostAsync(chatId, messageId, comment).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to decline a suggested post in a direct messages chat. The bot must have the 'can_manage_direct_messages' administrator right in the corresponding channel chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target direct messages chat</param>
    /// <param name="messageId">Identifier of a suggested post message to decline</param>
    /// <param name="comment">Comment for the creator of the suggested post; 0-128 characters</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeclineSuggestedPostAsync(this ITelegramBotClient client, long chatId, int messageId, string? comment = null, CancellationToken cancellationToken = default)
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
        if (comment is not null)
        {
            args.Add(PropertyNames.Comment, comment);
        }

        return client.CallMethodAsync<bool>(MethodNames.DeclineSuggestedPost, args, cancellationToken);
    }
}
