// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about a new forum topic created in the chat.
/// </summary>
public class ForumTopicCreated
{
    /// <summary>
    /// Name of the topic
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Color of the topic icon in RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.IconColor)]
    public int IconColor { get; set; }

    /// <summary>
    /// Optional. Unique identifier of the custom emoji shown as the topic icon
    /// </summary>
    [JsonPropertyName(PropertyNames.IconCustomEmojiId)]
    public string? IconCustomEmojiId { get; set; }
}
