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
    /// Changes the first and last name of a managed business account. Requires the <em>can_change_name</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="firstName">The new value of the first name for the business account; 1-64 characters</param>
    /// <param name="lastName">The new value of the last name for the business account; 0-64 characters</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetBusinessAccountName(this ITelegramBotClient client, string businessConnectionId, string firstName, string? lastName = null) =>
        client.SetBusinessAccountNameAsync(businessConnectionId, firstName, lastName).GetAwaiter().GetResult();

    /// <summary>
    /// Changes the first and last name of a managed business account. Requires the <em>can_change_name</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="firstName">The new value of the first name for the business account; 1-64 characters</param>
    /// <param name="lastName">The new value of the last name for the business account; 0-64 characters</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetBusinessAccountNameAsync(this ITelegramBotClient client, string businessConnectionId, string firstName, string? lastName = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.FirstName, firstName ?? throw new ArgumentNullException(nameof(firstName)) }
        };
        if (lastName is not null)
        {
            args.Add(PropertyNames.LastName, lastName);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetBusinessAccountName, args, cancellationToken);
    }
}
