// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SetChatPermissions" method.
/// </summary>
public class SetChatPermissionsArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetChatPermissionsArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="permissions">A JSON-serialized object for new default chat permissions</param>
    public SetChatPermissionsArgs(long chatId, ChatPermissions permissions)
    {
        this.ChatId = chatId;
        this.Permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SetChatPermissionsArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="permissions">A JSON-serialized object for new default chat permissions</param>
    public SetChatPermissionsArgs(string chatId, ChatPermissions permissions)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// A JSON-serialized object for new default chat permissions
    /// </summary>
    [JsonPropertyName(PropertyNames.Permissions)]
    public ChatPermissions Permissions { get; set; }

    /// <summary>
    /// Pass <em>True</em> if chat permissions are set independently. Otherwise, the <em>can_send_other_messages</em> and <em>can_add_web_page_previews</em> permissions will imply the <em>can_send_messages</em>, <em>can_send_audios</em>, <em>can_send_documents</em>, <em>can_send_photos</em>, <em>can_send_videos</em>, <em>can_send_video_notes</em>, and <em>can_send_voice_notes</em> permissions; the <em>can_send_polls</em> permission will imply the <em>can_send_messages</em> permission.
    /// </summary>
    [JsonPropertyName(PropertyNames.UseIndependentChatPermissions)]
    public bool? UseIndependentChatPermissions { get; set; }
}
