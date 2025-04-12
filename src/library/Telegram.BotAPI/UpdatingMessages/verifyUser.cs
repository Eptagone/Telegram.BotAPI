// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Verifies a user <a href="https://telegram.org/verify#third-party-verification">on behalf of the organization</a> which is represented by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="customDescription">Custom description for the verification; 0-70 characters. Must be empty if the organization isn't allowed to provide a custom verification description.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool VerifyUser(this ITelegramBotClient client, long userId, string? customDescription = null) =>
        client.VerifyUserAsync(userId, customDescription).GetAwaiter().GetResult();

    /// <summary>
    /// Verifies a user <a href="https://telegram.org/verify#third-party-verification">on behalf of the organization</a> which is represented by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="customDescription">Custom description for the verification; 0-70 characters. Must be empty if the organization isn't allowed to provide a custom verification description.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> VerifyUserAsync(this ITelegramBotClient client, long userId, string? customDescription = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId }
        };
        if (customDescription is not null)
        {
            args.Add(PropertyNames.CustomDescription, customDescription);
        }

        return client.CallMethodAsync<bool>(MethodNames.VerifyUser, args, cancellationToken);
    }
}
