// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>Use this method to delete the list of the bot's commands for the given scope and user language. After deletion, <a href="https://core.telegram.org/bots/api#determining-list-of-commands">higher level commands</a> will be shown to affected users.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
		/// <param name="languageCode">	A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands.</param>
		/// <returns>True on success.</returns>
		public static bool DeleteMyCommands(this BotClient? bot, [Optional] BotCommandScope scope, [Optional] string languageCode)
		{
			if (bot == null)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var args = new DeleteMyCommandsArgs(scope, languageCode);
			return bot.RPC<bool>(MethodNames.DeleteMyCommands, args);
		}

		/// <summary>Use this method to delete the list of the bot's commands for the given scope and user language. After deletion, <a href="https://core.telegram.org/bots/api#determining-list-of-commands">higher level commands</a> will be shown to affected users.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <returns>True on success.</returns>
		public static bool DeleteMyCommands(this BotClient? bot, DeleteMyCommandsArgs args)
		{
			if (bot == null)
			{
				throw new ArgumentNullException(nameof(bot));
			}
			if (args == null)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return bot.RPC<bool>(MethodNames.DeleteMyCommands, args);
		}

		/// <summary>Use this method to delete the list of the bot's commands for the given scope and user language. After deletion, <a href="https://core.telegram.org/bots/api#determining-list-of-commands">higher level commands</a> will be shown to affected users.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
		/// <param name="languageCode">	A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <returns>True on success.</returns>
		public static async Task<bool> DeleteMyCommandsAsync(this BotClient? bot, [Optional] BotCommandScope scope, [Optional] string languageCode, CancellationToken cancellationToken)
		{
			if (bot == null)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var args = new DeleteMyCommandsArgs(scope, languageCode);
			return await bot.RPCA<bool>(MethodNames.DeleteMyCommands, args, cancellationToken: cancellationToken).ConfigureAwait(false);
		}

		/// <summary>Use this method to delete the list of the bot's commands for the given scope and user language. After deletion, <a href="https://core.telegram.org/bots/api#determining-list-of-commands">higher level commands</a> will be shown to affected users.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <returns>True on success.</returns>
		public static async Task<bool> DeleteMyCommandsAsync(this BotClient? bot, DeleteMyCommandsArgs args, [Optional] CancellationToken cancellationToken)
		{
			if (bot == null)
			{
				throw new ArgumentNullException(nameof(bot));
			}
			if (args == null)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return await bot.RPCA<bool>(MethodNames.DeleteMyCommands, args, cancellationToken: cancellationToken).ConfigureAwait(false);
		}
	}
}
