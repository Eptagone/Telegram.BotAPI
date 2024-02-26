// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Globalization;
using System.Text.RegularExpressions;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Defines a method to extract commands from a message using regex.
/// </summary>
sealed class BotCommandExtractor : IBotCommandExtractor
{
    private const string COMMAND_EXTRACT_PATTERN = @"^\/(?<cmd>\w*)(?:|@{0})(?:$|\s(?<params>.*))";
    private readonly Regex cmdRegex;

    /// <summary>
    /// Initializes a new instance of the <see cref="BotCommandExtractor"/> class.
    /// </summary>
    /// <param name="username">The bot's username.</param>
    /// <param name="useRegexCompiled">Set true to use regex compiled option.</param>
    public BotCommandExtractor(string username, bool useRegexCompiled)
    {
        var pattern = string.Format(
            CultureInfo.InvariantCulture,
            COMMAND_EXTRACT_PATTERN,
            username
        );
        var options = RegexOptions.IgnoreCase;
        if (useRegexCompiled)
        {
            options |= RegexOptions.Compiled;
        }
        this.cmdRegex = new Regex(pattern, options);
    }

    /// <inheritdoc/>
    public bool HasCommand(Message message)
    {
        var text = message.Text ?? message.Caption;
        return !string.IsNullOrEmpty(text) && this.cmdRegex.IsMatch(text);
    }

    /// <inheritdoc/>
    public (string commandName, string args) ExtractCommand(Message message)
    {
        var text = message.Text ?? message.Caption;
        var match = this.cmdRegex.Match(text);
        if (!match.Success)
        {
            throw new InvalidOperationException("The message does not contain a command.");
        }

        var name = match.Groups["cmd"].Value;
        var args = match.Groups["params"].Value;
        return (name, args);
    }
}
