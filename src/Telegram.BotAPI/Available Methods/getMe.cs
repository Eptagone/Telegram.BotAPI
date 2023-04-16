// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>A simple method for testing your bot's auth token. Returns basic information about the bot in form of a User object.</summary>
	/// <param name="bot">Bot Client</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>User Object.</returns>
	public static User GetMe(this BotClient? bot)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.RPC<User>(MethodNames.GetMe);
	}
	/// <summary>A simple method for testing your bot's auth token. Returns basic information about the bot in form of a User object.</summary>
	/// <param name="bot">Bot Client</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>User Object.</returns>
	public static async Task<User> GetMeAsync(this BotClient? bot, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return await bot.RPCA<User>(MethodNames.GetMe, cancellationToken).ConfigureAwait(false);
	}
}