// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Stickers;

public static partial class StickersExtensions
{
	/// <summary>
	/// Use this method to change the mask position of a mask sticker. The sticker must belong to a sticker set that was created by the bot. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client</param>
	/// <param name="args">A <see cref="SetStickerMaskPositionArgs"/> object with the required parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetStickerMaskPosition(this BotClient api, SetStickerMaskPositionArgs args)
	{
		if (api == null)
		{
			throw new ArgumentNullException(nameof(api));
		}

		return api.RPC<bool>(MethodNames.SetStickerMaskPosition, args);
	}

	/// <summary>
	/// Use this method to change the mask position of a mask sticker. The sticker must belong to a sticker set that was created by the bot. Returns True on success.
	/// </summary>
	/// <param name="api">BotClient</param>
	/// <param name="args">A <see cref="SetStickerMaskPositionArgs"/> object with the required parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> SetStickerMaskPositionAsync<T>(this BotClient api, SetStickerMaskPositionArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (api == null)
		{
			throw new ArgumentNullException(nameof(api));
		}

		return await api.RPCA<bool>(MethodNames.SetStickerMaskPosition, args, cancellationToken)
			.ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to change the mask position of a mask sticker. The sticker must belong to a sticker set that was created by the bot. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client</param>
	/// <param name="sticker">File identifier of the sticker</param>
	/// <param name="maskPosition">A <see cref="MaskPosition"/> object with the position where the mask should be placed on faces. Omit the parameter to remove the mask position.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetStickerMaskPosition(this BotClient api, string sticker, [Optional] MaskPosition? maskPosition)
	{
		if (api == null)
		{
			throw new ArgumentNullException(nameof(api));
		}

		var args = new SetStickerMaskPositionArgs(sticker)
		{
			MaskPosition = maskPosition
		};
		return api.RPC<bool>(MethodNames.SetStickerMaskPosition, args);
	}

	/// <summary>
	/// Use this method to change the mask position of a mask sticker. The sticker must belong to a sticker set that was created by the bot. Returns True on success.
	/// </summary>
	/// <param name="api">BotClient</param>
	/// <param name="sticker">File identifier of the sticker</param>
	/// <param name="maskPosition">A <see cref="MaskPosition"/> object with the position where the mask should be placed on faces. Omit the parameter to remove the mask position.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> SetStickerMaskPositionAsync(this BotClient api, string sticker, [Optional] MaskPosition? maskPosition, [Optional] CancellationToken cancellationToken)
	{
		if (api == null)
		{
			throw new ArgumentNullException(nameof(api));
		}

		var args = new SetStickerMaskPositionArgs(sticker)
		{
			MaskPosition = maskPosition
		};
		return await api.RPCA<bool>(MethodNames.SetStickerMaskPosition, args, cancellationToken)
			.ConfigureAwait(false);
	}
}
