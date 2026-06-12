// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A text with a phone number.
/// </summary>
public class RichTextPhoneNumber : RichText
{
    /// <summary>
    /// Type of the rich text, always “phone_number”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "phone_number";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The phone number
    /// </summary>
    [JsonPropertyName(PropertyNames.PhoneNumber)]
    public string PhoneNumber { get; set; } = null!;
}
