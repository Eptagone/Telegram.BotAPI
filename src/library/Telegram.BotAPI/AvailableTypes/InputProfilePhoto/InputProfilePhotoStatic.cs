// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// A static profile photo in the .JPG format.
/// </summary>
public class InputProfilePhotoStatic : InputProfilePhoto
{
    /// <summary>
    /// Type of the profile photo, must be “static”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// The static profile photo. Profile photos can't be reused and can only be uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the photo was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public string Photo { get; set; } = null!;
}
