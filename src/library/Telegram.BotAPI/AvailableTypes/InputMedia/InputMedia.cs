// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents the content of a media message to be sent. It should be one of
/// <list type="bullet">
/// <item><description><see cref="InputMediaAnimation"/></description></item>
/// <item><description><see cref="InputMediaDocument"/></description></item>
/// <item><description><see cref="InputMediaAudio"/></description></item>
/// <item><description><see cref="InputMediaPhoto"/></description></item>
/// <item><description><see cref="InputMediaVideo"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(InputMediaConverter))]
public abstract class InputMedia
{
    /// <summary>
    /// Type of the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }

    /// <summary>
    /// File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public string Media { get; set; } = null!;

    /// <summary>
    ///  0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public abstract string? Caption { get; set; }

    /// <summary>
    /// No description available
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public abstract string? ParseMode { get; set; }

    /// <summary>
    /// Optional. List of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }
}
