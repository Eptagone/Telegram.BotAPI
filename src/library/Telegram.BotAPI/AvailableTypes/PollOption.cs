// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about one answer option in a poll.
/// </summary>
public class PollOption
{
    /// <summary>
    /// Unique identifier of the option, persistent on option addition and deletion
    /// </summary>
    [JsonPropertyName(PropertyNames.PersistentId)]
    public string PersistentId { get; set; } = null!;

    /// <summary>
    /// Option text, 1-100 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string Text { get; set; } = null!;

    /// <summary>
    /// Optional. Special entities that appear in the option <em>text</em>. Currently, only custom emoji entities are allowed in poll option texts
    /// </summary>
    [JsonPropertyName(PropertyNames.TextEntities)]
    public IEnumerable<MessageEntity>? TextEntities { get; set; }

    /// <summary>
    /// Optional. Media added to the poll option
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public PollMedia? Media { get; set; }

    /// <summary>
    /// Number of users who voted for this option; may be 0 if unknown
    /// </summary>
    [JsonPropertyName(PropertyNames.VoterCount)]
    public int VoterCount { get; set; }

    /// <summary>
    /// Optional. User who added the option; omitted if the option wasn't added by a user after poll creation
    /// </summary>
    [JsonPropertyName(PropertyNames.AddedByUser)]
    public User? AddedByUser { get; set; }

    /// <summary>
    /// Optional. Chat that added the option; omitted if the option wasn't added by a chat after poll creation
    /// </summary>
    [JsonPropertyName(PropertyNames.AddedByChat)]
    public Chat? AddedByChat { get; set; }

    /// <summary>
    /// Optional. Point in time (Unix timestamp) when the option was added; omitted if the option existed in the original poll
    /// </summary>
    [JsonPropertyName(PropertyNames.AdditionDate)]
    public int? AdditionDate { get; set; }
}
