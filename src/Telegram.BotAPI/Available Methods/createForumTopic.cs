// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>
		/// Use this method to create a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns information about the created topic as a ForumTopic object.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="name">Topic name, 1-128 characters.</param>
		/// <param name="iconColor">Color of the topic icon in RGB format. Currently, must be one of 0x6FB9F0, 0xFFD67E, 0xCB86DB, 0x8EEE98, 0xFF93B2, or 0xFB6F5F.</param>
		/// <param name="iconCustomEmojiId">Unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static ForumTopic CreateForumTopic(this BotClient? api, long chatId, string name, [Optional] int? iconColor, [Optional] string iconCustomEmojiId)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteString(PropertyNames.Name, name);
			if (iconColor is not null)
			{
				json.WriteNumber(PropertyNames.IconColor, (int)iconColor);
			}
			if (iconCustomEmojiId is not null)
			{
				json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
			}
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return api.RPC<ForumTopic>(MethodNames.CreateForumTopic, stream);
		}

		/// <summary>
		/// Use this method to create a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns information about the created topic as a ForumTopic object.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="name">Topic name, 1-128 characters.</param>
		/// <param name="iconColor">Color of the topic icon in RGB format. Currently, must be one of 0x6FB9F0, 0xFFD67E, 0xCB86DB, 0x8EEE98, 0xFF93B2, or 0xFB6F5F.</param>
		/// <param name="iconCustomEmojiId">Unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static ForumTopic CreateForumTopic(this BotClient? api, string chatId, string name, [Optional] int? iconColor, [Optional] string iconCustomEmojiId)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteString(PropertyNames.Name, name);
			if (iconColor is not null)
			{
				json.WriteNumber(PropertyNames.IconColor, (int)iconColor);
			}
			if (iconCustomEmojiId is not null)
			{
				json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
			}
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return api.RPC<ForumTopic>(MethodNames.CreateForumTopic, stream);
		}

		/// <summary>
		/// Use this method to create a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns information about the created topic as a ForumTopic object.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="name">Topic name, 1-128 characters.</param>
		/// <param name="iconColor">Color of the topic icon in RGB format. Currently, must be one of 0x6FB9F0, 0xFFD67E, 0xCB86DB, 0x8EEE98, 0xFF93B2, or 0xFB6F5F.</param>
		/// <param name="iconCustomEmojiId">Unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<ForumTopic> CreateForumTopicAsync(this BotClient? api, long chatId, string name, [Optional] int? iconColor, [Optional] string iconCustomEmojiId, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteString(PropertyNames.Name, name);
			if (iconColor is not null)
			{
				json.WriteNumber(PropertyNames.IconColor, (int)iconColor);
			}
			if (iconCustomEmojiId is not null)
			{
				json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
			}
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await api.RPCA<ForumTopic>(MethodNames.CreateForumTopic, stream, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to create a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns information about the created topic as a ForumTopic object.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="name">Topic name, 1-128 characters.</param>
		/// <param name="iconColor">Color of the topic icon in RGB format. Currently, must be one of 0x6FB9F0, 0xFFD67E, 0xCB86DB, 0x8EEE98, 0xFF93B2, or 0xFB6F5F.</param>
		/// <param name="iconCustomEmojiId">Unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<ForumTopic> CreateForumTopicAsync(this BotClient? api, string chatId, string name, [Optional] int? iconColor, [Optional] string iconCustomEmojiId, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteString(PropertyNames.Name, name);
			if (iconColor is not null)
			{
				json.WriteNumber(PropertyNames.IconColor, (int)iconColor);
			}
			if (iconCustomEmojiId is not null)
			{
				json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
			}
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await api.RPCA<ForumTopic>(MethodNames.CreateForumTopic, stream, cancellationToken).ConfigureAwait(false);
		}
	}

}
