// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Games;

public static partial class GamesExtensions
{
	/// <summary>Use this method to set the score of the specified user in a game.</summary>
	///<param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, returns the edited Message, otherwise returns True. Returns an error, if the new score is not greater than the user's current score in the chat and force is False.</returns>
	public static Message SetGameScore(this ITelegramBotClient bot, SetGameScoreArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		return bot.CallMethod<Message>(MethodNames.SetGameScore, args);
	}
	/// <summary>Use this method to set the score of the specified user in a game.</summary>
	///<param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, returns the edited Message, otherwise returns True. Returns an error, if the new score is not greater than the user's current score in the chat and force is False.</returns>
	public static async Task<Message> SetGameScoreAsync(this ITelegramBotClient bot, SetGameScoreArgs args, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		return await bot.CallMethodAsync<Message>(MethodNames.SetGameScore, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to set the score of the specified user in a game.</summary>
	///<param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, returns the edited Message, otherwise returns True. Returns an error, if the new score is not greater than the user's current score in the chat and force is False.</returns>
	public static T SetGameScore<T>(this ITelegramBotClient bot, SetGameScoreArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool) && typeof(T) != typeof(JObject) && typeof(T) != typeof(JsonDocument))
		{
			throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return bot.CallMethod<T>(MethodNames.SetGameScore, args);
	}
	/// <summary>Use this method to set the score of the specified user in a game.</summary>
	///<param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, returns the edited Message, otherwise returns True. Returns an error, if the new score is not greater than the user's current score in the chat and force is False.</returns>
	public static async Task<T> SetGameScoreAsync<T>(this ITelegramBotClient bot, SetGameScoreArgs args, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool) && typeof(T) != typeof(JObject) && typeof(T) != typeof(JsonDocument))
		{
			throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return await bot.CallMethodAsync<T>(MethodNames.SetGameScore, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}
}
