// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about a video chat ended in the chat.
/// </summary>
public class VideoChatEnded
{
    /// <summary>
    /// Video chat duration in seconds
    /// </summary>
    [JsonPropertyName(PropertyNames.Duration)]
    public int Duration { get; set; }
}
