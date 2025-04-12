// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the backdrop of a unique gift.
/// </summary>
public class UniqueGiftBackdrop
{
    /// <summary>
    /// Name of the backdrop
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Colors of the backdrop
    /// </summary>
    [JsonPropertyName(PropertyNames.Colors)]
    public UniqueGiftBackdropColors Colors { get; set; } = null!;

    /// <summary>
    /// The number of unique gifts that receive this backdrop for every 1000 gifts upgraded
    /// </summary>
    [JsonPropertyName(PropertyNames.RarityPerMille)]
    public int RarityPerMille { get; set; }
}
