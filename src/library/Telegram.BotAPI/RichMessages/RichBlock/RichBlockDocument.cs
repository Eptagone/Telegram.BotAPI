// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a general file, corresponding to the custom HTML tag <em>&lt;tg-document&gt;</em>.
/// </summary>
public class RichBlockDocument : RichBlock
{
    /// <summary>
    /// Type of the block, always “document”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "document";

    /// <summary>
    /// The document
    /// </summary>
    [JsonPropertyName(PropertyNames.Document)]
    public Document Document { get; set; } = null!;

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
