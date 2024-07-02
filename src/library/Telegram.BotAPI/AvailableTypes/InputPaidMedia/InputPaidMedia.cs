// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the paid media to be sent. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="InputPaidMediaPhoto"/></description></item>
/// <item><description><see cref="InputPaidMediaVideo"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(InputPaidMediaConverter))]
public abstract class InputPaidMedia
{
    /// <summary>
    /// Type of the media
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }

    /// <summary>
    /// File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public string Media { get; set; } = null!;
}
