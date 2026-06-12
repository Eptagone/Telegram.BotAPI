// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// An underlined text.
/// </summary>
public class RichTextUnderline : RichText
{
    /// <summary>
    /// Type of the rich text, always “underline”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "underline";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;
}
