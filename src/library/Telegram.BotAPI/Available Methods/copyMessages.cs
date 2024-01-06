// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>Available Methods</summary>
public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to copy messages of any kind. If some of the specified messages can't be found or copied, they are skipped. Service messages, giveaway messages, giveaway winners messages, and invoice messages can't be copied. A quiz poll can be copied only if the value of the field correct_option_id is known to the bot. The method is analogous to the method forwardMessages, but the copied messages don't have a link to the original message. Album grouping is kept for copied messages. On success, an array of MessageId of the sent messages is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="removeCaption">Pass True to copy the messages without their captions.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static IEnumerable<MessageID> CopyMessages(this ITelegramBotClient client, long chatId, long fromChatId, IEnumerable<long> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, bool? removeCaption = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new CopyMessagesArgs(chatId, fromChatId, messageIds)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			RemoveCaption = removeCaption
		};
		return client.CallMethod<IEnumerable<MessageID>>(MethodNames.CopyMessages, args);
	}

	/// <summary>
	/// Use this method to copy messages of any kind. If some of the specified messages can't be found or copied, they are skipped. Service messages, giveaway messages, giveaway winners messages, and invoice messages can't be copied. A quiz poll can be copied only if the value of the field correct_option_id is known to the bot. The method is analogous to the method forwardMessages, but the copied messages don't have a link to the original message. Album grouping is kept for copied messages. On success, an array of MessageId of the sent messages is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="removeCaption">Pass True to copy the messages without their captions.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static IEnumerable<MessageID> CopyMessages(this ITelegramBotClient client, long chatId, string fromChatId, IEnumerable<long> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, bool? removeCaption = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new CopyMessagesArgs(chatId, fromChatId, messageIds)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			RemoveCaption = removeCaption
		};
		return client.CallMethod<IEnumerable<MessageID>>(MethodNames.CopyMessages, args);
	}

	/// <summary>
	/// Use this method to copy messages of any kind. If some of the specified messages can't be found or copied, they are skipped. Service messages, giveaway messages, giveaway winners messages, and invoice messages can't be copied. A quiz poll can be copied only if the value of the field correct_option_id is known to the bot. The method is analogous to the method forwardMessages, but the copied messages don't have a link to the original message. Album grouping is kept for copied messages. On success, an array of MessageId of the sent messages is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="removeCaption">Pass True to copy the messages without their captions.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static IEnumerable<MessageID> CopyMessages(this ITelegramBotClient client, string chatId, long fromChatId, IEnumerable<long> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, bool? removeCaption = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new CopyMessagesArgs(chatId, fromChatId, messageIds)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			RemoveCaption = removeCaption
		};
		return client.CallMethod<IEnumerable<MessageID>>(MethodNames.CopyMessages, args);
	}

	/// <summary>
	/// Use this method to copy messages of any kind. If some of the specified messages can't be found or copied, they are skipped. Service messages, giveaway messages, giveaway winners messages, and invoice messages can't be copied. A quiz poll can be copied only if the value of the field correct_option_id is known to the bot. The method is analogous to the method forwardMessages, but the copied messages don't have a link to the original message. Album grouping is kept for copied messages. On success, an array of MessageId of the sent messages is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="removeCaption">Pass True to copy the messages without their captions.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static IEnumerable<MessageID> CopyMessages(this ITelegramBotClient client, string chatId, string fromChatId, IEnumerable<long> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, bool? removeCaption = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new CopyMessagesArgs(chatId, fromChatId, messageIds)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			RemoveCaption = removeCaption
		};
		return client.CallMethod<IEnumerable<MessageID>>(MethodNames.CopyMessages, args);
	}

	/// <summary>
	/// Use this method to copy messages of any kind. If some of the specified messages can't be found or copied, they are skipped. Service messages, giveaway messages, giveaway winners messages, and invoice messages can't be copied. A quiz poll can be copied only if the value of the field correct_option_id is known to the bot. The method is analogous to the method forwardMessages, but the copied messages don't have a link to the original message. Album grouping is kept for copied messages. On success, an array of MessageId of the sent messages is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="removeCaption">Pass True to copy the messages without their captions.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<MessageID> CopyMessagesAsync(this ITelegramBotClient client, long chatId, long fromChatId, IEnumerable<long> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, bool? removeCaption = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new CopyMessagesArgs(chatId, fromChatId, messageIds)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			RemoveCaption = removeCaption
		};
		return await client.CallMethodAsync<MessageID>(MethodNames.CopyMessages, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to copy messages of any kind. If some of the specified messages can't be found or copied, they are skipped. Service messages, giveaway messages, giveaway winners messages, and invoice messages can't be copied. A quiz poll can be copied only if the value of the field correct_option_id is known to the bot. The method is analogous to the method forwardMessages, but the copied messages don't have a link to the original message. Album grouping is kept for copied messages. On success, an array of MessageId of the sent messages is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="removeCaption">Pass True to copy the messages without their captions.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<MessageID> CopyMessagesAsync(this ITelegramBotClient client, long chatId, string fromChatId, IEnumerable<long> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, bool? removeCaption = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new CopyMessagesArgs(chatId, fromChatId, messageIds)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			RemoveCaption = removeCaption
		};
		return await client.CallMethodAsync<MessageID>(MethodNames.CopyMessages, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to copy messages of any kind. If some of the specified messages can't be found or copied, they are skipped. Service messages, giveaway messages, giveaway winners messages, and invoice messages can't be copied. A quiz poll can be copied only if the value of the field correct_option_id is known to the bot. The method is analogous to the method forwardMessages, but the copied messages don't have a link to the original message. Album grouping is kept for copied messages. On success, an array of MessageId of the sent messages is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="removeCaption">Pass True to copy the messages without their captions.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<MessageID> CopyMessagesAsync(this ITelegramBotClient client, string chatId, long fromChatId, IEnumerable<long> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, bool? removeCaption = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new CopyMessagesArgs(chatId, fromChatId, messageIds)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			RemoveCaption = removeCaption
		};
		return await client.CallMethodAsync<MessageID>(MethodNames.CopyMessages, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to copy messages of any kind. If some of the specified messages can't be found or copied, they are skipped. Service messages, giveaway messages, giveaway winners messages, and invoice messages can't be copied. A quiz poll can be copied only if the value of the field correct_option_id is known to the bot. The method is analogous to the method forwardMessages, but the copied messages don't have a link to the original message. Album grouping is kept for copied messages. On success, an array of MessageId of the sent messages is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends the messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="removeCaption">Pass True to copy the messages without their captions.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<MessageID> CopyMessagesAsync(this ITelegramBotClient client, string chatId, string fromChatId, IEnumerable<long> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, bool? removeCaption = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new CopyMessagesArgs(chatId, fromChatId, messageIds)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			RemoveCaption = removeCaption
		};
		return await client.CallMethodAsync<MessageID>(MethodNames.CopyMessages, args, cancellationToken).ConfigureAwait(false);
	}


}
