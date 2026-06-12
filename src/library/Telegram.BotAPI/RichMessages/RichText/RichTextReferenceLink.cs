// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A link to a reference.
/// </summary>
public class RichTextReferenceLink : RichText
{
    /// <summary>
    /// Type of the rich text, always “reference_link”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "reference_link";

    /// <summary>
    /// The link text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The name of the reference
    /// </summary>
    [JsonPropertyName(PropertyNames.ReferenceName)]
    public string ReferenceName { get; set; } = null!;
}
