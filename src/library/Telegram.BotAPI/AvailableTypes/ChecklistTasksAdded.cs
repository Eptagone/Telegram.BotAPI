// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about tasks added to a checklist.
/// </summary>
public class ChecklistTasksAdded
{
    /// <summary>
    /// Optional. Message containing the checklist to which the tasks were added. Note that the Message object in this field will not contain the <em>reply_to_message</em> field even if it itself is a reply.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChecklistMessage)]
    public Message? ChecklistMessage { get; set; }

    /// <summary>
    /// List of tasks added to the checklist
    /// </summary>
    [JsonPropertyName(PropertyNames.Tasks)]
    public IEnumerable<ChecklistTask> Tasks { get; set; } = null!;
}
