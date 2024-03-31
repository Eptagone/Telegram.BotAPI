// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// This object describes a sticker to be added to a sticker set.
/// </summary>
public class InputSticker
{
    /// <summary>
    /// The added sticker. Pass a <em>file_id</em> as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, upload a new one using multipart/form-data, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. Animated and video stickers can't be uploaded via HTTP URL. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public object Sticker { get; set; } = null!;

    /// <summary>
    /// Format of the added sticker, must be one of “static” for a <strong>.WEBP</strong> or <strong>.PNG</strong> image, “animated” for a <strong>.TGS</strong> animation, “video” for a <strong>WEBM</strong> video
    /// </summary>
    [JsonPropertyName(PropertyNames.Format)]
    public string Format { get; set; } = null!;

    /// <summary>
    /// List of 1-20 emoji associated with the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.EmojiList)]
    public IEnumerable<string> EmojiList { get; set; } = null!;

    /// <summary>
    /// Optional. Position where the mask should be placed on faces. For “mask” stickers only.
    /// </summary>
    [JsonPropertyName(PropertyNames.MaskPosition)]
    public MaskPosition? MaskPosition { get; set; }

    /// <summary>
    /// Optional. List of 0-20 search keywords for the sticker with total length of up to 64 characters. For “regular” and “custom_emoji” stickers only.
    /// </summary>
    [JsonPropertyName(PropertyNames.Keywords)]
    public IEnumerable<string>? Keywords { get; set; }
}
