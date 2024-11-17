// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Describes an inline message to be sent by a user of a Mini App.
/// </summary>
public class PreparedInlineMessage
{
    /// <summary>
    /// Unique identifier of the prepared message
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// Expiration date of the prepared message, in Unix time. Expired prepared messages can no longer be used
    /// </summary>
    [JsonPropertyName(PropertyNames.ExpirationDate)]
    public int ExpirationDate { get; set; }
}
