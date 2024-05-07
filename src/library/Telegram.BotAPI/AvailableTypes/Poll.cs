// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about a poll.
/// </summary>
public class Poll
{
    /// <summary>
    /// Unique poll identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// Poll question, 1-300 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Question)]
    public string Question { get; set; } = null!;

    /// <summary>
    /// Optional. Special entities that appear in the <em>question</em>. Currently, only custom emoji entities are allowed in poll questions
    /// </summary>
    [JsonPropertyName(PropertyNames.QuestionEntities)]
    public IEnumerable<MessageEntity>? QuestionEntities { get; set; }

    /// <summary>
    /// List of poll options
    /// </summary>
    [JsonPropertyName(PropertyNames.Options)]
    public IEnumerable<PollOption> Options { get; set; } = null!;

    /// <summary>
    /// Total number of users that voted in the poll
    /// </summary>
    [JsonPropertyName(PropertyNames.TotalVoterCount)]
    public int TotalVoterCount { get; set; }

    /// <summary>
    /// <em>True</em>, if the poll is closed
    /// </summary>
    [JsonPropertyName(PropertyNames.IsClosed)]
    public bool IsClosed { get; set; }

    /// <summary>
    /// <em>True</em>, if the poll is anonymous
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAnonymous)]
    public bool IsAnonymous { get; set; }

    /// <summary>
    /// Poll type, currently can be “regular” or “quiz”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public string Type { get; set; } = null!;

    /// <summary>
    /// <em>True</em>, if the poll allows multiple answers
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowsMultipleAnswers)]
    public bool AllowsMultipleAnswers { get; set; }

    /// <summary>
    /// Optional. 0-based identifier of the correct answer option. Available only for polls in the quiz mode, which are closed, or was sent (not forwarded) by the bot or to the private chat with the bot.
    /// </summary>
    [JsonPropertyName(PropertyNames.CorrectOptionId)]
    public int? CorrectOptionId { get; set; }

    /// <summary>
    /// Optional. Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Explanation)]
    public string? Explanation { get; set; }

    /// <summary>
    /// Optional. Special entities like usernames, URLs, bot commands, etc. that appear in the <em>explanation</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.ExplanationEntities)]
    public IEnumerable<MessageEntity>? ExplanationEntities { get; set; }

    /// <summary>
    /// Optional. Amount of time in seconds the poll will be active after creation
    /// </summary>
    [JsonPropertyName(PropertyNames.OpenPeriod)]
    public int? OpenPeriod { get; set; }

    /// <summary>
    /// Optional. Point in time (Unix timestamp) when the poll will be automatically closed
    /// </summary>
    [JsonPropertyName(PropertyNames.CloseDate)]
    public int? CloseDate { get; set; }
}
