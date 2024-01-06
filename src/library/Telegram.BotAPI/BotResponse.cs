// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>Represents the bot's response to the request.</summary>
/// <typeparam name="TResult">Result type.</typeparam>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class BotResponse<TResult>
{
	/// <summary>
	/// True, if the request was successful, otherwise false.
	/// </summary>
	[JsonPropertyName("ok")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool Ok { get; set; }
	/// <summary>
	/// Result.
	/// </summary>
	[JsonPropertyName("result")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public TResult? Result { get; set; }
	/// <summary>
	/// Error code.
	/// </summary>
	[JsonPropertyName("error_code")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? ErrorCode { get; set; }
	/// <summary>
	/// Error description.
	/// </summary>
	[JsonPropertyName("description")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Description { get; set; }
	/// <summary>
	/// A <see cref="ResponseParameters"/> object containing additional information about the error.
	/// </summary>
	[JsonPropertyName("parameters")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ResponseParameters? Parameters { get; set; }
}
