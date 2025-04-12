// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a video to post as a story.
/// </summary>
public class InputStoryContentVideo : InputStoryContent
{
    /// <summary>
    /// Type of the content, must be “video”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// The video to post as a story. The video must be of the size 720x1280, streamable, encoded with H.265 codec, with key frames added each second in the MPEG4 format, and must not exceed 30 MB. The video can't be reused and can only be uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the video was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Video)]
    public string Video { get; set; } = null!;

    /// <summary>
    /// Optional. Precise duration of the video in seconds; 0-60
    /// </summary>
    [JsonPropertyName(PropertyNames.Duration)]
    public float? Duration { get; set; }

    /// <summary>
    /// Optional. Timestamp in seconds of the frame that will be used as the static cover for the story. Defaults to 0.0.
    /// </summary>
    [JsonPropertyName(PropertyNames.CoverFrameTimestamp)]
    public float? CoverFrameTimestamp { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if the video has no sound
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAnimation)]
    public bool? IsAnimation { get; set; }
}
