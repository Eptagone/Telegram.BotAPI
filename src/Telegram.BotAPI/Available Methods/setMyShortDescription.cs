// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to change the bot's short description, which is shown on the bot's profile page and is sent together with the link when users share the bot. Returns True on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="shortDescription">New short description for the bot; 0-120 characters. Pass an empty string to remove the dedicated short description for the given language.</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the short description will be applied to all users for whose language there is no dedicated short description.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool SetMyShortDescription(this BotClient? bot, [Optional] string? shortDescription, [Optional] string? languageCode)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		if (!string.IsNullOrEmpty(shortDescription))
		{
			json.WriteString(PropertyNames.ShortDescription, shortDescription);
		}
		if (!string.IsNullOrEmpty(languageCode))
		{
			json.WriteString(PropertyNames.LanguageCode, languageCode);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.RPC<bool>(MethodNames.SetMyShortDescription, stream);
	}

	/// <summary>
	/// Use this method to change the bot's short description, which is shown on the bot's profile page and is sent together with the link when users share the bot. Returns True on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="shortDescription">New short description for the bot; 0-120 characters. Pass an empty string to remove the dedicated short description for the given language.</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the short description will be applied to all users for whose language there is no dedicated short description.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> SetMyShortDescriptionAsync(this BotClient? bot, [Optional] string? shortDescription, [Optional] string? languageCode, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		if (!string.IsNullOrEmpty(shortDescription))
		{
			json.WriteString(PropertyNames.ShortDescription, shortDescription);
		}
		if (!string.IsNullOrEmpty(languageCode))
		{
			json.WriteString(PropertyNames.LanguageCode, languageCode);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.RPCA<bool>(MethodNames.SetMyShortDescription, stream, cancellationToken).ConfigureAwait(false);
	}
}
