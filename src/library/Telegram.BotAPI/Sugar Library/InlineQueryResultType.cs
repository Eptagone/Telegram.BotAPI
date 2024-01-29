// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.InlineMode;

/// <summary>Types of InlineQueryResult.</summary>
public sealed class InlineQueryResultType
{
    /// <summary>Article.</summary>
    public const string Article = "article";

    /// <summary>Audio.</summary>
    public const string Audio = PropertyNames.Audio;

    /// <summary>Document.</summary>
    public const string Document = PropertyNames.Document;

    /// <summary>Gif.</summary>
    public const string Gif = "gif";

    /// <summary>Mpeg4 Ggif.</summary>
    public const string Mpeg4Gif = "mpeg4_gif";

    /// <summary>Photo.</summary>
    public const string Photo = PropertyNames.Photo;

    /// <summary>Sticker.</summary>
    public const string Sticker = PropertyNames.Sticker;

    /// <summary>Video.</summary>
    public const string Video = PropertyNames.Video;

    /// <summary>Voice.</summary>
    public const string Voice = PropertyNames.Voice;

    /// <summary>Contact.</summary>
    public const string Contact = PropertyNames.Contact;

    /// <summary>Game.</summary>
    public const string Game = PropertyNames.Game;

    /// <summary>Location.</summary>
    public const string Location = PropertyNames.Location;

    /// <summary>Venue.</summary>
    public const string Venue = PropertyNames.Venue;
}
