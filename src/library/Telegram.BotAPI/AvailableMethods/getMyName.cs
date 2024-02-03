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
    /// Use this method to get the current bot name for the given user language. Returns <see cref="BotName"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static BotName GetMyName(this ITelegramBotClient client, string? languageCode = null) =>
        client.GetMyNameAsync(languageCode).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the current bot name for the given user language. Returns <see cref="BotName"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<BotName> GetMyNameAsync(this ITelegramBotClient client, string? languageCode = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (languageCode is not null)
        {
            args.Add(PropertyNames.LanguageCode, languageCode);
        }

        return client.CallMethodAsync<BotName>(MethodNames.GetMyName, args, cancellationToken);
    }
}
