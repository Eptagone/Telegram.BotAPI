// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Stickers
{
	public static partial class StickersExtensions
	{
		/// <summary>Use this method to get a sticker set. On success, a StickerSet object is returned.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="name">Name of the sticker set.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		/// <returns><see cref="StickerSet"/> object.</returns>
		public static StickerSet GetStickerSet(this BotClient? bot, string name)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.Name, name);
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<StickerSet>(MethodNames.GetStickerSet, stream);
		}
		/// <summary>Use this method to get a sticker set. On success, a StickerSet object is returned.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="name">Name of the sticker set.</param>
		/// <returns><see cref="StickerSet"/> object.</returns>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<StickerSet> GetStickerSetAsync(this BotClient? bot, string name, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.Name, name);
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<StickerSet>(MethodNames.GetStickerSet, stream, cancellationToken).ConfigureAwait(false);
		}
	}
}