// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes an inline message sent by a guest bot.
/// </summary>
public class SentGuestMessage
{
    /// <summary>
    /// Identifier of the sent inline message
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    public string InlineMessageId { get; set; } = null!;
}
