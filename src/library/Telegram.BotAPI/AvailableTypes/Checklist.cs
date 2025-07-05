// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a checklist.
/// </summary>
public class Checklist
{
    /// <summary>
    /// Title of the checklist
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Optional. Special entities that appear in the checklist title
    /// </summary>
    [JsonPropertyName(PropertyNames.TitleEntities)]
    public IEnumerable<MessageEntity>? TitleEntities { get; set; }

    /// <summary>
    /// List of tasks in the checklist
    /// </summary>
    [JsonPropertyName(PropertyNames.Tasks)]
    public IEnumerable<ChecklistTask> Tasks { get; set; } = null!;

    /// <summary>
    /// Optional. <em>True</em>, if users other than the creator of the list can add tasks to the list
    /// </summary>
    [JsonPropertyName(PropertyNames.OthersCanAddTasks)]
    public bool? OthersCanAddTasks { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if users other than the creator of the list can mark tasks as done or not done
    /// </summary>
    [JsonPropertyName(PropertyNames.OthersCanMarkTasksAsDone)]
    public bool? OthersCanMarkTasksAsDone { get; set; }
}
