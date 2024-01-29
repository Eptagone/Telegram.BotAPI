// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents reaction changes on a message with anonymous reactions.
/// </summary>
public class MessageReactionCountUpdated
{
    /// <summary>
    /// The chat containing the message
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Unique message identifier inside the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int MessageId { get; set; }

    /// <summary>
    /// Date of the change in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public int Date { get; set; }

    /// <summary>
    /// List of reactions that are present on the message
    /// </summary>
    [JsonPropertyName(PropertyNames.Reactions)]
    public IEnumerable<ReactionCount> Reactions { get; set; } = null!;
}
