// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an attribute of an NFT in the TON blockchain.
/// </summary>
public class TonNftAttribute
{
    /// <summary>
    /// Trait type of the attribute
    /// </summary>
    [JsonPropertyName(PropertyNames.TraitType)]
    public string TraitType { get; set; } = null!;

    /// <summary>
    /// Value of the attribute
    /// </summary>
    [JsonPropertyName(PropertyNames.Value)]
    public string Value { get; set; } = null!;
}
