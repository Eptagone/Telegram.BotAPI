// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A text with a bank card number.
/// </summary>
public class RichTextBankCardNumber : RichText
{
    /// <summary>
    /// Type of the rich text, always “bank_card_number”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "bank_card_number";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The bank card number
    /// </summary>
    [JsonPropertyName(PropertyNames.BankCardNumber)]
    public string BankCardNumber { get; set; } = null!;
}
