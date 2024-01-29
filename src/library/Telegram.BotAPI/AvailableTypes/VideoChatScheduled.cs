// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about a video chat scheduled in the chat.
/// </summary>
public class VideoChatScheduled
{
    /// <summary>
    /// Point in time (Unix timestamp) when the video chat is supposed to be started by a chat administrator
    /// </summary>
    [JsonPropertyName(PropertyNames.StartDate)]
    public int StartDate { get; set; }
}
