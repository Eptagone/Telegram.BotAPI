// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a TON wallet of the user, which is used in a query from a widget.
/// </summary>
public class WidgetQueryWallet
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
    /// Optional. Hex-encoded public key of the wallet; omitted if unknown
    /// </summary>
    [JsonPropertyName(PropertyNames.PublicKey)]
    public string? PublicKey { get; set; }

    /// <summary>
    /// Optional. Base64-encoded serialized StateInit of the wallet contract; omitted if and only if <em>public_key</em> is omitted
    /// </summary>
    [JsonPropertyName(PropertyNames.StateInit)]
    public string? StateInit { get; set; }
}
