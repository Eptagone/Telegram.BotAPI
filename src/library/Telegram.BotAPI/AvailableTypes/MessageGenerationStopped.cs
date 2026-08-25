// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes an update about a user stopping message generation.
/// </summary>
public class MessageGenerationStopped
{
    /// <summary>
    /// Chat in which the message is generated
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Optional. Unique identifier of the message thread in which the message is generated
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageThreadId)]
    public int? MessageThreadId { get; set; }

    /// <summary>
    /// Unique identifier of the message draft which was stopped
    /// </summary>
    [JsonPropertyName(PropertyNames.DraftId)]
    public int DraftId { get; set; }
}
