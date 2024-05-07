// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a chat background.
/// </summary>
public class ChatBackground
{
    /// <summary>
    /// Type of the background
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public BackgroundType Type { get; set; } = null!;
}
