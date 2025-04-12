// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a photo to post as a story.
/// </summary>
public class InputStoryContentPhoto : InputStoryContent
{
    /// <summary>
    /// Type of the content, must be “photo”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// The photo to post as a story. The photo must be of the size 1080x1920 and must not exceed 10 MB. The photo can't be reused and can only be uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the photo was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public string Photo { get; set; } = null!;
}
