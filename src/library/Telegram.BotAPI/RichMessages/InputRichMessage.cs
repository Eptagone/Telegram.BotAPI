// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Describes a rich message to be sent. Exactly <strong>one</strong> of the fields <em>html</em>, <em>markdown</em>, or <em>blocks</em> must be used.
/// </summary>
public class InputRichMessage
{
    /// <summary>
    /// Optional. Content of the rich message to send described as a list of blocks
    /// </summary>
    [JsonPropertyName(PropertyNames.Blocks)]
    public IEnumerable<InputRichBlock>? Blocks { get; set; }

    /// <summary>
    /// Optional. Content of the rich message to send described using HTML formatting. See <a href="https://core.telegram.org/bots/api#rich-message-formatting-options">rich message formatting options</a> for more details. Use <em>media</em> field to specify the media used in the message.
    /// </summary>
    [JsonPropertyName(PropertyNames.Html)]
    public string? Html { get; set; }

    /// <summary>
    /// Optional. Content of the rich message to send described using Markdown formatting. See <a href="https://core.telegram.org/bots/api#rich-message-formatting-options">rich message formatting options</a> for more details. Use <em>media</em> field to specify the media used in the message.
    /// </summary>
    [JsonPropertyName(PropertyNames.Markdown)]
    public string? Markdown { get; set; }

    /// <summary>
    /// Optional. List of media that are specified in the <em>markdown</em> or <em>html</em> fields using <em>tg://photo?id=</em>, <em>tg://video?id=</em>, and <em>tg://audio?id=</em> links
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public IEnumerable<InputRichMessageMedia>? Media { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if the rich message must be shown right-to-left
    /// </summary>
    [JsonPropertyName(PropertyNames.IsRtl)]
    public bool? IsRtl { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to skip automatic detection of entities (e.g., URLs, email addresses, username mentions, hashtags, cashtags, bot commands, or phone numbers) in the text
    /// </summary>
    [JsonPropertyName(PropertyNames.SkipEntityDetection)]
    public bool? SkipEntityDetection { get; set; }
}
