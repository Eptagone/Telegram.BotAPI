// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a profile photo to set. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="InputProfilePhotoStatic"/></description></item>
/// <item><description><see cref="InputProfilePhotoAnimated"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(InputProfilePhotoConverter))]
public abstract class InputProfilePhoto
{
    /// <summary>
    /// Type of the profile photo
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; set; }
}
