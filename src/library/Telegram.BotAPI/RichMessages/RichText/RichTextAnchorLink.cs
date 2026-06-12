// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A link to an anchor.
/// </summary>
public class RichTextAnchorLink : RichText
{
    /// <summary>
    /// Type of the rich text, always “anchor_link”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "anchor_link";

    /// <summary>
    /// The link text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The name of the anchor. If the name is empty, then the link brings back to the top of the message.
    /// </summary>
    [JsonPropertyName(PropertyNames.AnchorName)]
    public string AnchorName { get; set; } = null!;
}
