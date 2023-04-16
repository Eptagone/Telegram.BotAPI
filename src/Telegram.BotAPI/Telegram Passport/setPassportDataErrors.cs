// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>Telegram Passport</summary>
public static partial class TelegramPassportExtensions
{
	/// <summary>Informs a user that some of the Telegram Passport elements they provided contains errors. The user will not be able to re-submit their Passport to you until the errors are fixed (the contents of the field for which you returned the error must change). Returns True on success.
	/// <para>Use this if the data submitted by the user doesn't satisfy the standards your service requires for any reason. For example, if a birthday date seems invalid, a submitted document is blurry, a scan shows evidence of tampering, etc. Supply some details in the error message to make sure the user knows how to correct the issues.</para></summary>
	/// <param name="bot">Bot Client</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool SetPassportDataErrors(this BotClient? bot, SetPassportDataErrorsArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.RPC<bool>(MethodNames.SetPassportDataErrors, args);
	}

	/// <summary>Informs a user that some of the Telegram Passport elements they provided contains errors. The user will not be able to re-submit their Passport to you until the errors are fixed (the contents of the field for which you returned the error must change). Returns True on success.
	/// <para>Use this if the data submitted by the user doesn't satisfy the standards your service requires for any reason. For example, if a birthday date seems invalid, a submitted document is blurry, a scan shows evidence of tampering, etc. Supply some details in the error message to make sure the user knows how to correct the issues.</para></summary>
	/// <param name="bot">Bot Client</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> SetPassportDataErrorsAsync(this BotClient? bot, SetPassportDataErrorsArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.RPCA<bool>(MethodNames.SetPassportDataErrors, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Informs a user that some of the Telegram Passport elements they provided contains errors. The user will not be able to re-submit their Passport to you until the errors are fixed (the contents of the field for which you returned the error must change). Returns True on success.
	/// <para>Use this if the data submitted by the user doesn't satisfy the standards your service requires for any reason. For example, if a birthday date seems invalid, a submitted document is blurry, a scan shows evidence of tampering, etc. Supply some details in the error message to make sure the user knows how to correct the issues.</para></summary>
	/// <param name="bot">Bot Client</param>
	/// <param name="userId">User identifier</param>
	/// <param name="errors">An array of <see cref="PassportElementError"/> describing the errors</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool SetPassportDataErrors(this BotClient? bot, long userId, IEnumerable<PassportElementError> errors)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (errors == null)
		{
			throw new ArgumentNullException(nameof(errors));
		}

		var args = new SetPassportDataErrorsArgs(userId, errors);
		return bot.RPC<bool>(MethodNames.SetPassportDataErrors, args);
	}

	/// <summary>Informs a user that some of the Telegram Passport elements they provided contains errors. The user will not be able to re-submit their Passport to you until the errors are fixed (the contents of the field for which you returned the error must change). Returns True on success.
	/// <para>Use this if the data submitted by the user doesn't satisfy the standards your service requires for any reason. For example, if a birthday date seems invalid, a submitted document is blurry, a scan shows evidence of tampering, etc. Supply some details in the error message to make sure the user knows how to correct the issues.</para></summary>
	/// <param name="bot">Bot Client</param>
	/// <param name="userId">User identifier</param>
	/// <param name="errors">An array of <see cref="PassportElementError"/> describing the errors</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> SetPassportDataErrorsAsync(this BotClient? bot, long userId, IEnumerable<PassportElementError> errors, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (errors == null)
		{
			throw new ArgumentNullException(nameof(errors));
		}

		var args = new SetPassportDataErrorsArgs(userId, errors);
		return await bot.RPCA<bool>(MethodNames.SetPassportDataErrors, args, cancellationToken).ConfigureAwait(false);
	}
}
