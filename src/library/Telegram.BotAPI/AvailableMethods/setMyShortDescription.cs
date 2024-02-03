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
    /// Use this method to change the bot's short description, which is shown on the bot's profile page and is sent together with the link when users share the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="shortDescription">New short description for the bot; 0-120 characters. Pass an empty string to remove the dedicated short description for the given language.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the short description will be applied to all users for whose language there is no dedicated short description.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetMyShortDescription(this ITelegramBotClient client, string? shortDescription = null, string? languageCode = null) =>
        client.SetMyShortDescriptionAsync(shortDescription, languageCode).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the bot's short description, which is shown on the bot's profile page and is sent together with the link when users share the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="shortDescription">New short description for the bot; 0-120 characters. Pass an empty string to remove the dedicated short description for the given language.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the short description will be applied to all users for whose language there is no dedicated short description.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetMyShortDescriptionAsync(this ITelegramBotClient client, string? shortDescription = null, string? languageCode = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (shortDescription is not null)
        {
            args.Add(PropertyNames.ShortDescription, shortDescription);
        }
        if (languageCode is not null)
        {
            args.Add(PropertyNames.LanguageCode, languageCode);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetMyShortDescription, args, cancellationToken);
    }
}
