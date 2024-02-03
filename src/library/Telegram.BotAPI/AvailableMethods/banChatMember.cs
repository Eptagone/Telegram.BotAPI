// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the chat on their own using invite links, etc., unless <a href="https://core.telegram.org/bots/api#unbanchatmember">unbanned</a> first. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="untilDate">Date when the user will be unbanned; Unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever. Applied for supergroups and channels only.</param>
    /// <param name="revokeMessages">Pass <em>True</em> to delete all messages from the chat for the user that is being removed. If <em>False</em>, the user will be able to see messages in the group that were sent before the user was removed. Always <em>True</em> for supergroups and channels.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool BanChatMember(this ITelegramBotClient client, long chatId, long userId, int? untilDate = null, bool? revokeMessages = null) =>
        client.BanChatMemberAsync(chatId, userId, untilDate, revokeMessages).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the chat on their own using invite links, etc., unless <a href="https://core.telegram.org/bots/api#unbanchatmember">unbanned</a> first. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="untilDate">Date when the user will be unbanned; Unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever. Applied for supergroups and channels only.</param>
    /// <param name="revokeMessages">Pass <em>True</em> to delete all messages from the chat for the user that is being removed. If <em>False</em>, the user will be able to see messages in the group that were sent before the user was removed. Always <em>True</em> for supergroups and channels.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> BanChatMemberAsync(this ITelegramBotClient client, long chatId, long userId, int? untilDate = null, bool? revokeMessages = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.UserId, userId }
        };
        if (untilDate is not null)
        {
            args.Add(PropertyNames.UntilDate, untilDate);
        }
        if (revokeMessages is not null)
        {
            args.Add(PropertyNames.RevokeMessages, revokeMessages);
        }

        return client.CallMethodAsync<bool>(MethodNames.BanChatMember, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the chat on their own using invite links, etc., unless <a href="https://core.telegram.org/bots/api#unbanchatmember">unbanned</a> first. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="untilDate">Date when the user will be unbanned; Unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever. Applied for supergroups and channels only.</param>
    /// <param name="revokeMessages">Pass <em>True</em> to delete all messages from the chat for the user that is being removed. If <em>False</em>, the user will be able to see messages in the group that were sent before the user was removed. Always <em>True</em> for supergroups and channels.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool BanChatMember(this ITelegramBotClient client, string chatId, long userId, int? untilDate = null, bool? revokeMessages = null) =>
        client.BanChatMemberAsync(chatId, userId, untilDate, revokeMessages).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the chat on their own using invite links, etc., unless <a href="https://core.telegram.org/bots/api#unbanchatmember">unbanned</a> first. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="untilDate">Date when the user will be unbanned; Unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever. Applied for supergroups and channels only.</param>
    /// <param name="revokeMessages">Pass <em>True</em> to delete all messages from the chat for the user that is being removed. If <em>False</em>, the user will be able to see messages in the group that were sent before the user was removed. Always <em>True</em> for supergroups and channels.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> BanChatMemberAsync(this ITelegramBotClient client, string chatId, long userId, int? untilDate = null, bool? revokeMessages = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.UserId, userId }
        };
        if (untilDate is not null)
        {
            args.Add(PropertyNames.UntilDate, untilDate);
        }
        if (revokeMessages is not null)
        {
            args.Add(PropertyNames.RevokeMessages, revokeMessages);
        }

        return client.CallMethodAsync<bool>(MethodNames.BanChatMember, args, cancellationToken);
    }
}
