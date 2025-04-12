// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Describes a transaction with a chat.
/// </summary>
public class TransactionPartnerChat : TransactionPartner
{
    /// <summary>
    /// Type of the transaction partner, always “chat”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "chat";

    /// <summary>
    /// Information about the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Optional. The gift sent to the chat by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.Gift)]
    public Gift? Gift { get; set; }
}
