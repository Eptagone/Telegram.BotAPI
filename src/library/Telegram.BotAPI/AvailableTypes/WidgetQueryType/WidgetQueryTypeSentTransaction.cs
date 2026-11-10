// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The query notifies the bot about a transaction sent from a TON wallet of the user who sent the query.
/// </summary>
public class WidgetQueryTypeSentTransaction : WidgetQueryType
{
    /// <summary>
    /// Type of the query, always “sent_transaction”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "sent_transaction";

    /// <summary>
    /// The wallet from which the transaction was sent
    /// </summary>
    [JsonPropertyName(PropertyNames.Wallet)]
    public WidgetQueryWallet Wallet { get; set; } = null!;

    /// <summary>
    /// Value of <em>msg_hash</em> of the transaction
    /// </summary>
    [JsonPropertyName(PropertyNames.MsgHash)]
    public string MsgHash { get; set; } = null!;
}
