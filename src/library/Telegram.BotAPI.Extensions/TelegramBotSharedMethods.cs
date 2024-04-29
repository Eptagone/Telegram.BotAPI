// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Defines shared methods used by:
/// <list type="bullet">
/// <item><see cref="SimpleTelegramBotBase{TBotClient}"/></item>
/// <item><see cref="ContextTelegramBotBase{TBotContext,TBotClient}"/></item>
/// </list>
/// </summary>
/// <remarks>
/// This class is not supposed to be implemented outside of this library.
/// </remarks>
public abstract class TelegramBotSharedMethodsBase
{
    /// <summary>
    /// Special command extractor used by the bot to extract commands from messages.
    /// Use <see cref="SetCommandExtractor(IBotCommandExtractor)"/> or <see cref="SetCommandExtractor(string, bool)"/> to configure it.
    /// </summary>
    /// <remarks>
    /// If the command extractor is not configured, the default message handler will extract the commands in the simplest way possible: by checking if the message contains an entity of type "bot_command" and splitting the text by spaces.
    /// <para>
    /// Set up an extractor to get more advanced features like:
    /// <list type="bullet">
    /// <item>Ignore other bots' commands.</item>
    /// <item>Remove username from command name.</item>
    /// </list>
    /// </para>
    /// </remarks>
    protected IBotCommandExtractor? CommandExtractor { get; private set; }

    /// <summary>
    /// Configures the command extractor used by the bot to extract commands from messages.
    /// </summary>
    /// <param name="cmdExtractor">The command extractor to use.</param>
    public void SetCommandExtractor(IBotCommandExtractor cmdExtractor)
    {
        if (cmdExtractor is null)
        {
            throw new ArgumentNullException(nameof(cmdExtractor));
        }
        this.CommandExtractor = cmdExtractor;
    }

    /// <summary>
    /// Configures the command extractor used by the bot to extract commands from messages.
    /// </summary>
    /// <param name="username">The bot username.</param>
    /// <param name="useRegexCompile">True to compile the regex used to extract commands.</param>
    /// <remarks>
    /// This method uses an internal implementation of <see cref="IBotCommandExtractor"/> that uses regex to extract commands.
    /// </remarks>
    protected void SetCommandExtractor(string username, bool useRegexCompile = true)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new ArgumentNullException(nameof(username));
        }
        this.CommandExtractor = new BotCommandExtractor(username, useRegexCompile);
    }
}
