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
    /// Identifier of the regular gift from which the gift was upgraded
    /// </summary>
    [JsonPropertyName(PropertyNames.GiftId)]
    public string GiftId { get; set; } = null!;

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
    /// Optional. <em>True</em>, if the original regular gift was exclusively purchaseable by Telegram Premium subscribers
    /// </summary>
    [JsonPropertyName(PropertyNames.IsPremium)]
    public bool? IsPremium { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the gift was used to craft another gift and isn't available anymore
    /// </summary>
    [JsonPropertyName(PropertyNames.IsBurned)]
    public bool? IsBurned { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the gift is assigned from the TON blockchain and can't be resold or transferred in Telegram
    /// </summary>
    [JsonPropertyName(PropertyNames.IsFromBlockchain)]
    public bool? IsFromBlockchain { get; set; }

    /// <summary>
    /// Optional. The color scheme that can be used by the gift's owner for the chat's name, replies to messages and link previews; for business account gifts and gifts that are currently on sale only
    /// </summary>
    [JsonPropertyName(PropertyNames.Colors)]
    public UniqueGiftColors? Colors { get; set; }

    /// <summary>
    /// Optional. Information about the chat that published the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.PublisherChat)]
    public Chat? PublisherChat { get; set; }
}
