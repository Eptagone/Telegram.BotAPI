// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to log out from the cloud Bot API server before launching the bot locally. You must log out the bot before running it locally, otherwise there is no guarantee that the bot will receive updates. After a successful call, you will not be able to log in again using the same token for 10 minutes. Returns True on success. Requires no parameters.</summary>
	/// <param name="bot">Bot Client</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool LogOut(this ITelegramBotClient bot)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.CallMethod<bool>(MethodNames.LogOut);
	}
	/// <summary>Use this method to log out from the cloud Bot API server before launching the bot locally. You must log out the bot before running it locally, otherwise there is no guarantee that the bot will receive updates. After a successful call, you will not be able to log in again using the same token for 10 minutes. Returns True on success. Requires no parameters.</summary>
	/// <param name="bot">Bot Client</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> LogOutAsync(this ITelegramBotClient bot, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return await bot.CallMethodAsync<bool>(MethodNames.LogOut, cancellationToken).ConfigureAwait(false);
	}
}