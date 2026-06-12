// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A reference.
/// </summary>
public class RichTextReference : RichText
{
    /// <summary>
    /// Type of the rich text, always “reference”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "reference";

    /// <summary>
    /// Text of the reference
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The name of the reference
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;
}
