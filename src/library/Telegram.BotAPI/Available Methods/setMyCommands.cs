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
	/// <summary>Use this method to change the list of the bot's commands. See https://core.telegram.org/bots#commands for more details about bot commands. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="commands">A list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetMyCommands(this ITelegramBotClient bot, params BotCommand[] commands)
	{
		if (bot == null)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (commands == null)
		{
			throw new ArgumentNullException(nameof(commands));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteStartArray(PropertyNames.Commands);
		foreach (var cmd in commands)
		{
			if (string.IsNullOrEmpty(cmd.Command) || string.IsNullOrEmpty(cmd.Description))
			{
				throw new ArgumentNullException($"{nameof(commands)} properties can't be null");
			}

			json.WriteStartObject();
			json.WriteString(PropertyNames.Command, cmd.Command);
			json.WriteString(PropertyNames.Description, cmd.Description);
			json.WriteEndObject();
		}
		json.WriteEndArray();
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<bool>(MethodNames.SetMyCommands, stream);
	}
	/// <summary>Use this method to change the list of the bot's commands. See https://core.telegram.org/bots#commands for more details about bot commands. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="commands">A <see cref="BotCommand"/> list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
	/// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetMyCommands(this ITelegramBotClient bot, IEnumerable<BotCommand> commands, [Optional] BotCommandScope scope, [Optional] string languageCode)
	{
		if (bot == null)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (commands == default)
		{
			throw new ArgumentNullException(nameof(commands));
		}

		var args = new SetMyCommandsArgs(commands, scope, languageCode);
		return bot.CallMethod<bool>(MethodNames.SetMyCommands, args);
	}

	/// <summary>Use this method to change the list of the bot's commands. See https://core.telegram.org/bots#commands for more details about bot commands. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static bool SetMyCommands(this ITelegramBotClient bot, SetMyCommandsArgs args)
	{
		if (bot == null)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		return bot.CallMethod<bool>(MethodNames.SetMyCommands, args);
	}

	/// <summary>Use this method to change the list of the bot's commands. See https://core.telegram.org/bots#commands for more details about bot commands. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="commands">A list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
	/// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> SetMyCommandsAsync(this ITelegramBotClient bot, IEnumerable<BotCommand> commands, [Optional] BotCommandScope scope, [Optional] string languageCode, CancellationToken cancellationToken = default)
	{
		if (bot == null)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (commands == default)
		{
			throw new ArgumentNullException(nameof(commands));
		}

		var args = new SetMyCommandsArgs(commands, scope, languageCode);
		return await bot.CallMethodAsync<bool>(MethodNames.SetMyCommands, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Use this method to change the list of the bot's commands. See https://core.telegram.org/bots#commands for more details about bot commands. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>True</returns>
	public static async Task<bool> SetMyCommandsAsync(this ITelegramBotClient bot, SetMyCommandsArgs args, CancellationToken cancellationToken = default)
	{
		if (bot == null)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<bool>(MethodNames.SetMyCommands, args, cancellationToken).ConfigureAwait(false);
	}
}
