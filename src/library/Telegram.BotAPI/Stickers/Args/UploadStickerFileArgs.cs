// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "UploadStickerFile" method.
/// </summary>
public class UploadStickerFileArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UploadStickerFileArgs"/> class.
    /// </summary>
    /// <param name="userId">User identifier of sticker file owner</param>
    /// <param name="sticker">A file with the sticker in .WEBP, .PNG, .TGS, or .WEBM format. See <a href="/stickers"></a><a href="https://core.telegram.org/stickers">https://core.telegram.org/stickers</a> for technical requirements. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="stickerFormat">Format of the sticker, must be one of “static”, “animated”, “video”</param>
    public UploadStickerFileArgs(long userId, InputFile sticker, string stickerFormat)
    {
        this.UserId = userId;
        this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
        this.StickerFormat = stickerFormat ?? throw new ArgumentNullException(nameof(stickerFormat));
    }

    /// <summary>
    /// User identifier of sticker file owner
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// A file with the sticker in .WEBP, .PNG, .TGS, or .WEBM format. See <a href="/stickers"></a><a href="https://core.telegram.org/stickers">https://core.telegram.org/stickers</a> for technical requirements. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public InputFile Sticker { get; set; }

    /// <summary>
    /// Format of the sticker, must be one of “static”, “animated”, “video”
    /// </summary>
    [JsonPropertyName(PropertyNames.StickerFormat)]
    public string StickerFormat { get; set; }
}
