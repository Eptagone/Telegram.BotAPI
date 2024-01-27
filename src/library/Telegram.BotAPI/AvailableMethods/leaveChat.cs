// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method for your bot to leave a group, supergroup or channel. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool LeaveChat(this ITelegramBotClient bot, long chatId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<bool>(MethodNames.LeaveChat, stream);
	}
	/// <summary>Use this method for your bot to leave a group, supergroup or channel. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool LeaveChat(this ITelegramBotClient bot, string chatId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<bool>(MethodNames.LeaveChat, stream);
	}
	/// <summary>Use this method for your bot to leave a group, supergroup or channel. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> LeaveChatAsync(this ITelegramBotClient bot, long chatId, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.CallMethodAsync<bool>(MethodNames.LeaveChat, stream, cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method for your bot to leave a group, supergroup or channel. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> LeaveChatAsync(this ITelegramBotClient bot, string chatId, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.CallMethodAsync<bool>(MethodNames.LeaveChat, stream, cancellationToken).ConfigureAwait(false);
	}
}