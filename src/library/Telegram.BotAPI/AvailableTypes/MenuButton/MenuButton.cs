// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.Converters;

using JsonConverter = System.Text.Json.Serialization.JsonConverterAttribute;

namespace Telegram.BotAPI.AvailableTypes;

/// /// <summary>This object describes the bot's menu button in a private chat. It should be one of <br /><br />
/// • <see cref="MenuButtonCommands"/><br />
/// • <see cref="MenuButtonWebApp"/><br />
/// • <see cref="MenuButtonDefault"/><br />
/// </summary>
[JsonConverter(typeof(MenuButtonConverter))]
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public abstract class MenuButton
{
	/// <summary>
	/// Type of the button, must be commands
	/// </summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public abstract string Type { get; }
}
