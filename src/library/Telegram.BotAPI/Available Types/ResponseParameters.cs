// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Contains information about why a request was unsuccessful.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ResponseParameters
{
	/// <summary>
	/// Optional. The group has been migrated to a supergroup with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.
	/// </summary>
	[JsonPropertyName(PropertyNames.MigrateToChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long MigrateToChatId { get; set; }
	/// <summary>
	/// Optional. In case of exceeding flood control, the number of seconds left to wait before the request can be repeated.
	/// </summary>
	[JsonPropertyName(PropertyNames.RetryAfter)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? RetryAfter { get; set; }
}
