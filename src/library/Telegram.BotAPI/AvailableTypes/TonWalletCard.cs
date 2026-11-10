// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a TON wallet card, which is shown on the profile page of a user to everyone.
/// </summary>
public class TonWalletCard
{
    /// <summary>
    /// Address of the wallet
    /// </summary>
    [JsonPropertyName(PropertyNames.Address)]
    public string Address { get; set; } = null!;

    /// <summary>
    /// Balance of the wallet, in the <em>smallest units</em> of the cryptocurrency, as a decimal number
    /// </summary>
    [JsonPropertyName(PropertyNames.Amount)]
    public string Amount { get; set; } = null!;

    /// <summary>
    /// Stickers placed on the card
    /// </summary>
    [JsonPropertyName(PropertyNames.Stickers)]
    public IEnumerable<TonWalletCardSticker> Stickers { get; set; } = null!;

    /// <summary>
    /// Optional. Address of the NFT of one of the stickers, whose colors must be used for the card background; omitted if the default background must be used
    /// </summary>
    [JsonPropertyName(PropertyNames.BackgroundNftAddress)]
    public string? BackgroundNftAddress { get; set; }
}
