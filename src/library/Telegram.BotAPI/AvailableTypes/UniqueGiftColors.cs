// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about the color scheme for a user's name, message replies and link previews based on a unique gift.
/// </summary>
public class UniqueGiftColors
{
    /// <summary>
    /// Custom emoji identifier of the unique gift's model
    /// </summary>
    [JsonPropertyName(PropertyNames.ModelCustomEmojiId)]
    public string ModelCustomEmojiId { get; set; } = null!;

    /// <summary>
    /// Custom emoji identifier of the unique gift's symbol
    /// </summary>
    [JsonPropertyName(PropertyNames.SymbolCustomEmojiId)]
    public string SymbolCustomEmojiId { get; set; } = null!;

    /// <summary>
    /// Main color used in light themes; RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.LightThemeMainColor)]
    public int LightThemeMainColor { get; set; }

    /// <summary>
    /// List of 1-3 additional colors used in light themes; RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.LightThemeOtherColors)]
    public IEnumerable<int> LightThemeOtherColors { get; set; } = null!;

    /// <summary>
    /// Main color used in dark themes; RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.DarkThemeMainColor)]
    public int DarkThemeMainColor { get; set; }

    /// <summary>
    /// List of 1-3 additional colors used in dark themes; RGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.DarkThemeOtherColors)]
    public IEnumerable<int> DarkThemeOtherColors { get; set; } = null!;
}
