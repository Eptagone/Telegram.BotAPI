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
    /// Use this method to get the current default administrator rights of the bot. Returns <see cref="ChatAdministratorRights"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="forChannels">Pass <em>True</em> to get default administrator rights of the bot in channels. Otherwise, default administrator rights of the bot for groups and supergroups will be returned.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static ChatAdministratorRights GetMyDefaultAdministratorRights(this ITelegramBotClient client, bool? forChannels = null) =>
        client.GetMyDefaultAdministratorRightsAsync(forChannels).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the current default administrator rights of the bot. Returns <see cref="ChatAdministratorRights"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="forChannels">Pass <em>True</em> to get default administrator rights of the bot in channels. Otherwise, default administrator rights of the bot for groups and supergroups will be returned.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<ChatAdministratorRights> GetMyDefaultAdministratorRightsAsync(this ITelegramBotClient client, bool? forChannels = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (forChannels is not null)
        {
            args.Add(PropertyNames.ForChannels, forChannels);
        }

        return client.CallMethodAsync<ChatAdministratorRights>(MethodNames.GetMyDefaultAdministratorRights, args, cancellationToken);
    }
}
