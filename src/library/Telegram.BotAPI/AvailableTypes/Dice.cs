// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an animated emoji that displays a random value.
/// </summary>
public class Dice
{
    /// <summary>
    /// Emoji on which the dice throw animation is based
    /// </summary>
    [JsonPropertyName(PropertyNames.Emoji)]
    public string Emoji { get; set; } = null!;

    /// <summary>
    /// Value of the dice, 1-6 for “🎲”, “🎯” and “🎳” base emoji, 1-5 for “🏀” and “⚽” base emoji, 1-64 for “🎰” base emoji
    /// </summary>
    [JsonPropertyName(PropertyNames.Value)]
    public int Value { get; set; }
}
