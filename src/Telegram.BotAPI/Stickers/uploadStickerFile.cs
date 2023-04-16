// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

public static partial class StickersExtensions
{
	/// <summary>
	/// Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded <see cref="File"/> on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static File UploadStickerFile(this BotClient? bot, UploadStickerFileArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.RPCF<File>(MethodNames.UploadStickerFile, args);
	}

	/// <summary>
	/// Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded <see cref="File"/> on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<File> UploadStickerFileAsync(this BotClient? bot, UploadStickerFileArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.RPCAF<File>(MethodNames.UploadStickerFile, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded <see cref="File"/> on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="userId">User identifier of sticker file owner.</param>
	/// <param name="sticker"> A file with the sticker in .WEBP, .PNG, .TGS, or .WEBM format. See https://core.telegram.org/stickers for technical requirements. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
	/// <param name="stickerFormat">Format of the sticker, must be one of “static”, “animated”, “video”</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static File UploadStickerFile(this BotClient? bot, long userId, InputFile sticker, string stickerFormat)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.RPCF<File>(MethodNames.UploadStickerFile, new UploadStickerFileArgs(userId, sticker, stickerFormat));
	}


	/// <summary>
	/// Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded <see cref="File"/> on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="userId">User identifier of sticker file owner.</param>
	/// <param name="sticker"> A file with the sticker in .WEBP, .PNG, .TGS, or .WEBM format. See https://core.telegram.org/stickers for technical requirements. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
	/// <param name="stickerFormat">Format of the sticker, must be one of “static”, “animated”, “video”</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<File> UploadStickerFileAsync(this BotClient? bot, long userId, InputFile sticker, string stickerFormat, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return await bot.RPCAF<File>(MethodNames.UploadStickerFile, new UploadStickerFileArgs(userId, sticker, stickerFormat), cancellationToken: cancellationToken).ConfigureAwait(false);
	}
}
