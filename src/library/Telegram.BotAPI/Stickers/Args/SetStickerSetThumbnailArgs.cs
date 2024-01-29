// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "SetStickerSetThumbnail" method.
/// </summary>
public class SetStickerSetThumbnailArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetStickerSetThumbnailArgs"/> class.
    /// </summary>
    /// <param name="name">Sticker set name</param>
    /// <param name="userId">User identifier of the sticker set owner</param>
    public SetStickerSetThumbnailArgs(string name, long userId)
    {
        this.Name = name ?? throw new ArgumentNullException(nameof(name));
        this.UserId = userId;
    }

    /// <summary>
    /// Sticker set name
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; }

    /// <summary>
    /// User identifier of the sticker set owner
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// A <strong>.WEBP</strong> or <strong>.PNG</strong> image with the thumbnail, must be up to 128 kilobytes in size and have a width and height of exactly 100px, or a <strong>.TGS</strong> animation with a thumbnail up to 32 kilobytes in size (see <a href="/stickers#animated-sticker-requirements"></a><a href="https://core.telegram.org/stickers#animated-sticker-requirements">https://core.telegram.org/stickers#animated-sticker-requirements</a> for animated sticker technical requirements), or a <strong>WEBM</strong> video with the thumbnail up to 32 kilobytes in size; see <a href="/stickers#video-sticker-requirements"></a><a href="https://core.telegram.org/stickers#video-sticker-requirements">https://core.telegram.org/stickers#video-sticker-requirements</a> for video sticker technical requirements. Pass a <em>file_id</em> as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Animated and video sticker set thumbnails can't be uploaded via HTTP URL. If omitted, then the thumbnail is dropped and the first sticker is used as the thumbnail.
    /// </summary>
    [JsonPropertyName(PropertyNames.Thumbnail)]
    public object? Thumbnail { get; set; }
}
