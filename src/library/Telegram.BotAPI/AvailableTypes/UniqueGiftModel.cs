// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Stickers;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the model of a unique gift.
/// </summary>
public class UniqueGiftModel
{
    /// <summary>
    /// Name of the model
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// The sticker that represents the unique gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public Sticker Sticker { get; set; } = null!;

    /// <summary>
    /// The number of unique gifts that receive this model for every 1000 gift upgrades. Always 0 for crafted gifts.
    /// </summary>
    [JsonPropertyName(PropertyNames.RarityPerMille)]
    public int RarityPerMille { get; set; }

    /// <summary>
    /// Optional. Rarity of the model if it is a crafted model. Currently, can be “uncommon”, “rare”, “epic”, or “legendary”.
    /// </summary>
    [JsonPropertyName(PropertyNames.Rarity)]
    public string? Rarity { get; set; }
}
