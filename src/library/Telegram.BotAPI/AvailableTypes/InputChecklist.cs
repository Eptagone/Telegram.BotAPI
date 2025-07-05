// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a checklist to create.
/// </summary>
public class InputChecklist
{
    /// <summary>
    /// Title of the checklist; 1-255 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Optional. Mode for parsing entities in the title. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// Optional. List of special entities that appear in the title, which can be specified instead of parse_mode. Currently, only <em>bold</em>, <em>italic</em>, <em>underline</em>, <em>strikethrough</em>, <em>spoiler</em>, and <em>custom_emoji</em> entities are allowed.
    /// </summary>
    [JsonPropertyName(PropertyNames.TitleEntities)]
    public IEnumerable<MessageEntity>? TitleEntities { get; set; }

    /// <summary>
    /// List of 1-30 tasks in the checklist
    /// </summary>
    [JsonPropertyName(PropertyNames.Tasks)]
    public IEnumerable<InputChecklistTask> Tasks { get; set; } = null!;

    /// <summary>
    /// Optional. Pass <em>True</em> if other users can add tasks to the checklist
    /// </summary>
    [JsonPropertyName(PropertyNames.OthersCanAddTasks)]
    public bool? OthersCanAddTasks { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if other users can mark tasks as done or not done in the checklist
    /// </summary>
    [JsonPropertyName(PropertyNames.OthersCanMarkTasksAsDone)]
    public bool? OthersCanMarkTasksAsDone { get; set; }
}
