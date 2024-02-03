// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "RestrictChatMember" method.
/// </summary>
public class RestrictChatMemberArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RestrictChatMemberArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="permissions">A JSON-serialized object for new user permissions</param>
    public RestrictChatMemberArgs(long chatId, long userId, ChatPermissions permissions)
    {
        this.ChatId = chatId;
        this.UserId = userId;
        this.Permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RestrictChatMemberArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="permissions">A JSON-serialized object for new user permissions</param>
    public RestrictChatMemberArgs(string chatId, long userId, ChatPermissions permissions)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.UserId = userId;
        this.Permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Unique identifier of the target user
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// A JSON-serialized object for new user permissions
    /// </summary>
    [JsonPropertyName(PropertyNames.Permissions)]
    public ChatPermissions Permissions { get; set; }

    /// <summary>
    /// Pass <em>True</em> if chat permissions are set independently. Otherwise, the <em>can_send_other_messages</em> and <em>can_add_web_page_previews</em> permissions will imply the <em>can_send_messages</em>, <em>can_send_audios</em>, <em>can_send_documents</em>, <em>can_send_photos</em>, <em>can_send_videos</em>, <em>can_send_video_notes</em>, and <em>can_send_voice_notes</em> permissions; the <em>can_send_polls</em> permission will imply the <em>can_send_messages</em> permission.
    /// </summary>
    [JsonPropertyName(PropertyNames.UseIndependentChatPermissions)]
    public bool? UseIndependentChatPermissions { get; set; }

    /// <summary>
    /// Date when restrictions will be lifted for the user; Unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever
    /// </summary>
    [JsonPropertyName(PropertyNames.UntilDate)]
    public int? UntilDate { get; set; }
}
