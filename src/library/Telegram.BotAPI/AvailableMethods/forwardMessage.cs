// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>Available Methods</summary>
public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to forward messages of any kind. Service messages can't be forwarded. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message ForwardMessage(this ITelegramBotClient api, long chatId, long fromChatId, int messageId, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.FromChatId, fromChatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		if (messageThreadId is not null)
		{
			json.WriteNumber(PropertyNames.MessageThreadId, (int)messageThreadId);
		}
		if (disableNotification is not null)
		{
			json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
		}
		if (protectContent is not null)
		{
			json.WriteBoolean(PropertyNames.ProtectContent, (bool)protectContent);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<Message>(MethodNames.ForwardMessage, stream);
	}

	/// <summary>
	/// Use this method to forward messages of any kind. Service messages can't be forwarded. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message ForwardMessage(this ITelegramBotClient api, long chatId, string fromChatId, int messageId, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteString(PropertyNames.FromChatId, fromChatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		if (messageThreadId is not null)
		{
			json.WriteNumber(PropertyNames.MessageThreadId, (int)messageThreadId);
		}
		if (disableNotification is not null)
		{
			json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
		}
		if (protectContent is not null)
		{
			json.WriteBoolean(PropertyNames.ProtectContent, (bool)protectContent);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<Message>(MethodNames.ForwardMessage, stream);
	}

	/// <summary>
	/// Use this method to forward messages of any kind. Service messages can't be forwarded. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message ForwardMessage(this ITelegramBotClient api, string chatId, long fromChatId, int messageId, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.FromChatId, fromChatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		if (messageThreadId is not null)
		{
			json.WriteNumber(PropertyNames.MessageThreadId, (int)messageThreadId);
		}
		if (disableNotification is not null)
		{
			json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
		}
		if (protectContent is not null)
		{
			json.WriteBoolean(PropertyNames.ProtectContent, (bool)protectContent);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<Message>(MethodNames.ForwardMessage, stream);
	}

	/// <summary>
	/// Use this method to forward messages of any kind. Service messages can't be forwarded. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message ForwardMessage(this ITelegramBotClient api, string chatId, string fromChatId, int messageId, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteString(PropertyNames.FromChatId, fromChatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		if (messageThreadId is not null)
		{
			json.WriteNumber(PropertyNames.MessageThreadId, (int)messageThreadId);
		}
		if (disableNotification is not null)
		{
			json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
		}
		if (protectContent is not null)
		{
			json.WriteBoolean(PropertyNames.ProtectContent, (bool)protectContent);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<Message>(MethodNames.ForwardMessage, stream);
	}

	/// <summary>
	/// Use this method to forward messages of any kind. Service messages can't be forwarded. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> ForwardMessageAsync(this ITelegramBotClient api, long chatId, long fromChatId, int messageId, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.FromChatId, fromChatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		if (messageThreadId is not null)
		{
			json.WriteNumber(PropertyNames.MessageThreadId, (int)messageThreadId);
		}
		if (disableNotification is not null)
		{
			json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
		}
		if (protectContent is not null)
		{
			json.WriteBoolean(PropertyNames.ProtectContent, (bool)protectContent);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<Message>(MethodNames.ForwardMessage, stream, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to forward messages of any kind. Service messages can't be forwarded. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> ForwardMessageAsync(this ITelegramBotClient api, long chatId, string fromChatId, int messageId, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteString(PropertyNames.FromChatId, fromChatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		if (messageThreadId is not null)
		{
			json.WriteNumber(PropertyNames.MessageThreadId, (int)messageThreadId);
		}
		if (disableNotification is not null)
		{
			json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
		}
		if (protectContent is not null)
		{
			json.WriteBoolean(PropertyNames.ProtectContent, (bool)protectContent);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<Message>(MethodNames.ForwardMessage, stream, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to forward messages of any kind. Service messages can't be forwarded. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> ForwardMessageAsync(this ITelegramBotClient api, string chatId, long fromChatId, int messageId, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.FromChatId, fromChatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		if (messageThreadId is not null)
		{
			json.WriteNumber(PropertyNames.MessageThreadId, (int)messageThreadId);
		}
		if (disableNotification is not null)
		{
			json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
		}
		if (protectContent is not null)
		{
			json.WriteBoolean(PropertyNames.ProtectContent, (bool)protectContent);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<Message>(MethodNames.ForwardMessage, stream, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to forward messages of any kind. Service messages can't be forwarded. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> ForwardMessageAsync(this ITelegramBotClient api, string chatId, string fromChatId, int messageId, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteString(PropertyNames.FromChatId, fromChatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		if (messageThreadId is not null)
		{
			json.WriteNumber(PropertyNames.MessageThreadId, (int)messageThreadId);
		}
		if (disableNotification is not null)
		{
			json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
		}
		if (protectContent is not null)
		{
			json.WriteBoolean(PropertyNames.ProtectContent, (bool)protectContent);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<Message>(MethodNames.ForwardMessage, stream, cancellationToken).ConfigureAwait(false);
	}
}
