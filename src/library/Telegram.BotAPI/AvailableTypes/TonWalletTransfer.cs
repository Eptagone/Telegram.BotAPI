// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about a transfer with a TON wallet.
/// </summary>
public class TonWalletTransfer
{
    /// <summary>
    /// Unique identifier of the transaction; may be empty if the transfer hasn't been sent yet
    /// </summary>
    [JsonPropertyName(PropertyNames.TransactionId)]
    public string TransactionId { get; set; } = null!;

    /// <summary>
    /// Address of the transfer peer in the TON blockchain
    /// </summary>
    [JsonPropertyName(PropertyNames.PeerAddress)]
    public string PeerAddress { get; set; } = null!;

    /// <summary>
    /// The amount of transferred cryptocurrency, in the <em>smallest units</em> of the cryptocurrency, as a decimal number; negative for outgoing transfers
    /// </summary>
    [JsonPropertyName(PropertyNames.Amount)]
    public string Amount { get; set; } = null!;

    /// <summary>
    /// Optional. Comment added to the transfer; omitted if the comment is encrypted
    /// </summary>
    [JsonPropertyName(PropertyNames.Comment)]
    public string? Comment { get; set; }
}
