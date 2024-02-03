// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes why a request was unsuccessful.
/// </summary>
public class ResponseParameters
{
    /// <summary>
    /// Optional. The group has been migrated to a supergroup with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
    /// </summary>
    [JsonPropertyName(PropertyNames.MigrateToChatId)]
    public long? MigrateToChatId { get; set; }

    /// <summary>
    /// Optional. In case of exceeding flood control, the number of seconds left to wait before the request can be repeated
    /// </summary>
    [JsonPropertyName(PropertyNames.RetryAfter)]
    public int? RetryAfter { get; set; }
}
