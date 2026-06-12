// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Cell in a table.
/// </summary>
public class RichBlockTableCell
{
    /// <summary>
    /// Optional. Text in the cell. If omitted, then the cell is invisible.
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText? Text { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the cell is a header cell
    /// </summary>
    [JsonPropertyName(PropertyNames.IsHeader)]
    public bool? IsHeader { get; set; }

    /// <summary>
    /// Optional. The number of columns the cell spans if it is bigger than 1
    /// </summary>
    [JsonPropertyName(PropertyNames.Colspan)]
    public int? Colspan { get; set; }

    /// <summary>
    /// Optional. The number of rows the cell spans if it is bigger than 1
    /// </summary>
    [JsonPropertyName(PropertyNames.Rowspan)]
    public int? Rowspan { get; set; }

    /// <summary>
    /// Horizontal cell content alignment. Currently, must be one of “left”, “center”, or “right”.
    /// </summary>
    [JsonPropertyName(PropertyNames.Align)]
    public string Align { get; set; } = null!;

    /// <summary>
    /// Vertical cell content alignment. Currently, must be one of “top”, “middle”, or “bottom”.
    /// </summary>
    [JsonPropertyName(PropertyNames.Valign)]
    public string Valign { get; set; } = null!;
}
