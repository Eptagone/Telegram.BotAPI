// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SetMyProfilePhoto" method.
/// </summary>
public class SetMyProfilePhotoArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetMyProfilePhotoArgs"/> class.
    /// </summary>
    /// <param name="photo">The new profile photo to set</param>
    public SetMyProfilePhotoArgs(InputProfilePhoto photo)
    {
        this.Photo = photo ?? throw new ArgumentNullException(nameof(photo));
    }

    /// <summary>
    /// The new profile photo to set
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public InputProfilePhoto Photo { get; set; }
}
