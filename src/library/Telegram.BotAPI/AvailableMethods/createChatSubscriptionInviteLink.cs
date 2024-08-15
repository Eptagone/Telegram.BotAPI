// Copyright (c) 2024 Quetzal Rivera.
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
    /// Use this method to create a <a href="https://telegram.org/blog/superchannels-star-reactions-subscriptions#star-subscriptions">subscription invite link</a> for a channel chat. The bot must have the <em>can_invite_users</em> administrator rights. The link can be edited using the method <a href="https://core.telegram.org/bots/api#editchatsubscriptioninvitelink">editChatSubscriptionInviteLink</a> or revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as a <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target channel chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="subscriptionPeriod">The number of seconds the subscription will be active for before the next payment. Currently, it must always be 2592000 (30 days).</param>
    /// <param name="subscriptionPrice">The amount of Telegram Stars a user must pay initially and after each subsequent subscription period to be a member of the chat; 1-2500</param>
    /// <param name="name">Invite link name; 0-32 characters</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static ChatInviteLink CreateChatSubscriptionInviteLink(this ITelegramBotClient client, long chatId, int subscriptionPeriod, int subscriptionPrice, string? name = null) =>
        client.CreateChatSubscriptionInviteLinkAsync(chatId, subscriptionPeriod, subscriptionPrice, name).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to create a <a href="https://telegram.org/blog/superchannels-star-reactions-subscriptions#star-subscriptions">subscription invite link</a> for a channel chat. The bot must have the <em>can_invite_users</em> administrator rights. The link can be edited using the method <a href="https://core.telegram.org/bots/api#editchatsubscriptioninvitelink">editChatSubscriptionInviteLink</a> or revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as a <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target channel chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="subscriptionPeriod">The number of seconds the subscription will be active for before the next payment. Currently, it must always be 2592000 (30 days).</param>
    /// <param name="subscriptionPrice">The amount of Telegram Stars a user must pay initially and after each subsequent subscription period to be a member of the chat; 1-2500</param>
    /// <param name="name">Invite link name; 0-32 characters</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<ChatInviteLink> CreateChatSubscriptionInviteLinkAsync(this ITelegramBotClient client, long chatId, int subscriptionPeriod, int subscriptionPrice, string? name = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.SubscriptionPeriod, subscriptionPeriod },
            { PropertyNames.SubscriptionPrice, subscriptionPrice }
        };
        if (name is not null)
        {
            args.Add(PropertyNames.Name, name);
        }

        return client.CallMethodAsync<ChatInviteLink>(MethodNames.CreateChatSubscriptionInviteLink, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to create a <a href="https://telegram.org/blog/superchannels-star-reactions-subscriptions#star-subscriptions">subscription invite link</a> for a channel chat. The bot must have the <em>can_invite_users</em> administrator rights. The link can be edited using the method <a href="https://core.telegram.org/bots/api#editchatsubscriptioninvitelink">editChatSubscriptionInviteLink</a> or revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as a <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target channel chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="subscriptionPeriod">The number of seconds the subscription will be active for before the next payment. Currently, it must always be 2592000 (30 days).</param>
    /// <param name="subscriptionPrice">The amount of Telegram Stars a user must pay initially and after each subsequent subscription period to be a member of the chat; 1-2500</param>
    /// <param name="name">Invite link name; 0-32 characters</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static ChatInviteLink CreateChatSubscriptionInviteLink(this ITelegramBotClient client, string chatId, int subscriptionPeriod, int subscriptionPrice, string? name = null) =>
        client.CreateChatSubscriptionInviteLinkAsync(chatId, subscriptionPeriod, subscriptionPrice, name).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to create a <a href="https://telegram.org/blog/superchannels-star-reactions-subscriptions#star-subscriptions">subscription invite link</a> for a channel chat. The bot must have the <em>can_invite_users</em> administrator rights. The link can be edited using the method <a href="https://core.telegram.org/bots/api#editchatsubscriptioninvitelink">editChatSubscriptionInviteLink</a> or revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as a <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target channel chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="subscriptionPeriod">The number of seconds the subscription will be active for before the next payment. Currently, it must always be 2592000 (30 days).</param>
    /// <param name="subscriptionPrice">The amount of Telegram Stars a user must pay initially and after each subsequent subscription period to be a member of the chat; 1-2500</param>
    /// <param name="name">Invite link name; 0-32 characters</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<ChatInviteLink> CreateChatSubscriptionInviteLinkAsync(this ITelegramBotClient client, string chatId, int subscriptionPeriod, int subscriptionPrice, string? name = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.SubscriptionPeriod, subscriptionPeriod },
            { PropertyNames.SubscriptionPrice, subscriptionPrice }
        };
        if (name is not null)
        {
            args.Add(PropertyNames.Name, name);
        }

        return client.CallMethodAsync<ChatInviteLink>(MethodNames.CreateChatSubscriptionInviteLink, args, cancellationToken);
    }
}
