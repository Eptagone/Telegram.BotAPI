// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "PostStory" method.
/// </summary>
public class PostStoryArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PostStoryArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="content">Content of the story</param>
    /// <param name="activePeriod">Period after which the story is moved to the archive, in seconds; must be one of <em>6 * 3600</em>, <em>12 * 3600</em>, <em>86400</em>, or <em>2 * 86400</em></param>
    public PostStoryArgs(string businessConnectionId, InputStoryContent content, int activePeriod)
    {
        this.BusinessConnectionId = businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
        this.Content = content ?? throw new ArgumentNullException(nameof(content));
        this.ActivePeriod = activePeriod;
    }

    /// <summary>
    /// Unique identifier of the business connection
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; }

    /// <summary>
    /// Content of the story
    /// </summary>
    [JsonPropertyName(PropertyNames.Content)]
    public InputStoryContent Content { get; set; }

    /// <summary>
    /// Period after which the story is moved to the archive, in seconds; must be one of <em>6 * 3600</em>, <em>12 * 3600</em>, <em>86400</em>, or <em>2 * 86400</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.ActivePeriod)]
    public int ActivePeriod { get; set; }

    /// <summary>
    /// Caption of the story, 0-2048 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Mode for parsing entities in the story caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>
    /// A JSON-serialized list of clickable areas to be shown on the story
    /// </summary>
    [JsonPropertyName(PropertyNames.Areas)]
    public IEnumerable<StoryArea>? Areas { get; set; }

    /// <summary>
    /// Pass <em>True</em> to keep the story accessible after it expires
    /// </summary>
    [JsonPropertyName(PropertyNames.PostToChatPage)]
    public bool? PostToChatPage { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the content of the story must be protected from forwarding and screenshotting
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }
}
