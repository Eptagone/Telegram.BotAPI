// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.Converters;

using JsonConverter = System.Text.Json.Serialization.JsonConverterAttribute;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents the scope to which bot commands are applied. Currently, the following 7 scopes are supported: <br /><br />
/// • <see cref="BotCommandScopeDefault"/><br />
/// • <see cref="BotCommandScopeAllPrivateChats"/><br />
/// • <see cref="BotCommandScopeAllGroupChats"/><br />
/// • <see cref="BotCommandScopeAllChatAdministrators"/><br />
/// • <see cref="BotCommandScopeChat"/><br />
/// • <see cref="BotCommandScopeChatAdministrators"/><br />
/// • <see cref="BotCommandScopeChatMember"/><br />
/// </summary>
[JsonConverter(typeof(BotCommandScopeConverter))]
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public abstract class BotCommandScope
{
	/// <summary>Scope type</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public abstract string Type { get; }
}
