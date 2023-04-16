// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.UpdatingMessages;

public static partial class UpdatingMessagesExtensions
{
	/// <summary>Use this method to delete a message, including service messages, with the following limitations: <br/>
	/// - A message can only be deleted if it was sent less than 48 hours ago.<br/>
	/// - Bots can delete outgoing messages in private chats, groups, and supergroups.<br/>
	/// - Bots can delete incoming messages in private chats.<br/>
	/// - Bots granted can_post_messages permissions can delete outgoing messages in channels.<br/>
	/// - If the bot is an administrator of a group, it can delete any message there.<br/>
	/// - If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there.<br/>
	/// Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the message to delete.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool DeleteMessage(this BotClient? bot, long chatId, int messageId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.RPC<bool>(MethodNames.DeleteMessage, stream);
	}
	/// <summary>Use this method to delete a message, including service messages, with the following limitations: <br/>
	/// - A message can only be deleted if it was sent less than 48 hours ago.<br/>
	/// - Bots can delete outgoing messages in private chats, groups, and supergroups.<br/>
	/// - Bots can delete incoming messages in private chats.<br/>
	/// - Bots granted can_post_messages permissions can delete outgoing messages in channels.<br/>
	/// - If the bot is an administrator of a group, it can delete any message there.<br/>
	/// - If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there.<br/>
	/// Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the message to delete.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool DeleteMessage(this BotClient? bot, string chatId, int messageId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.RPC<bool>(MethodNames.DeleteMessage, stream);
	}
	/// <summary>Use this method to delete a message, including service messages, with the following limitations: <br/>
	/// - A message can only be deleted if it was sent less than 48 hours ago.<br/>
	/// - Bots can delete outgoing messages in private chats, groups, and supergroups.<br/>
	/// - Bots can delete incoming messages in private chats.<br/>
	/// - Bots granted can_post_messages permissions can delete outgoing messages in channels.<br/>
	/// - If the bot is an administrator of a group, it can delete any message there.<br/>
	/// - If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there.<br/>
	/// Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the message to delete.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> DeleteMessageAsync(this BotClient? bot, long chatId, int messageId, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.RPCA<bool>(MethodNames.DeleteMessage, stream, cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to delete a message, including service messages, with the following limitations: <br/>
	/// - A message can only be deleted if it was sent less than 48 hours ago.<br/>
	/// - Bots can delete outgoing messages in private chats, groups, and supergroups.<br/>
	/// - Bots can delete incoming messages in private chats.<br/>
	/// - Bots granted can_post_messages permissions can delete outgoing messages in channels.<br/>
	/// - If the bot is an administrator of a group, it can delete any message there.<br/>
	/// - If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there.<br/>
	/// Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the message to delete.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> DeleteMessageAsync(this BotClient? bot, string chatId, int messageId, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.RPCA<bool>(MethodNames.DeleteMessage, stream, cancellationToken).ConfigureAwait(false);
	}
}
