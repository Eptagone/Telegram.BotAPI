// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

public static partial class StickersExtensions
{
	/// <summary>
	/// Use this method to add a new sticker to a set created by the bot. The format of the added sticker must match the format of the other stickers in the set. Emoji sticker sets can have up to 200 stickers. Animated and video sticker sets can have up to 50 stickers. Static sticker sets can have up to 120 stickers. Returns True on success.
	/// </summary>
	/// <param name="bot">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool AddStickerToSet(this BotClient? bot, AddStickerToSetArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.RPCF<bool>(MethodNames.AddStickerToSet, args);
	}

	/// <summary>
	/// Use this method to add a new sticker to a set created by the bot. The format of the added sticker must match the format of the other stickers in the set. Emoji sticker sets can have up to 200 stickers. Animated and video sticker sets can have up to 50 stickers. Static sticker sets can have up to 120 stickers. Returns True on success.
	/// </summary>
	/// <param name="bot">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> AddStickerToSetAsync(this BotClient? bot, AddStickerToSetArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.RPCAF<bool>(MethodNames.AddStickerToSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to add a new sticker to a set created by the bot. The format of the added sticker must match the format of the other stickers in the set. Emoji sticker sets can have up to 200 stickers. Animated and video sticker sets can have up to 50 stickers. Static sticker sets can have up to 120 stickers. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="userId">User identifier of sticker set owner.</param>
	/// <param name="name">Sticker set name.</param>
	/// <param name="sticker">A <see cref="InputSticker"/> object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.</param>
	/// <param name="attachedFiles">Optional. A <see cref="AttachedFile"/> list of files to attach to the request.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool AddStickerToSet(this BotClient? api, long userId, string name, InputSticker sticker, [Optional] IEnumerable<AttachedFile>? attachedFiles)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new AddStickerToSetArgs(userId, name, sticker)
		{
			AttachedFiles = attachedFiles ?? Array.Empty<AttachedFile>()
		};
		return api.RPCF<bool>(MethodNames.AddStickerToSet, args);
	}

	/// <summary>
	/// Use this method to add a new sticker to a set created by the bot. The format of the added sticker must match the format of the other stickers in the set. Emoji sticker sets can have up to 200 stickers. Animated and video sticker sets can have up to 50 stickers. Static sticker sets can have up to 120 stickers. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="userId">User identifier of sticker set owner.</param>
	/// <param name="name">Sticker set name.</param>
	/// <param name="sticker">A <see cref="InputSticker"/> object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.</param>
	/// <param name="attachedFiles">Optional. A <see cref="AttachedFile"/> list of files to attach to the request.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> AddStickerToSetAsync(this BotClient? api, long userId, string name, InputSticker sticker, [Optional] IEnumerable<AttachedFile>? attachedFiles, [Optional] CancellationToken cancellationToken)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new AddStickerToSetArgs(userId, name, sticker) {
			AttachedFiles = attachedFiles ?? Array.Empty<AttachedFile>()
		};
		return await api.RPCAF<bool>(MethodNames.AddStickerToSet, args, cancellationToken).ConfigureAwait(false);
	}
}
