// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A superscript text.
/// </summary>
public class RichTextSuperscript : RichText
{
    /// <summary>
    /// Type of the rich text, always “superscript”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "superscript";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;
}
