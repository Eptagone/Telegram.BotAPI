// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Stickers;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to get custom emoji stickers, which can be used as a forum topic icon by any user. Requires no parameters. Returns an Array of Sticker objects.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Sticker[] GetForumTopicIconStickers(this ITelegramBotClient api)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		return api.CallMethod<Sticker[]>(MethodNames.GetForumTopicIconStickers);
	}

	/// <summary>
	/// Use this method to get custom emoji stickers, which can be used as a forum topic icon by any user. Requires no parameters. Returns an Array of Sticker objects.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Sticker[]> GetForumTopicIconStickersAsync(this ITelegramBotClient api, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		return await api.CallMethodAsync<Sticker[]>(MethodNames.GetForumTopicIconStickers, cancellationToken).ConfigureAwait(false);
	}
}
