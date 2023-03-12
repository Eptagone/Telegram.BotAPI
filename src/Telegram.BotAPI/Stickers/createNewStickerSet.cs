// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Stickers
{
	public static partial class StickersExtensions
	{
		/// <summary>
		/// Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. Returns True on success.
		/// </summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool CreateNewStickerSet(this BotClient? bot, CreateNewStickerSetArgs args)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return bot.RPCF<bool>(MethodNames.CreateNewStickerSet, args);
		}

		/// <summary>
		/// Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. Returns True on success.
		/// </summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> CreateNewStickerSetAsync(this BotClient? bot, CreateNewStickerSetArgs args, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return await bot.RPCAF<bool>(MethodNames.CreateNewStickerSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. Returns True on success.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="userId">User identifier of created sticker set owner.</param>
		/// <param name="name">Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only English letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in "_by_&lt;bot_username&gt;". &lt;bot_username&gt; is case insensitive. 1-64 characters.</param>
		/// <param name="title">Sticker set title, 1-64 characters.</param>
		/// <param name="stickers">A <see cref="InputSticker"/> list of 1-50 initial stickers to be added to the sticker set.</param>
		/// <param name="stickerFormat">Format of stickers in the set, must be one of “static”, “animated”, “video”.</param>
		/// <param name="stickerType">Optional. Type of stickers in the set, pass “regular”, “mask”, or “custom_emoji”. By default, a regular sticker set is created.</param>
		/// <param name="needsRepainting">Optional. Pass True if stickers in the sticker set must be repainted to the color of text when used in messages, the accent color if used as emoji status, white on chat photos, or another appropriate color based on context; for custom emoji sticker sets only.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool CreateNewStickerSet(this BotClient? api, int userId, string name, string title, IEnumerable<InputSticker> stickers, string stickerFormat, [Optional] string? stickerType, [Optional] bool? needsRepainting)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new CreateNewStickerSetArgs(userId, name, title, stickers, stickerFormat)
			{
				StickerType = stickerType,
				NeedsRepainting = needsRepainting
			};
			return api.RPCF<bool>(MethodNames.CreateNewStickerSet, args);
		}

		/// <summary>
		/// Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. Returns True on success.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="userId">User identifier of created sticker set owner.</param>
		/// <param name="name">Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only English letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in "_by_&lt;bot_username&gt;". &lt;bot_username&gt; is case insensitive. 1-64 characters.</param>
		/// <param name="title">Sticker set title, 1-64 characters.</param>
		/// <param name="stickers">A <see cref="InputSticker"/> list of 1-50 initial stickers to be added to the sticker set.</param>
		/// <param name="stickerFormat">Format of stickers in the set, must be one of “static”, “animated”, “video”.</param>
		/// <param name="stickerType">Optional. Type of stickers in the set, pass “regular”, “mask”, or “custom_emoji”. By default, a regular sticker set is created.</param>
		/// <param name="needsRepainting">Optional. Pass True if stickers in the sticker set must be repainted to the color of text when used in messages, the accent color if used as emoji status, white on chat photos, or another appropriate color based on context; for custom emoji sticker sets only.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> CreateNewStickerSetAsync(this BotClient? api, int userId, string name, string title, IEnumerable<InputSticker> stickers, string stickerFormat, [Optional] string? stickerType, [Optional] bool? needsRepainting, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new CreateNewStickerSetArgs(userId, name, title, stickers, stickerFormat)
			{
				StickerType = stickerType,
				NeedsRepainting = needsRepainting
			};
			return await api.RPCAF<bool>(MethodNames.CreateNewStickerSet, args, cancellationToken).ConfigureAwait(false);
		}
	}
}
