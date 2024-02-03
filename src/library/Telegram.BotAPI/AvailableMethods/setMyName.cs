// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to change the bot's name. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">New bot name; 0-64 characters. Pass an empty string to remove the dedicated name for the given language.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the name will be shown to all users for whose language there is no dedicated name.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetMyName(this ITelegramBotClient client, string? name = null, string? languageCode = null) =>
        client.SetMyNameAsync(name, languageCode).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the bot's name. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">New bot name; 0-64 characters. Pass an empty string to remove the dedicated name for the given language.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the name will be shown to all users for whose language there is no dedicated name.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetMyNameAsync(this ITelegramBotClient client, string? name = null, string? languageCode = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (name is not null)
        {
            args.Add(PropertyNames.Name, name);
        }
        if (languageCode is not null)
        {
            args.Add(PropertyNames.LanguageCode, languageCode);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetMyName, args, cancellationToken);
    }
}
