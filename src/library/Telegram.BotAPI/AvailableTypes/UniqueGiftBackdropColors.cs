// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the colors of the backdrop of a unique gift.
/// </summary>
public class UniqueGiftBackdropColors
{
    /// <summary>
    /// The color in the center of the backdrop in RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.CenterColor)]
    public int CenterColor { get; set; }

    /// <summary>
    /// The color on the edges of the backdrop in RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.EdgeColor)]
    public int EdgeColor { get; set; }

    /// <summary>
    /// The color to be applied to the symbol in RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.SymbolColor)]
    public int SymbolColor { get; set; }

    /// <summary>
    /// The color for the text on the backdrop in RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.TextColor)]
    public int TextColor { get; set; }
}
