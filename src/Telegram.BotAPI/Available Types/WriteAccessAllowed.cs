// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about a user allowing a bot to write messages after adding the bot to the attachment menu or launching a Web App from a link.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class WriteAccessAllowed
{
	/// <summary>
	/// Optional. Name of the Web App which was launched from a link.
	/// </summary>
	[JsonPropertyName(PropertyNames.WebAppName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? WebAppName { get; set; }
}
