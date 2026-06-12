// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// An item of a list.
/// </summary>
public class RichBlockListItem
{
    /// <summary>
    /// Label of the item
    /// </summary>
    [JsonPropertyName(PropertyNames.Label)]
    public string Label { get; set; } = null!;

    /// <summary>
    /// The content of the item
    /// </summary>
    [JsonPropertyName(PropertyNames.Blocks)]
    public IEnumerable<RichBlock> Blocks { get; set; } = null!;

    /// <summary>
    /// Optional. <em>True</em>, if the item has a checkbox
    /// </summary>
    [JsonPropertyName(PropertyNames.HasCheckbox)]
    public bool? HasCheckbox { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the item has a checked checkbox
    /// </summary>
    [JsonPropertyName(PropertyNames.IsChecked)]
    public bool? IsChecked { get; set; }

    /// <summary>
    /// Optional. For ordered lists, the numeric value of the item label
    /// </summary>
    [JsonPropertyName(PropertyNames.Value)]
    public int? Value { get; set; }

    /// <summary>
    /// Optional. For ordered lists, the type of the item label; must be one of “a” for lowercase letters, “A” for uppercase letters, “i” for lowercase Roman numerals, “I” for uppercase Roman numerals, or “1” for decimal numbers
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public string? Type { get; set; }
}
