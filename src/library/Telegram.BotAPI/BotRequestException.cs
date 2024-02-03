// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>
/// Exception generated when a request to Telegram Bot API got an error response.
/// </summary>=
/// <param name="errorCode">Error code.</param>
/// <param name="description">Description.</param>
/// <param name="parameters">Parameters.</param>
public sealed class BotRequestException(
	int errorCode,
	string description,
	ResponseParameters? parameters
) : Exception(description)
{
	/// <summary>Error code.</summary>
	public int ErrorCode { get; } = errorCode;

	/// <summary>Error description.</summary>
	public string Description { get; } = description;

	/// <summary>Parameters.</summary>
	public ResponseParameters? Parameters { get; } = parameters;
}
