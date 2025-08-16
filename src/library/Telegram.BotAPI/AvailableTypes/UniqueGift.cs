// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a unique gift that was upgraded from a regular gift.
/// </summary>
public class UniqueGift
{
    /// <summary>
    /// Human-readable name of the regular gift from which this unique gift was upgraded
    /// </summary>
    [JsonPropertyName(PropertyNames.BaseName)]
    public string BaseName { get; set; } = null!;

    /// <summary>
    /// Unique name of the gift. This name can be used in <em>https://t.me/nft/...</em> links and story areas
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Unique number of the upgraded gift among gifts upgraded from the same regular gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Number)]
    public int Number { get; set; }

    /// <summary>
    /// Model of the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Model)]
    public UniqueGiftModel Model { get; set; } = null!;

    /// <summary>
    /// Symbol of the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Symbol)]
    public UniqueGiftSymbol Symbol { get; set; } = null!;

    /// <summary>
    /// Backdrop of the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Backdrop)]
    public UniqueGiftBackdrop Backdrop { get; set; } = null!;

    /// <summary>
    /// Optional. Information about the chat that published the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.PublisherChat)]
    public Chat? PublisherChat { get; set; }
}
