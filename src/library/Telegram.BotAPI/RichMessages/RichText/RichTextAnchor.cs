// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// An anchor.
/// </summary>
public class RichTextAnchor : RichText
{
    /// <summary>
    /// Type of the rich text, always “anchor”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "anchor";

    /// <summary>
    /// The name of the anchor
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;
}
