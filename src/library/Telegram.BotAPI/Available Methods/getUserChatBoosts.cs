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
	/// Use this method to get the list of boosts added to a chat by a user. Requires administrator rights in the chat. Returns a UserChatBoosts object.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the chat or username of the channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static UserChatBoosts GetUserChatBoosts(this ITelegramBotClient client, long chatId, int userId)
	{
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return client.CallMethod<UserChatBoosts>(MethodNames.GetUserChatBoosts, stream);
	}

	/// <summary>
	/// Use this method to get the list of boosts added to a chat by a user. Requires administrator rights in the chat. Returns a UserChatBoosts object.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the chat or username of the channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static UserChatBoosts GetUserChatBoosts(this ITelegramBotClient client, string chatId, int userId)
	{
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return client.CallMethod<UserChatBoosts>(MethodNames.GetUserChatBoosts, stream);
	}

	/// <summary>
	/// Use this method to get the list of boosts added to a chat by a user. Requires administrator rights in the chat. Returns a UserChatBoosts object.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the chat or username of the channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<UserChatBoosts> GetUserChatBoostsAsync(this ITelegramBotClient client, long chatId, int userId, CancellationToken cancellationToken = default)
	{
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await client.CallMethodAsync<UserChatBoosts>(MethodNames.GetUserChatBoosts, stream, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to get the list of boosts added to a chat by a user. Requires administrator rights in the chat. Returns a UserChatBoosts object.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the chat or username of the channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<UserChatBoosts> GetUserChatBoostsAsync(this ITelegramBotClient client, string chatId, int userId, CancellationToken cancellationToken = default)
	{
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await client.CallMethodAsync<UserChatBoosts>(MethodNames.GetUserChatBoosts, stream, cancellationToken).ConfigureAwait(false);
	}
}
