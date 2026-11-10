// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a sticker on a TON wallet card.
/// </summary>
public class TonWalletCardSticker
{
    /// <summary>
    /// Position of the sticker on the card
    /// </summary>
    [JsonPropertyName(PropertyNames.Position)]
    public AreaPosition Position { get; set; } = null!;

    /// <summary>
    /// The NFT shown as the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.Nft)]
    public TonNft Nft { get; set; } = null!;
}
