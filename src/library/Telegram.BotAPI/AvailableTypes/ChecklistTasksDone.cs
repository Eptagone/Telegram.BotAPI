// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about checklist tasks marked as done or not done.
/// </summary>
public class ChecklistTasksDone
{
    /// <summary>
    /// Optional. Message containing the checklist whose tasks were marked as done or not done. Note that the <see cref="Message"/> object in this field will not contain the <em>reply_to_message</em> field even if it itself is a reply.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChecklistMessage)]
    public Message? ChecklistMessage { get; set; }

    /// <summary>
    /// Optional. Identifiers of the tasks that were marked as done
    /// </summary>
    [JsonPropertyName(PropertyNames.MarkedAsDoneTaskIds)]
    public IEnumerable<int>? MarkedAsDoneTaskIds { get; set; }

    /// <summary>
    /// Optional. Identifiers of the tasks that were marked as not done
    /// </summary>
    [JsonPropertyName(PropertyNames.MarkedAsNotDoneTaskIds)]
    public IEnumerable<int>? MarkedAsNotDoneTaskIds { get; set; }
}
