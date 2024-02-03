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
    /// Use this method to change the bot's description, which is shown in the chat with the bot if the chat is empty. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="description">New bot description; 0-512 characters. Pass an empty string to remove the dedicated description for the given language.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the description will be applied to all users for whose language there is no dedicated description.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetMyDescription(this ITelegramBotClient client, string? description = null, string? languageCode = null) =>
        client.SetMyDescriptionAsync(description, languageCode).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the bot's description, which is shown in the chat with the bot if the chat is empty. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="description">New bot description; 0-512 characters. Pass an empty string to remove the dedicated description for the given language.</param>
    /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, the description will be applied to all users for whose language there is no dedicated description.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetMyDescriptionAsync(this ITelegramBotClient client, string? description = null, string? languageCode = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (description is not null)
        {
            args.Add(PropertyNames.Description, description);
        }
        if (languageCode is not null)
        {
            args.Add(PropertyNames.LanguageCode, languageCode);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetMyDescription, args, cancellationToken);
    }
}
