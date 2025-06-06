// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// An animated profile photo in the MPEG4 format.
/// </summary>
public class InputProfilePhotoAnimated : InputProfilePhoto
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputProfilePhotoAnimated"/> class.
    /// </summary>
    /// <param name="animation">The animated profile photo. Profile photos can't be reused and can only be uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the photo was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    public InputProfilePhotoAnimated(string animation)
    {
        this.Animation = animation ?? throw new ArgumentNullException(nameof(animation));
    }

    /// <summary>
    /// Type of the profile photo, must be <em>animated</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "animated";

    /// <summary>
    /// The animated profile photo. Profile photos can't be reused and can only be uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the photo was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Animation)]
    public string Animation { get; set; }

    /// <summary>
    /// Optional. Timestamp in seconds of the frame that will be used as the static profile photo. Defaults to 0.0.
    /// </summary>
    [JsonPropertyName(PropertyNames.MainFrameTimestamp)]
    public float? MainFrameTimestamp { get; set; }
}
