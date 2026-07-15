// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A preformatted text block, corresponding to the nested HTML tags <em>&lt;pre&gt;</em> and <em>&lt;code&gt;</em>.
/// </summary>
public class InputRichBlockPreformatted : InputRichBlock
{
    /// <summary>
    /// Type of the block, always “pre”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "pre";

    /// <summary>
    /// Text of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// Optional. The programming language of the text
    /// </summary>
    [JsonPropertyName(PropertyNames.Language)]
    public string? Language { get; set; }
}
