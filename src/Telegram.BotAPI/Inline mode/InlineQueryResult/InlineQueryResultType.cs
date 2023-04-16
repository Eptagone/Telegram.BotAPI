// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.InlineMode;

/// <summary>Types of InlineQueryResult.</summary>
public sealed class InlineQueryResultType
{
	/// <summary>Article.</summary>
	public const string Article = "article";
	/// <summary>Audio.</summary>
	public const string Audio = CommonNames.Audio;
	/// <summary>Document.</summary>
	public const string Document = CommonNames.Document;
	/// <summary>Gif.</summary>
	public const string Gif = "gif";
	/// <summary>Mpeg4 Ggif.</summary>
	public const string Mpeg4Gif = "mpeg4_gif";
	/// <summary>Photo.</summary>
	public const string Photo = CommonNames.Photo;
	/// <summary>Sticker.</summary>
	public const string Sticker = CommonNames.Sticker;
	/// <summary>Video.</summary>
	public const string Video = CommonNames.Video;
	/// <summary>Voice.</summary>
	public const string Voice = CommonNames.Voice;
	/// <summary>Contact.</summary>
	public const string Contact = CommonNames.Contact;
	/// <summary>Game.</summary>
	public const string Game = CommonNames.Game;
	/// <summary>Location.</summary>
	public const string Location = CommonNames.Location;
	/// <summary>Venue.</summary>
	public const string Venue = CommonNames.Venue;
}
