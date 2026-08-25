// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block containing a list of buttons that are shown in one row, corresponding to the custom HTML tag <em>&lt;tg-button-row&gt;</em>.
/// </summary>
public class RichBlockButtons : RichBlock
{
    /// <summary>
    /// Type of the block, always “buttons”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "buttons";

    /// <summary>
    /// The buttons
    /// </summary>
    [JsonPropertyName(PropertyNames.Buttons)]
    public IEnumerable<RichMessageButton> Buttons { get; set; } = null!;

    /// <summary>
    /// Optional. Horizontal alignment of the buttons. Currently, must be one of “left”, “center”, or “right”.
    /// </summary>
    [JsonPropertyName(PropertyNames.Align)]
    public string? Align { get; set; }
}
