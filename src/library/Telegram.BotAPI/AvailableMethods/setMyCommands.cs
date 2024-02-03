// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to change the list of the bot's commands. See <a href="https://core.telegram.org/bots/features#commands">this manual</a> for more details about bot commands. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetMyCommands" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetMyCommands(this ITelegramBotClient client, SetMyCommandsArgs args) =>
        client.SetMyCommandsAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the list of the bot's commands. See <a href="https://core.telegram.org/bots/features#commands">this manual</a> for more details about bot commands. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetMyCommands" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetMyCommandsAsync(this ITelegramBotClient client, SetMyCommandsArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SetMyCommands, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to change the list of the bot's commands. See <a href="https://core.telegram.org/bots/features#commands">this manual</a> for more details about bot commands. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="commands">A JSON-serialized list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
    /// <param name="scope">A JSON-serialized object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetMyCommands(this ITelegramBotClient client, IEnumerable<BotCommand> commands, BotCommandScope? scope = null, string? languageCode = null) =>
        client.SetMyCommandsAsync(commands, scope, languageCode).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the list of the bot's commands. See <a href="https://core.telegram.org/bots/features#commands">this manual</a> for more details about bot commands. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="commands">A JSON-serialized list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
    /// <param name="scope">A JSON-serialized object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetMyCommandsAsync(this ITelegramBotClient client, IEnumerable<BotCommand> commands, BotCommandScope? scope = null, string? languageCode = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.Commands, commands ?? throw new ArgumentNullException(nameof(commands)) }
        };
        if (scope is not null)
        {
            args.Add(PropertyNames.Scope, scope);
        }
        if (languageCode is not null)
        {
            args.Add(PropertyNames.LanguageCode, languageCode);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetMyCommands, args, cancellationToken);
    }
}
