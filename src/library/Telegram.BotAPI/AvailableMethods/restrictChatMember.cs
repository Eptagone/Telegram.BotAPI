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
    /// Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass <em>True</em> for all permissions to lift restrictions from a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "RestrictChatMember" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool RestrictChatMember(this ITelegramBotClient client, RestrictChatMemberArgs args) =>
        client.RestrictChatMemberAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass <em>True</em> for all permissions to lift restrictions from a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "RestrictChatMember" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> RestrictChatMemberAsync(this ITelegramBotClient client, RestrictChatMemberArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.RestrictChatMember, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass <em>True</em> for all permissions to lift restrictions from a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="permissions">A JSON-serialized object for new user permissions</param>
    /// <param name="useIndependentChatPermissions">Pass <em>True</em> if chat permissions are set independently. Otherwise, the <em>can_send_other_messages</em> and <em>can_add_web_page_previews</em> permissions will imply the <em>can_send_messages</em>, <em>can_send_audios</em>, <em>can_send_documents</em>, <em>can_send_photos</em>, <em>can_send_videos</em>, <em>can_send_video_notes</em>, and <em>can_send_voice_notes</em> permissions; the <em>can_send_polls</em> permission will imply the <em>can_send_messages</em> permission.</param>
    /// <param name="untilDate">Date when restrictions will be lifted for the user; Unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool RestrictChatMember(this ITelegramBotClient client, long chatId, long userId, ChatPermissions permissions, bool? useIndependentChatPermissions = null, int? untilDate = null) =>
        client.RestrictChatMemberAsync(chatId, userId, permissions, useIndependentChatPermissions, untilDate).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass <em>True</em> for all permissions to lift restrictions from a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="permissions">A JSON-serialized object for new user permissions</param>
    /// <param name="useIndependentChatPermissions">Pass <em>True</em> if chat permissions are set independently. Otherwise, the <em>can_send_other_messages</em> and <em>can_add_web_page_previews</em> permissions will imply the <em>can_send_messages</em>, <em>can_send_audios</em>, <em>can_send_documents</em>, <em>can_send_photos</em>, <em>can_send_videos</em>, <em>can_send_video_notes</em>, and <em>can_send_voice_notes</em> permissions; the <em>can_send_polls</em> permission will imply the <em>can_send_messages</em> permission.</param>
    /// <param name="untilDate">Date when restrictions will be lifted for the user; Unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> RestrictChatMemberAsync(this ITelegramBotClient client, long chatId, long userId, ChatPermissions permissions, bool? useIndependentChatPermissions = null, int? untilDate = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.UserId, userId },
            { PropertyNames.Permissions, permissions ?? throw new ArgumentNullException(nameof(permissions)) }
        };
        if (useIndependentChatPermissions is not null)
        {
            args.Add(PropertyNames.UseIndependentChatPermissions, useIndependentChatPermissions);
        }
        if (untilDate is not null)
        {
            args.Add(PropertyNames.UntilDate, untilDate);
        }

        return client.CallMethodAsync<bool>(MethodNames.RestrictChatMember, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass <em>True</em> for all permissions to lift restrictions from a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="permissions">A JSON-serialized object for new user permissions</param>
    /// <param name="useIndependentChatPermissions">Pass <em>True</em> if chat permissions are set independently. Otherwise, the <em>can_send_other_messages</em> and <em>can_add_web_page_previews</em> permissions will imply the <em>can_send_messages</em>, <em>can_send_audios</em>, <em>can_send_documents</em>, <em>can_send_photos</em>, <em>can_send_videos</em>, <em>can_send_video_notes</em>, and <em>can_send_voice_notes</em> permissions; the <em>can_send_polls</em> permission will imply the <em>can_send_messages</em> permission.</param>
    /// <param name="untilDate">Date when restrictions will be lifted for the user; Unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool RestrictChatMember(this ITelegramBotClient client, string chatId, long userId, ChatPermissions permissions, bool? useIndependentChatPermissions = null, int? untilDate = null) =>
        client.RestrictChatMemberAsync(chatId, userId, permissions, useIndependentChatPermissions, untilDate).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass <em>True</em> for all permissions to lift restrictions from a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="permissions">A JSON-serialized object for new user permissions</param>
    /// <param name="useIndependentChatPermissions">Pass <em>True</em> if chat permissions are set independently. Otherwise, the <em>can_send_other_messages</em> and <em>can_add_web_page_previews</em> permissions will imply the <em>can_send_messages</em>, <em>can_send_audios</em>, <em>can_send_documents</em>, <em>can_send_photos</em>, <em>can_send_videos</em>, <em>can_send_video_notes</em>, and <em>can_send_voice_notes</em> permissions; the <em>can_send_polls</em> permission will imply the <em>can_send_messages</em> permission.</param>
    /// <param name="untilDate">Date when restrictions will be lifted for the user; Unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> RestrictChatMemberAsync(this ITelegramBotClient client, string chatId, long userId, ChatPermissions permissions, bool? useIndependentChatPermissions = null, int? untilDate = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.UserId, userId },
            { PropertyNames.Permissions, permissions ?? throw new ArgumentNullException(nameof(permissions)) }
        };
        if (useIndependentChatPermissions is not null)
        {
            args.Add(PropertyNames.UseIndependentChatPermissions, useIndependentChatPermissions);
        }
        if (untilDate is not null)
        {
            args.Add(PropertyNames.UntilDate, untilDate);
        }

        return client.CallMethodAsync<bool>(MethodNames.RestrictChatMember, args, cancellationToken);
    }
}
