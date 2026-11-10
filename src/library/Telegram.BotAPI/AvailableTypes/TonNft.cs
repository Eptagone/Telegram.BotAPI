// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an NFT in the TON blockchain.
/// </summary>
public class TonNft
{
    /// <summary>
    /// Address of the NFT
    /// </summary>
    [JsonPropertyName(PropertyNames.Address)]
    public string Address { get; set; } = null!;

    /// <summary>
    /// Optional. Address of the collection to which the NFT belongs; omitted if unknown
    /// </summary>
    [JsonPropertyName(PropertyNames.CollectionAddress)]
    public string? CollectionAddress { get; set; }

    /// <summary>
    /// Index of the NFT among all NFTs from the collection as a decimal number
    /// </summary>
    [JsonPropertyName(PropertyNames.Index)]
    public string Index { get; set; } = null!;

    /// <summary>
    /// Name of the NFT
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description of the NFT
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string Description { get; set; } = null!;

    /// <summary>
    /// Optional. Attributes of the NFT
    /// </summary>
    [JsonPropertyName(PropertyNames.Attributes)]
    public IEnumerable<TonNftAttribute>? Attributes { get; set; }

    /// <summary>
    /// Optional. The unique gift corresponding to the NFT
    /// </summary>
    [JsonPropertyName(PropertyNames.Gift)]
    public UniqueGift? Gift { get; set; }
}
