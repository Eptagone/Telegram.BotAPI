// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a task in a checklist.
/// </summary>
public class ChecklistTask
{
    /// <summary>
    /// Unique identifier of the task
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public int Id { get; set; }

    /// <summary>
    /// Text of the task
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string Text { get; set; } = null!;

    /// <summary>
    /// Optional. Special entities that appear in the task text
    /// </summary>
    [JsonPropertyName(PropertyNames.TextEntities)]
    public IEnumerable<MessageEntity>? TextEntities { get; set; }

    /// <summary>
    /// Optional. User that completed the task; omitted if the task wasn't completed by a user
    /// </summary>
    [JsonPropertyName(PropertyNames.CompletedByUser)]
    public User? CompletedByUser { get; set; }

    /// <summary>
    /// Optional. Chat that completed the task; omitted if the task wasn't completed by a chat
    /// </summary>
    [JsonPropertyName(PropertyNames.CompletedByChat)]
    public Chat? CompletedByChat { get; set; }

    /// <summary>
    /// Optional. Point in time (Unix timestamp) when the task was completed; 0 if the task wasn't completed
    /// </summary>
    [JsonPropertyName(PropertyNames.CompletionDate)]
    public int? CompletionDate { get; set; }
}
