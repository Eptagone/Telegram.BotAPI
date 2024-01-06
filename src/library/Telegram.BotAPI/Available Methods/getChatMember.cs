// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to get information about a member of a chat. Returns a ChatMember object on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="ChatMember"/></returns>
	public static ChatMember GetChatMember(this ITelegramBotClient bot, string chatId, long userId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<ChatMember>(MethodNames.GetChatMember, stream);
	}
	/// <summary>Use this method to get information about a member of a chat. Returns a ChatMember object on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="ChatMember"/></returns>
	public static ChatMember GetChatMember(this ITelegramBotClient bot, long chatId, long userId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<ChatMember>(MethodNames.GetChatMember, stream);
	}
	/// <summary>Use this method to get information about a member of a chat. Returns a ChatMember object on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="ChatMember"/></returns>
	public static async Task<ChatMember> GetChatMemberAsync(this ITelegramBotClient bot, long chatId, long userId, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.CallMethodAsync<ChatMember>(MethodNames.GetChatMember, stream, cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to get information about a member of a chat. Returns a ChatMember object on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="ChatMember"/></returns>
	public static async Task<ChatMember> GetChatMemberAsync(this ITelegramBotClient bot, string chatId, long userId, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.CallMethodAsync<ChatMember>(MethodNames.GetChatMember, stream, cancellationToken).ConfigureAwait(false);
	}
}