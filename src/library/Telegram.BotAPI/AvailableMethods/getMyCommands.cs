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
    /// Use this method to get the current list of the bot's commands for the given scope and user language. Returns an Array of <see cref="BotCommand"/> objects. If commands aren't set, an empty list is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetMyCommands" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<BotCommand> GetMyCommands(this ITelegramBotClient client, GetMyCommandsArgs args) =>
        client.GetMyCommandsAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the current list of the bot's commands for the given scope and user language. Returns an Array of <see cref="BotCommand"/> objects. If commands aren't set, an empty list is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetMyCommands" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<BotCommand>> GetMyCommandsAsync(this ITelegramBotClient client, GetMyCommandsArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<IEnumerable<BotCommand>>(MethodNames.GetMyCommands, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to get the current list of the bot's commands for the given scope and user language. Returns an Array of <see cref="BotCommand"/> objects. If commands aren't set, an empty list is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="scope">A JSON-serialized object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<BotCommand> GetMyCommands(this ITelegramBotClient client, BotCommandScope? scope = null, string? languageCode = null) =>
        client.GetMyCommandsAsync(scope, languageCode).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the current list of the bot's commands for the given scope and user language. Returns an Array of <see cref="BotCommand"/> objects. If commands aren't set, an empty list is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="scope">A JSON-serialized object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<BotCommand>> GetMyCommandsAsync(this ITelegramBotClient client, BotCommandScope? scope = null, string? languageCode = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (scope is not null)
        {
            args.Add(PropertyNames.Scope, scope);
        }
        if (languageCode is not null)
        {
            args.Add(PropertyNames.LanguageCode, languageCode);
        }

        return client.CallMethodAsync<IEnumerable<BotCommand>>(MethodNames.GetMyCommands, args, cancellationToken);
    }
}
