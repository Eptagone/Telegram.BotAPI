// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>
/// Represents the bot's response to the request.
/// </summary>
/// <typeparam name="TResult">Result type.</typeparam>
public sealed class BotResponse<TResult>
{
	/// <summary>
	/// True, if the request was successful, otherwise false.
	/// </summary>
	[JsonPropertyName("ok")]
	public bool Ok { get; set; }

	/// <summary>
	/// Result.
	/// </summary>
	[JsonPropertyName("result")]
	public TResult? Result { get; set; }

	/// <summary>
	/// Error code.
	/// </summary>
	[JsonPropertyName("error_code")]
	public int? ErrorCode { get; set; }

	/// <summary>
	/// Error description.
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// A <see cref="ResponseParameters"/> object containing additional information about the error.
	/// </summary>
	[JsonPropertyName("parameters")]
	public ResponseParameters? Parameters { get; set; }
}
