// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about one answer option in a poll.
/// </summary>
public class PollOption
{
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
    /// Number of users that voted for this option
    /// </summary>
    [JsonPropertyName(PropertyNames.VoterCount)]
    public int VoterCount { get; set; }
}
