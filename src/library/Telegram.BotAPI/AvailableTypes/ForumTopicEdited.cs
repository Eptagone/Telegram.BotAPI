// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about an edited forum topic.
/// </summary>
public class ForumTopicEdited
{
    /// <summary>
    /// Optional. New name of the topic, if it was edited
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string? Name { get; set; }

    /// <summary>
    /// Optional. New identifier of the custom emoji shown as the topic icon, if it was edited; an empty string if the icon was removed
    /// </summary>
    [JsonPropertyName(PropertyNames.IconCustomEmojiId)]
    public string? IconCustomEmojiId { get; set; }
}
