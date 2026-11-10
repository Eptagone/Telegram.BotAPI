// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// An address in the TON blockchain.
/// </summary>
public class RichTextTonAddress : RichText
{
    /// <summary>
    /// Type of the rich text, always “ton_address”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "ton_address";

    /// <summary>
    /// Text of the address
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The address
    /// </summary>
    [JsonPropertyName(PropertyNames.Address)]
    public string Address { get; set; } = null!;
}
