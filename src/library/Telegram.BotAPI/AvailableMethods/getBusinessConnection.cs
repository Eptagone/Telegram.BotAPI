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
    /// Use this method to get information about the connection of the bot with a business account. Returns a <see cref="BusinessConnection"/> object on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static BusinessConnection GetBusinessConnection(this ITelegramBotClient client, string businessConnectionId) =>
        client.GetBusinessConnectionAsync(businessConnectionId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get information about the connection of the bot with a business account. Returns a <see cref="BusinessConnection"/> object on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<BusinessConnection> GetBusinessConnectionAsync(this ITelegramBotClient client, string businessConnectionId, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) }
        };

        return client.CallMethodAsync<BusinessConnection>(MethodNames.GetBusinessConnection, args, cancellationToken);
    }
}
