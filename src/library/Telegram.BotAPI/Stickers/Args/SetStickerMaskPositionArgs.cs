// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "SetStickerMaskPosition" method.
/// </summary>
public class SetStickerMaskPositionArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetStickerMaskPositionArgs"/> class.
    /// </summary>
    /// <param name="sticker">File identifier of the sticker</param>
    public SetStickerMaskPositionArgs(string sticker)
    {
        this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
    }

    /// <summary>
    /// File identifier of the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public string Sticker { get; set; }

    /// <summary>
    /// A JSON-serialized object with the position where the mask should be placed on faces. Omit the parameter to remove the mask position.
    /// </summary>
    [JsonPropertyName(PropertyNames.MaskPosition)]
    public MaskPosition? MaskPosition { get; set; }
}
