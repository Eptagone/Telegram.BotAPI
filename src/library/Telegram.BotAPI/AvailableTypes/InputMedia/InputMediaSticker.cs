// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a sticker file to be sent.
/// </summary>
public class InputMediaSticker : InputMedia
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputMediaSticker"/> class.
    /// </summary>
    /// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a .WEBP sticker from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new .WEBP, .TGS, or .WEBM sticker using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    public InputMediaSticker(string media)
    {
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Type of the result, must be <em>sticker</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "sticker";

    /// <summary>
    /// File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a .WEBP sticker from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new .WEBP, .TGS, or .WEBM sticker using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public string Media { get; set; }

    /// <summary>
    /// Optional. Emoji associated with the sticker; only for just uploaded stickers
    /// </summary>
    [JsonPropertyName(PropertyNames.Emoji)]
    public string? Emoji { get; set; }
}
