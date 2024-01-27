// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SetMyCommands method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SetChatMenuButtonArgs
{
	/// <summary>Inititalize a new instance of <see cref="SetChatMenuButtonArgs"/>.</summary>
	public SetChatMenuButtonArgs([Optional] long? chatId, [Optional] MenuButton? menuButton)
	{
		this.ChatId = chatId;
		this.MenuButton = menuButton;
	}

	/// <summary>Optional.Unique identifier for the target private chat. If not specified, default bot's menu button will be changed.</summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long? ChatId { get; set; }
	/// <summary>Optional. A <see cref="AvailableTypes.MenuButton"/> object for the new bot's menu button. Defaults to MenuButtonDefault.</summary>
	[JsonPropertyName(PropertyNames.MenuButton)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public MenuButton? MenuButton { get; set; }
}
