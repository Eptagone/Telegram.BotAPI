// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A text with an email address.
/// </summary>
public class RichTextEmailAddress : RichText
{
    /// <summary>
    /// Type of the rich text, always “email_address”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "email_address";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The email address
    /// </summary>
    [JsonPropertyName(PropertyNames.EmailAddress)]
    public string EmailAddress { get; set; } = null!;
}
