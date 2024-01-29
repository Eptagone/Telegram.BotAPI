// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about a change in auto-delete timer settings.
/// </summary>
public class MessageAutoDeleteTimerChanged
{
    /// <summary>
    /// New auto-delete time for messages in the chat; in seconds
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageAutoDeleteTime)]
    public int MessageAutoDeleteTime { get; set; }
}
