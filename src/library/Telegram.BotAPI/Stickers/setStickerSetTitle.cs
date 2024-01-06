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
	/// Use this method to set the title of a created sticker set. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client</param>
	/// <param name="name">Sticker set name</param>
	/// <param name="title">Sticker set title, 1-64 characters</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetStickerSetTitle(this ITelegramBotClient api, string name, string title)
	{
		if (api == null)
		{
			throw new ArgumentNullException(nameof(api));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)));
		json.WriteString(PropertyNames.Title, title ?? throw new ArgumentNullException(nameof(title)));
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<bool>(MethodNames.SetStickerSetTitle, stream);
	}

	/// <summary>
	/// Use this method to set the title of a created sticker set. Returns True on success.
	/// </summary>
	/// <param name="api">BotClient</param>
	/// <param name="name">Sticker set name</param>
	/// <param name="title">Sticker set title, 1-64 characters</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> SetStickerSetTitleAsync(this ITelegramBotClient api, string name, string title, CancellationToken cancellationToken = default)
	{
		if (api == null)
		{
			throw new ArgumentNullException(nameof(api));
		}
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)));
		json.WriteString(PropertyNames.Title, title ?? throw new ArgumentNullException(nameof(title)));
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<bool>(MethodNames.SetStickerSetTitle, stream, cancellationToken)
			.ConfigureAwait(false);
	}
}
