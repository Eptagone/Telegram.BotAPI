// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a photo, corresponding to the HTML tag <em>&lt;img&gt;</em>.
/// </summary>
public class InputRichBlockPhoto : InputRichBlock
{
    /// <summary>
    /// Type of the block, always “photo”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "photo";

    /// <summary>
    /// The photo. Caption is ignored.
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public InputMediaPhoto Photo { get; set; } = null!;

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
