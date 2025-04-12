// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "EditStory" method.
/// </summary>
public class EditStoryArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditStoryArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="storyId">Unique identifier of the story to edit</param>
    /// <param name="content">Content of the story</param>
    public EditStoryArgs(string businessConnectionId, int storyId, InputStoryContent content)
    {
        this.BusinessConnectionId = businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
        this.StoryId = storyId;
        this.Content = content ?? throw new ArgumentNullException(nameof(content));
    }

    /// <summary>
    /// Unique identifier of the business connection
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; }

    /// <summary>
    /// Unique identifier of the story to edit
    /// </summary>
    [JsonPropertyName(PropertyNames.StoryId)]
    public int StoryId { get; set; }

    /// <summary>
    /// Content of the story
    /// </summary>
    [JsonPropertyName(PropertyNames.Content)]
    public InputStoryContent Content { get; set; }

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
}
