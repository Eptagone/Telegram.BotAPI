// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a story.
/// </summary>
public class Story
{
    /// <summary>
    /// Chat that posted the story
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Unique identifier for the story in the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public int Id { get; set; }
}
