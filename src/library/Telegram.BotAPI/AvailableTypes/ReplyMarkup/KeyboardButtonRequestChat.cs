// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object defines the criteria used to request a suitable chat. The identifier of the selected chat will be shared with the bot when the corresponding button is pressed.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class KeyboardButtonRequestChat
{
	/// <summary>
	/// Initializes a new instance of the <see cref="KeyboardButtonRequestChat"/> class.
	/// </summary>
	/// <param name="requestId">Signed 32-bit identifier of the request, which will be received back in the ChatShared object. Must be unique within the message</param>
	/// <param name="chatIsChannel">Pass True to request a channel chat, pass False to request a group or a supergroup chat.</param>
	public KeyboardButtonRequestChat(int requestId, bool chatIsChannel)
	{
		this.RequestId = requestId;
		this.ChatIsChannel = chatIsChannel;
	}

	/// <summary>
	/// Signed 32-bit identifier of the request, which will be received back in the ChatShared object. Must be unique within the message
	/// </summary>
	[JsonPropertyName(PropertyNames.RequestId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int RequestId { get; }
	/// <summary>
	/// Pass True to request a channel chat, pass False to request a group or a supergroup chat.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatIsChannel)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool ChatIsChannel { get; }
	/// <summary>
	/// Optional. Pass True to request a forum supergroup, pass False to request a non-forum chat. If not specified, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatIsForum)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ChatIsForum { get; set; }
	/// <summary>
	/// Optional. Pass True to request a supergroup or a channel with a username, pass False to request a chat without a username. If not specified, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatHasUsername)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ChatHasUsername { get; set; }
	/// <summary>
	/// Optional. Pass True to request a chat owned by the user. Otherwise, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatIsCreated)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ChatIsCreated { get; set; }
	/// <summary>
	/// Optional. A JSON-serialized object listing the required administrator rights of the user in the chat. The rights must be a superset of bot_administrator_rights. If not specified, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.UserAdministratorRights)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatAdministratorRights? UserAdministratorRights { get; set; }
	/// <summary>
	/// Optional. A JSON-serialized object listing the required administrator rights of the bot in the chat. The rights must be a subset of user_administrator_rights. If not specified, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.BotAdministratorRights)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatAdministratorRights? BotAdministratorRights { get; set; }
	/// <summary>
	/// Optional. Pass True to request a chat with the bot as a member. Otherwise, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.BotIsMember)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? BotIsMember { get; set; }
}
