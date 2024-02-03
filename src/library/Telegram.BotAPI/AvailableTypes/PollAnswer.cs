// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an answer of a user in a non-anonymous poll.
/// </summary>
public class PollAnswer
{
    /// <summary>
    /// Unique poll identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.PollId)]
    public string PollId { get; set; } = null!;

    /// <summary>
    /// Optional. The chat that changed the answer to the poll, if the voter is anonymous
    /// </summary>
    [JsonPropertyName(PropertyNames.VoterChat)]
    public Chat? VoterChat { get; set; }

    /// <summary>
    /// Optional. The user that changed the answer to the poll, if the voter isn't anonymous
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User? User { get; set; }

    /// <summary>
    /// 0-based identifiers of chosen answer options. May be empty if the vote was retracted.
    /// </summary>
    [JsonPropertyName(PropertyNames.OptionIds)]
    public IEnumerable<int> OptionIds { get; set; } = null!;
}
