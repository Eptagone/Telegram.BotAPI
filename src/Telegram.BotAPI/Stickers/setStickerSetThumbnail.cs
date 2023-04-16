// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

public static partial class StickersExtensions
{
	/// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetStickerSetThumbnail(this BotClient? bot, SetStickerSetThumbnailArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.RPCF<bool>(MethodNames.SetStickerSetThumbnail, args);
	}
	/// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> SetStickerSetThumbAsync(this BotClient? bot, SetStickerSetThumbnailArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.RPCAF<bool>(MethodNames.SetStickerSetThumbnail, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="name">Sticker set name</param>
	/// <param name="userId">User identifier of the sticker set owner</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetStickerSetThumbnail(this BotClient? bot, string name, long userId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException(nameof(name));
		}

		if (userId == default)
		{
			throw new ArgumentNullException(nameof(userId));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.Name, name);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.RPC<bool>(MethodNames.SetStickerSetThumbnail, stream);
	}
	/// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="name">Sticker set name</param>
	/// <param name="userId">User identifier of the sticker set owner</param>
	/// <param name="thumbnail">Optional. A .WEBP or .PNG image with the thumbnail, must be up to 128 kilobytes in size and have a width and height of exactly 100px, or a .TGS animation with a thumbnail up to 32 kilobytes in size (see https://core.telegram.org/stickers#animated-sticker-requirements for animated sticker technical requirements), or a WEBM video with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/stickers#video-sticker-requirements for video sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ». Animated and video sticker set thumbnails can't be uploaded via HTTP URL. If omitted, then the thumbnail is dropped and the first sticker is used as the thumbnail.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetStickerSetThumbnail(this BotClient? bot, string name, long userId, string thumbnail)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException(nameof(name));
		}

		if (userId == default)
		{
			throw new ArgumentNullException(nameof(userId));
		}

		if (string.IsNullOrEmpty(thumbnail))
		{
			throw new ArgumentNullException(nameof(thumbnail));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.Name, name);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteString(PropertyNames.Thumbnail, thumbnail);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.RPC<bool>(MethodNames.SetStickerSetThumbnail, stream);
	}
	/// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="name">Sticker set name</param>
	/// <param name="userId">User identifier of the sticker set owner</param>
	/// <param name="thumbnail">Optional. A .WEBP or .PNG image with the thumbnail, must be up to 128 kilobytes in size and have a width and height of exactly 100px, or a .TGS animation with a thumbnail up to 32 kilobytes in size (see https://core.telegram.org/stickers#animated-sticker-requirements for animated sticker technical requirements), or a WEBM video with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/stickers#video-sticker-requirements for video sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ». Animated and video sticker set thumbnails can't be uploaded via HTTP URL. If omitted, then the thumbnail is dropped and the first sticker is used as the thumbnail.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetStickerSetThumbnail(this BotClient? bot, string name, long userId, InputFile thumbnail)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException(nameof(name));
		}

		if (userId == default)
		{
			throw new ArgumentNullException(nameof(userId));
		}

		var args = new SetStickerSetThumbnailArgs(name, userId) { Thumbnail = thumbnail };
		return bot.RPCF<bool>(MethodNames.SetStickerSetThumbnail, args);
	}
	/// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="name">Sticker set name</param>
	/// <param name="userId">User identifier of the sticker set owner</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> SetStickerSetThumbAsync(this BotClient? bot, string name, long userId, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException(nameof(name));
		}

		if (userId == default)
		{
			throw new ArgumentNullException(nameof(userId));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.Name, name);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.RPCA<bool>(MethodNames.SetStickerSetThumbnail, stream, cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="name">Sticker set name</param>
	/// <param name="userId">User identifier of the sticker set owner</param>
	/// <param name="thumbnail">Optional. A .WEBP or .PNG image with the thumbnail, must be up to 128 kilobytes in size and have a width and height of exactly 100px, or a .TGS animation with a thumbnail up to 32 kilobytes in size (see https://core.telegram.org/stickers#animated-sticker-requirements for animated sticker technical requirements), or a WEBM video with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/stickers#video-sticker-requirements for video sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ». Animated and video sticker set thumbnails can't be uploaded via HTTP URL. If omitted, then the thumbnail is dropped and the first sticker is used as the thumbnail.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> SetStickerSetThumbAsync(this BotClient? bot, string name, long userId, string thumbnail, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException(nameof(name));
		}

		if (userId == default)
		{
			throw new ArgumentNullException(nameof(userId));
		}

		if (string.IsNullOrEmpty(thumbnail))
		{
			throw new ArgumentNullException(nameof(thumbnail));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.Name, name);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteString(PropertyNames.Thumbnail, thumbnail);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.RPCA<bool>(MethodNames.SetStickerSetThumbnail, stream, cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="name">Sticker set name</param>
	/// <param name="userId">User identifier of the sticker set owner</param>
	/// <param name="thumbnail">Optional. A .WEBP or .PNG image with the thumbnail, must be up to 128 kilobytes in size and have a width and height of exactly 100px, or a .TGS animation with a thumbnail up to 32 kilobytes in size (see https://core.telegram.org/stickers#animated-sticker-requirements for animated sticker technical requirements), or a WEBM video with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/stickers#video-sticker-requirements for video sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ». Animated and video sticker set thumbnails can't be uploaded via HTTP URL. If omitted, then the thumbnail is dropped and the first sticker is used as the thumbnail.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> SetStickerSetThumbAsync(this BotClient? bot, string name, long userId, InputFile thumbnail, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException(nameof(name));
		}

		if (userId == default)
		{
			throw new ArgumentNullException(nameof(userId));
		}

		var args = new SetStickerSetThumbnailArgs(name, userId) { Thumbnail = thumbnail };
		return await bot.RPCAF<bool>(MethodNames.SetStickerSetThumbnail, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}
}
