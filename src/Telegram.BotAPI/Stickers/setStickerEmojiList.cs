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
		/// <summary>
		/// Use this method to change the list of emoji assigned to a regular or custom emoji sticker. The sticker must belong to a sticker set created by the bot. Returns True on success.
		/// </summary>
		/// <param name="api">The bot client</param>
		/// <param name="sticker">File identifier of the sticker</param>
		/// <param name="emojiList">A list of 1-20 emoji associated with the sticker</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		/// <returns>True</returns>
		public static bool SetStickerEmojiList<T>(this BotClient api, string sticker, T emojiList)
			where T : IEnumerable<string>
		{
			if (api == null)
			{
				throw new ArgumentNullException(nameof(api));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.Sticker, sticker ?? throw new ArgumentNullException(nameof(sticker)));
			json.WriteStartArray(PropertyNames.EmojiList);
			foreach (var emoji in emojiList)
			{
				json.WriteStringValue(emoji ?? throw new ArgumentNullException(nameof(emojiList), "Emojis cannot be null or empty"));
			}
			json.WriteEndArray();
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return api.RPC<bool>(MethodNames.SetStickerEmojiList, stream);
		}

		/// <summary>
		/// Use this method to change the list of emoji assigned to a regular or custom emoji sticker. The sticker must belong to a sticker set created by the bot. Returns True on success.
		/// </summary>
		/// <param name="api">BotClient</param>
		/// <param name="sticker">File identifier of the sticker</param>
		/// <param name="emojiList">A list of 1-20 emoji associated with the sticker</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		/// <returns>True</returns>
		public static async Task<bool> SetStickerEmojiListAsync<T>(this BotClient api, string sticker, T emojiList, [Optional] CancellationToken cancellationToken)
			where T : IEnumerable<string>
		{
			if (api == null)
			{
				throw new ArgumentNullException(nameof(api));
			}
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.Sticker, sticker ?? throw new ArgumentNullException(nameof(sticker)));
			json.WriteStartArray(PropertyNames.EmojiList);
			foreach (var emoji in emojiList)
			{
				json.WriteStringValue(emoji ?? throw new ArgumentNullException(nameof(emojiList), "Emojis cannot be null or empty"));
			}
			json.WriteEndArray();
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await api.RPCA<bool>(MethodNames.SetStickerEmojiList, stream, cancellationToken)
				.ConfigureAwait(false);
		}
	}
}
