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
		/// <summary>
		/// Use this method to get information about custom emoji stickers by their identifiers. Returns an Array of Sticker objects.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="customEmojiIds">List of custom emoji identifiers. At most 200 custom emoji identifiers can be specified.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Sticker[] GetCustomEmojiStickers(this BotClient? api, IEnumerable<string> customEmojiIds)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (customEmojiIds == null) { throw new ArgumentNullException(nameof(customEmojiIds)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteStartArray(PropertyNames.CustomEmojiIds);
			foreach (var id in customEmojiIds)
			{
				json.WriteStringValue(id);
			}
			json.WriteEndArray();
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return api.RPC<Sticker[]>(MethodNames.GetCustomEmojiStickers, stream);
		}

		/// <summary>
		/// Use this method to get information about custom emoji stickers by their identifiers. Returns an Array of Sticker objects.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="customEmojiIds">List of custom emoji identifiers. At most 200 custom emoji identifiers can be specified.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Sticker[]> GetCustomEmojiStickersAsync(this BotClient? api, IEnumerable<string> customEmojiIds, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (customEmojiIds == null) { throw new ArgumentNullException(nameof(customEmojiIds)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteStartArray(PropertyNames.CustomEmojiIds);
			foreach (var id in customEmojiIds)
			{
				json.WriteStringValue(id);
			}
			json.WriteEndArray();
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await api.RPCA<Sticker[]>(MethodNames.GetCustomEmojiStickers, stream, cancellationToken).ConfigureAwait(false);
		}
	}
}
