// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Contains data sent from a Web App to the bot.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class WebAppData
{
	/// <summary>
	/// The data. Be aware that a bad client can send arbitrary data in this field.
	/// </summary>
	[JsonPropertyName(PropertyNames.Data)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Data { get; set; }
	/// <summary>
	/// Text of the web_app keyboard button, from which the Web App was opened. Be aware that a bad client can send arbitrary data in this field.
	/// </summary>
	[JsonPropertyName(PropertyNames.ButtonText)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ButtonText { get; set; }
}
