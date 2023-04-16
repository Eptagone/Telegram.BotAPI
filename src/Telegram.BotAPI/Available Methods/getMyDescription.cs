// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to get the current bot description for the given user language. Returns <see cref="BotDescription"/> on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static BotDescription GetMyDescription(this BotClient? bot, [Optional] string? languageCode)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		if (!string.IsNullOrEmpty(languageCode))
		{
			json.WriteString(PropertyNames.LanguageCode, languageCode);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.RPC<BotDescription>(MethodNames.GetMyDescription, stream);
	}

	/// <summary>
	/// Use this method to get the current bot description for the given user language. Returns <see cref="BotDescription"/> on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<BotDescription> GetMyDescriptionAsync(this BotClient? bot, [Optional] string? languageCode, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		if (!string.IsNullOrEmpty(languageCode))
		{
			json.WriteString(PropertyNames.LanguageCode, languageCode);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.RPCA<BotDescription>(MethodNames.GetMyDescription, stream, cancellationToken).ConfigureAwait(false);
	}
}
