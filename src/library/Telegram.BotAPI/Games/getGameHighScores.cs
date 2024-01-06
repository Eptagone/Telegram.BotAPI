// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Games;

/// <summary>Extension methods for Games</summary>
public static partial class GamesExtensions
{
	/// <summary>Use this method to get data for high score tables. Will return the score of the specified user and several of his neighbors in a game. On success, returns an Array of GameHighScore objects.<para>This method will currently return scores for the target user, plus two of his closest neighbors on each side. Will also return the top three users if the user and his neighbors are not among them. Please note that this behavior is subject to change.</para></summary>
	///<param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static GameHighScore[] GetGameScore(this ITelegramBotClient bot, GetGameScoreArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.CallMethod<GameHighScore[]>(MethodNames.GetGameHighScores, args);
	}
	/// <summary>Use this method to get data for high score tables. Will return the score of the specified user and several of his neighbors in a game. On success, returns an Array of GameHighScore objects.<para>This method will currently return scores for the target user, plus two of his closest neighbors on each side. Will also return the top three users if the user and his neighbors are not among them. Please note that this behavior is subject to change.</para></summary>
	///<param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<GameHighScore[]> GetGameScoreAsync(this ITelegramBotClient bot, GetGameScoreArgs args, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<GameHighScore[]>(MethodNames.GetGameHighScores, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to get data for high score tables. Will return the score of the specified user and several of his neighbors in a game. On success, returns an Array of GameHighScore objects.<para>This method will currently return scores for the target user, plus two of his closest neighbors on each side. Will also return the top three users if the user and his neighbors are not among them. Please note that this behavior is subject to change.</para></summary>
	///<param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static T GetGameScore<T>(this ITelegramBotClient bot, GetGameScoreArgs args)
		where T : IEnumerable<GameHighScore>
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.CallMethod<T>(MethodNames.GetGameHighScores, args);
	}
	/// <summary>Use this method to get data for high score tables. Will return the score of the specified user and several of his neighbors in a game. On success, returns an Array of GameHighScore objects.<para>This method will currently return scores for the target user, plus two of his closest neighbors on each side. Will also return the top three users if the user and his neighbors are not among them. Please note that this behavior is subject to change.</para></summary>
	///<param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<T> GetGameScoreAsync<T>(this ITelegramBotClient bot, GetGameScoreArgs args, CancellationToken cancellationToken = default)
		where T : IEnumerable<GameHighScore>
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<T>(MethodNames.GetGameHighScores, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}
}
