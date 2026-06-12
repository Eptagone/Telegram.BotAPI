// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A table, corresponding to the HTML tag <em>&lt;table&gt;</em>.
/// </summary>
public class RichBlockTable : RichBlock
{
    /// <summary>
    /// Type of the block, always “table”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "table";

    /// <summary>
    /// Cells of the table
    /// </summary>
    [JsonPropertyName(PropertyNames.Cells)]
    public IEnumerable<IEnumerable<RichBlockTableCell>> Cells { get; set; } = null!;

    /// <summary>
    /// Optional. <em>True</em>, if the table has borders
    /// </summary>
    [JsonPropertyName(PropertyNames.IsBordered)]
    public bool? IsBordered { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the table is striped
    /// </summary>
    [JsonPropertyName(PropertyNames.IsStriped)]
    public bool? IsStriped { get; set; }

    /// <summary>
    /// Optional. Caption of the table
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichText? Caption { get; set; }
}
