// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to change the bot's name. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="name">New bot name; 0-64 characters. Pass an empty string to remove the dedicated name for the given language.</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the name will be shown to all users for whose language there is no dedicated name.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool SetMyName(this ITelegramBotClient api, [Optional] string? name, [Optional] string? languageCode)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		if (name is not null)
		{
			json.WriteString(PropertyNames.Name, name);
		}
		if (languageCode is not null)
		{
			json.WriteString(PropertyNames.LanguageCode, languageCode);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<bool>(MethodNames.SetMyName, stream);
	}

	/// <summary>
	/// Use this method to change the bot's name. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="name">New bot name; 0-64 characters. Pass an empty string to remove the dedicated name for the given language.</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the name will be shown to all users for whose language there is no dedicated name.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> SetMyNameAsync(this ITelegramBotClient api, [Optional] string? name, [Optional] string? languageCode, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		if (name is not null)
		{
			json.WriteString(PropertyNames.Name, name);
		}
		if (languageCode is not null)
		{
			json.WriteString(PropertyNames.LanguageCode, languageCode);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<bool>(MethodNames.SetMyName, stream, cancellationToken).ConfigureAwait(false);
	}
}
