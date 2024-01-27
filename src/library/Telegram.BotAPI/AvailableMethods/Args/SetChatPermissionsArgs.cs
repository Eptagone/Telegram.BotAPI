// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// SetChatPermissions method arguments.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SetChatPermissionsArgs
{
	/// <summary>
	/// Initialize a new instance of <see cref="SetChatPermissionsArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="permissions">New default chat permissions.</param>
	public SetChatPermissionsArgs(string chatId, ChatPermissions permissions)
	{
		this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
		this.Permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
	}

	/// <summary>
	/// Initialize a new instance of <see cref="SetChatPermissionsArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="permissions">New default chat permissions.</param>
	public SetChatPermissionsArgs(long chatId, ChatPermissions permissions)
	{
		this.ChatId = chatId;
		this.Permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; }
	/// <summary>
	/// A JSON-serialized object for new default chat permissions
	/// </summary>
	[JsonPropertyName(PropertyNames.Permissions)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatPermissions Permissions { get; }
	/// <summary>
	/// Pass True if chat permissions are set independently. Otherwise, the can_send_other_messages and can_add_web_page_previews permissions will imply the can_send_messages, can_send_audios, can_send_documents, can_send_photos, can_send_videos, can_send_video_notes, and can_send_voice_notes permissions; the can_send_polls permission will imply the can_send_messages permission.
	/// </summary>
	[JsonPropertyName(PropertyNames.UseIndependentChatPermissions)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? UseIndependentChatPermissions { get; set; }

}
