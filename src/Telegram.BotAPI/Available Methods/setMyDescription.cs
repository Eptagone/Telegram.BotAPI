// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>
		/// Use this method to change the bot's description, which is shown in the chat with the bot if the chat is empty. Returns True on success.
		/// </summary>
		/// <param name="bot">BotClient</param>
		/// <param name="description">New bot description; 0-512 characters. Pass an empty string to remove the dedicated description for the given language.</param>
		/// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the description will be applied to all users for whose language there is no dedicated description.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool SetMyDescription(this BotClient? bot, [Optional] string? description, [Optional] string? languageCode)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			if (!string.IsNullOrEmpty(description))
			{
				json.WriteString(PropertyNames.Description, description);
			}
			if (!string.IsNullOrEmpty(languageCode))
			{
				json.WriteString(PropertyNames.LanguageCode, languageCode);
			}
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<bool>(MethodNames.SetMyDescription, stream);
		}

		/// <summary>
		/// Use this method to change the bot's description, which is shown in the chat with the bot if the chat is empty. Returns True on success.
		/// </summary>
		/// <param name="bot">BotClient</param>
		/// <param name="description">New bot description; 0-512 characters. Pass an empty string to remove the dedicated description for the given language.</param>
		/// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the description will be applied to all users for whose language there is no dedicated description.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> SetMyDescriptionAsync(this BotClient? bot, [Optional] string? description, [Optional] string? languageCode, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			if (!string.IsNullOrEmpty(description))
			{
				json.WriteString(PropertyNames.Description, description);
			}
			if (!string.IsNullOrEmpty(languageCode))
			{
				json.WriteString(PropertyNames.LanguageCode, languageCode);
			}
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<bool>(MethodNames.SetMyDescription, stream, cancellationToken).ConfigureAwait(false);
		}
	}
}
