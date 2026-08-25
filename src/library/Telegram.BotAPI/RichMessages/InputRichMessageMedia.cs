// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Describes a media element embedded in an outgoing rich message.
/// </summary>
public class InputRichMessageMedia
{
    /// <summary>
    /// Unique identifier of the media used in a <em>tg://photo?id=</em>, <em>tg://video?id=</em>, <em>tg://document?id=</em>, or <em>tg://audio?id=</em> link. 1-64 characters, only <em>A-Z</em>, <em>a-z</em>, <em>0-9</em>, <em>_</em> and <em>-</em> are allowed.
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The media to be sent. Everything except the media itself and its properties is ignored.
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public object Media { get; set; } = null!;
}
