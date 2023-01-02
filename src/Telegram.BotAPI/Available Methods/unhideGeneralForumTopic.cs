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
		/// Use this method to unhide the 'General' topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns True on success.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool UnhideGeneralForumTopic(this BotClient? api, long chatId)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return api.RPC<bool>(MethodNames.UnhideGeneralForumTopic, stream);
		}

		/// <summary>
		/// Use this method to unhide the 'General' topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns True on success.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool UnhideGeneralForumTopic(this BotClient? api, string chatId)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return api.RPC<bool>(MethodNames.UnhideGeneralForumTopic, stream);
		}

		/// <summary>
		/// Use this method to unhide the 'General' topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns True on success.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> UnhideGeneralForumTopicAsync(this BotClient? api, long chatId, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await api.RPCA<bool>(MethodNames.UnhideGeneralForumTopic, stream, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to unhide the 'General' topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns True on success.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> UnhideGeneralForumTopicAsync(this BotClient? api, string chatId, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await api.RPCA<bool>(MethodNames.UnhideGeneralForumTopic, stream, cancellationToken).ConfigureAwait(false);
		}
	}
}
