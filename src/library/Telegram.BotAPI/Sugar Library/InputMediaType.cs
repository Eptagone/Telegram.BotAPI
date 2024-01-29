// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Type of input media. Can be “animation”, “audio”, “document”, “photo”, or “video”.</summary>
public static class InputMediaType
{
    /// <summary>Animation.</summary>
    public const string Animation = PropertyNames.Animation;

    /// <summary>Audio.</summary>
    public const string Audio = PropertyNames.Audio;

    /// <summary>Document.</summary>
    public const string Document = PropertyNames.Document;

    /// <summary>Photo.</summary>
    public const string Photo = PropertyNames.Photo;

    /// <summary>Video.</summary>
    public const string Video = PropertyNames.Video;
}
