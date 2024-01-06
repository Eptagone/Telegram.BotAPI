// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Stickers;

public static partial class StickersExtensions
{
	/// <summary>
	/// Use this method to delete a sticker set that was created by the bot. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client</param>
	/// <param name="name">Sticker set name</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool DeleteStickerSet(this ITelegramBotClient api, string name)
	{
		if (api == null)
		{
			throw new ArgumentNullException(nameof(api));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)));
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<bool>(MethodNames.DeleteStickerSet, stream);
	}

	/// <summary>
	/// Use this method to delete a sticker set that was created by the bot. Returns True on success.
	/// </summary>
	/// <param name="api">BotClient</param>
	/// <param name="name">Sticker set name</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> DeleteStickerSetAsync(this ITelegramBotClient api, string name, CancellationToken cancellationToken = default)
	{
		if (api == null)
		{
			throw new ArgumentNullException(nameof(api));
		}
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)));
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<bool>(MethodNames.DeleteStickerSet, stream, cancellationToken)
			.ConfigureAwait(false);
	}
}
