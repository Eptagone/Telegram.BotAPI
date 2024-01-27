// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to unpin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="messageId">Identifier of a message to unpin. If not specified, the most recent pinned message (by sending date) will be unpinned.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool UnPinChatMessage(this ITelegramBotClient bot, long chatId, [Optional] int? messageId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		if (messageId != null)
		{
			json.WriteNumber(PropertyNames.MessageId, (int)messageId);
		}

		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<bool>(MethodNames.UnpinChatMessage, stream);
	}
	/// <summary>Use this method to unpin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="messageId">Identifier of a message to unpin. If not specified, the most recent pinned message (by sending date) will be unpinned.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool UnPinChatMessage(this ITelegramBotClient bot, string chatId, [Optional] int? messageId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		if (messageId != null)
		{
			json.WriteNumber(PropertyNames.MessageId, (int)messageId);
		}

		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<bool>(MethodNames.UnpinChatMessage, stream);
	}
	/// <summary>Use this method to unpin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="messageId">Identifier of a message to unpin. If not specified, the most recent pinned message (by sending date) will be unpinned.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> UnPinChatMessageAsync(this ITelegramBotClient bot, long chatId, [Optional] int? messageId, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		if (messageId != null)
		{
			json.WriteNumber(PropertyNames.MessageId, (int)messageId);
		}

		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.CallMethodAsync<bool>(MethodNames.UnpinChatMessage, stream, cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to unpin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="messageId">Identifier of a message to unpin. If not specified, the most recent pinned message (by sending date) will be unpinned.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> UnPinChatMessageAsync(this ITelegramBotClient bot, string chatId, [Optional] int? messageId, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		if (messageId != null)
		{
			json.WriteNumber(PropertyNames.MessageId, (int)messageId);
		}

		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.CallMethodAsync<bool>(MethodNames.UnpinChatMessage, stream, cancellationToken).ConfigureAwait(false);
	}
}