// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the background of a gift.
/// </summary>
public class GiftBackground
{
    /// <summary>
    /// Center color of the background in RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.CenterColor)]
    public int CenterColor { get; set; }

    /// <summary>
    /// Edge color of the background in RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.EdgeColor)]
    public int EdgeColor { get; set; }

    /// <summary>
    /// Text color of the background in RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.TextColor)]
    public int TextColor { get; set; }
}
