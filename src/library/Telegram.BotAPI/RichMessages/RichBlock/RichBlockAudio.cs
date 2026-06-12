// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a music file, corresponding to the HTML tag <em>&lt;audio&gt;</em>.
/// </summary>
public class RichBlockAudio : RichBlock
{
    /// <summary>
    /// Type of the block, always “audio”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "audio";

    /// <summary>
    /// The audio
    /// </summary>
    [JsonPropertyName(PropertyNames.Audio)]
    public Audio Audio { get; set; } = null!;

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
