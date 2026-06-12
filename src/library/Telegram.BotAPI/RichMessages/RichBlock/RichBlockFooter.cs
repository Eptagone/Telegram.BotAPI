// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A footer, corresponding to the HTML tag <em>&lt;footer&gt;</em>.
/// </summary>
public class RichBlockFooter : RichBlock
{
    /// <summary>
    /// Type of the block, always “footer”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "footer";

    /// <summary>
    /// Text of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;
}
