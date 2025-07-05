// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "SetBusinessAccountProfilePhoto" method.
/// </summary>
public class SetBusinessAccountProfilePhotoArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetBusinessAccountProfilePhotoArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="photo">The new profile photo to set</param>
    public SetBusinessAccountProfilePhotoArgs(string businessConnectionId, InputProfilePhoto photo)
    {
        this.BusinessConnectionId = businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
        this.Photo = photo ?? throw new ArgumentNullException(nameof(photo));
    }

    /// <summary>
    /// Unique identifier of the business connection
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; }

    /// <summary>
    /// The new profile photo to set
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public InputProfilePhoto Photo { get; set; }

    /// <summary>
    /// Pass <em>True</em> to set the public photo, which will be visible even if the main photo is hidden by the business account's privacy settings. An account can have only one public photo.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsPublic)]
    public bool? IsPublic { get; set; }
}
