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
	/// Use this method to edit name and icon of a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights, unless it is the creator of the topic. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread of the forum topic.</param>
	/// <param name="name">New topic name, 0-128 characters. If not specified or empty, the current name of the topic will be kept.</param>
	/// <param name="iconCustomEmojiId">New unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers. Pass an empty string to remove the icon. If not specified, the current icon will be kept.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool EditForumTopic(this ITelegramBotClient api, long chatId, int messageThreadId, [Optional] string? name, [Optional] string? iconCustomEmojiId)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageThreadId, messageThreadId);
		if (name is not null)
		{
			json.WriteString(PropertyNames.Name, name);
		}
		if (iconCustomEmojiId is not null)
		{
			json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<bool>(MethodNames.EditForumTopic, stream);
	}

	/// <summary>
	/// Use this method to edit name and icon of a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights, unless it is the creator of the topic. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread of the forum topic.</param>
	/// <param name="name">New topic name, 0-128 characters. If not specified or empty, the current name of the topic will be kept.</param>
	/// <param name="iconCustomEmojiId">New unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers. Pass an empty string to remove the icon. If not specified, the current icon will be kept.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool EditForumTopic(this ITelegramBotClient api, string chatId, int messageThreadId, [Optional] string? name, [Optional] string? iconCustomEmojiId)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageThreadId, messageThreadId);
		if (name is not null)
		{
			json.WriteString(PropertyNames.Name, name);
		}
		if (iconCustomEmojiId is not null)
		{
			json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<bool>(MethodNames.EditForumTopic, stream);
	}

	/// <summary>
	/// Use this method to edit name and icon of a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights, unless it is the creator of the topic. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread of the forum topic.</param>
	/// <param name="name">New topic name, 0-128 characters. If not specified or empty, the current name of the topic will be kept.</param>
	/// <param name="iconCustomEmojiId">New unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers. Pass an empty string to remove the icon. If not specified, the current icon will be kept.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> EditForumTopicAsync(this ITelegramBotClient api, long chatId, int messageThreadId, [Optional] string? name, [Optional] string? iconCustomEmojiId, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageThreadId, messageThreadId);
		if (name is not null)
		{
			json.WriteString(PropertyNames.Name, name);
		}
		if (iconCustomEmojiId is not null)
		{
			json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<bool>(MethodNames.EditForumTopic, stream, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to edit name and icon of a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights, unless it is the creator of the topic. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread of the forum topic.</param>
	/// <param name="name">New topic name, 0-128 characters. If not specified or empty, the current name of the topic will be kept.</param>
	/// <param name="iconCustomEmojiId">New unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers. Pass an empty string to remove the icon. If not specified, the current icon will be kept.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> EditForumTopicAsync(this ITelegramBotClient api, string chatId, int messageThreadId, [Optional] string? name, [Optional] string? iconCustomEmojiId, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageThreadId, messageThreadId);
		if (name is not null)
		{
			json.WriteString(PropertyNames.Name, name);
		}
		if (iconCustomEmojiId is not null)
		{
			json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<bool>(MethodNames.EditForumTopic, stream, cancellationToken).ConfigureAwait(false);
	}
}
