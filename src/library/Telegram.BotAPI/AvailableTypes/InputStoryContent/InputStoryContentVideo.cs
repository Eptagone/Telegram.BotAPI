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
    /// Initializes a new instance of the <see cref="InputStoryContentVideo"/> class.
    /// </summary>
    /// <param name="video">The video to post as a story. The video must be of the size 720x1280, streamable, encoded with H.265 codec, with key frames added each second in the MPEG4 format, and must not exceed 30 MB. The video can't be reused and can only be uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the video was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    public InputStoryContentVideo(string video)
    {
        this.Video = video ?? throw new ArgumentNullException(nameof(video));
    }

    /// <summary>
    /// Type of the content, must be <em>video</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "video";

    /// <summary>
    /// The video to post as a story. The video must be of the size 720x1280, streamable, encoded with H.265 codec, with key frames added each second in the MPEG4 format, and must not exceed 30 MB. The video can't be reused and can only be uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the video was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Video)]
    public string Video { get; set; }

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
