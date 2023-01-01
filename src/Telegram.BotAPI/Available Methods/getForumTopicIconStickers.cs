// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Stickers;

namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>
		/// Use this method to get custom emoji stickers, which can be used as a forum topic icon by any user. Requires no parameters. Returns an Array of Sticker objects.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Sticker[] GetForumTopicIconStickers(this BotClient? api)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			return api.RPC<Sticker[]>(MethodNames.GetForumTopicIconStickers);
		}

		/// <summary>
		/// Use this method to get custom emoji stickers, which can be used as a forum topic icon by any user. Requires no parameters. Returns an Array of Sticker objects.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Sticker[]> GetForumTopicIconStickersAsync(this BotClient? api, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			return await api.RPCA<Sticker[]>(MethodNames.GetForumTopicIconStickers, cancellationToken).ConfigureAwait(false);
		}
	}
}
