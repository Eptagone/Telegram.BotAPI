// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The paid media to send is a photo.
/// </summary>
public class InputPaidMediaPhoto : InputPaidMedia
{
    /// <summary>
    /// Type of the media, must be <em>photo</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "photo";

    /// <summary>
    /// File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public override string Media { get; set; } = null!;
}
