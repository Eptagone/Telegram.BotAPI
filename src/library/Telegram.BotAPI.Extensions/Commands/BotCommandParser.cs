using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Extensions.Commands;

/// <summary>
/// Provides methods to parse Telegram bot commands from messages.
/// </summary>
public static class BotCommandParser
{
    private static readonly Regex pattern =
        new(
            @"^\/(?<cmd>\w+)(?:@(?<username>[^\s]+))?(?:\s+(?<params>.+))?$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

    /// <summary>
    /// Parse the provided message and return the command name, arguments, and the username of the bot the command is targeted to (if available).
    /// </summary>
    /// <param name="message">The message to parse.</param>
    /// <exception cref="ArgumentException">Thrown when the message does not contain a command.</exception>
    public static (string commandName, string? args, string? username) Parse(Message message)
    {
        var text = message.Text ?? message.Caption;
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("The message is not a command.", nameof(message));
        }
        return Parse(text ?? string.Empty);
    }

    /// <summary>
    /// Parse the provided message and return the command name, arguments, and the username of the bot the command is targeted to (if available).
    /// </summary>
    /// <param name="message">The message to parse.</param>
    /// <exception cref="ArgumentException">Thrown when the message does not contain a command.</exception>
    public static (string commandName, string? args, string? username) Parse(string message)
    {
        if (TryParse(message, out var result))
        {
            return result;
        }
        throw new ArgumentException("The message is not a command.", nameof(message));
    }

    /// <summary>
    /// Try to parse the provided message and return the command name, arguments, and the username of the bot the command is targeted to (if available).
    /// </summary>
    /// <param name="message">The message to parse.</param>
    /// <param name="result">The parsed command name, arguments, and the username of the bot the command is targeted to (if available).</param>
    /// <returns></returns>
    public static bool TryParse(
        Message message,
        out (string commandName, string? args, string? username) result
    )
    {
        var text = message.Text ?? message.Caption;
        if (string.IsNullOrEmpty(text))
        {
            result = default;
            return false;
        }

        return TryParse(text!, out result);
    }

    /// <summary>
    /// Try to parse the provided message and return the command name, arguments, and the username of the bot the command is targeted to (if available).
    /// </summary>
    /// <param name="message">The message to parse.</param>
    /// <param name="result">The parsed command name, arguments, and the username of the bot the command is targeted to (if available).</param>
    /// <returns></returns>
    public static bool TryParse(
        string message,
        out (string commandName, string? args, string? username) result
    )
    {
        var match = pattern.Match(message);
        result = match.Success
            ? (
                match.Groups["cmd"].Value,
                match.Groups["params"].Value,
                match.Groups["username"].Value
            )
            : default;
        return match.Success;
    }
}
