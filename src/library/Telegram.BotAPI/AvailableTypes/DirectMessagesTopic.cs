// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a topic of a direct messages chat.
/// </summary>
public class DirectMessagesTopic
{
    /// <summary>
    /// Unique identifier of the topic
    /// </summary>
    [JsonPropertyName(PropertyNames.TopicId)]
    public int TopicId { get; set; }

    /// <summary>
    /// Optional. Information about the user that created the topic. Currently, it is always present
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User? User { get; set; }
}
