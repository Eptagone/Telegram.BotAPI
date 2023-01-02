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
		/// <summary>Use this method to delete a sticker from a set created by the bot. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="sticker">File identifier of the sticker.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool DeleteStickerFromSet(this BotClient? bot, string sticker)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.Sticker, sticker);
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<bool>(MethodNames.DeleteStickerFromSet, stream);
		}
		/// <summary>Use this method to delete a sticker from a set created by the bot. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="sticker">File identifier of the sticker.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> DeleteStickerFromSetAsync(this BotClient? bot, string sticker, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.Sticker, sticker);
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<bool>(MethodNames.DeleteStickerFromSet, stream, cancellationToken).ConfigureAwait(false);
		}
	}
}