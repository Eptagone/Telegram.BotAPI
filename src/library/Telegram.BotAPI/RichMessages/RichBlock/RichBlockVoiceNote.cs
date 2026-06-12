// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a voice note, corresponding to the HTML tag <em>&lt;audio&gt;</em>.
/// </summary>
public class RichBlockVoiceNote : RichBlock
{
    /// <summary>
    /// Type of the block, always “voice_note”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "voice_note";

    /// <summary>
    /// The voice note
    /// </summary>
    [JsonPropertyName(PropertyNames.VoiceNote)]
    public Voice VoiceNote { get; set; } = null!;

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
