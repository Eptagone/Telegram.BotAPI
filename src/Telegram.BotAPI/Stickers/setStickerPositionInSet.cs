// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Stickers
{
	/// <summary>Stickers</summary>
	public static partial class StickersExtensions
	{
		/// <summary>Use this method to move a sticker in a set created by the bot to a specific position . Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="sticker">File identifier of the sticker.</param>
		/// <param name="position">New sticker position in the set, zero-based.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool SetStickerPositionInSet(this BotClient? bot, string sticker, int position)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.Sticker, sticker);
			json.WriteNumber(PropertyNames.Position, position);
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<bool>(MethodNames.SetStickerPositionInSet, stream);
		}
		/// <summary>Use this method to move a sticker in a set created by the bot to a specific position . Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="sticker">File identifier of the sticker.</param>
		/// <param name="position">New sticker position in the set, zero-based.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> SetStickerPositionInSetAsync(this BotClient? bot, string sticker, int position, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.Sticker, sticker);
			json.WriteNumber(PropertyNames.Position, position);
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<bool>(MethodNames.SetStickerPositionInSet, stream, cancellationToken).ConfigureAwait(false);
		}
	}
}
