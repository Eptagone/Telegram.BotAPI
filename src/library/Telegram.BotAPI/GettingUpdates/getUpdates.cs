// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class GettingUpdatesExtensions
{
    /// <summary>
    /// Use this method to receive incoming updates using long polling (<a href="https://en.wikipedia.org/wiki/Push_technology#Long_polling">wiki</a>). Returns an Array of <see cref="Update"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetUpdates" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<Update> GetUpdates(this ITelegramBotClient client, GetUpdatesArgs args) =>
        client.GetUpdatesAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to receive incoming updates using long polling (<a href="https://en.wikipedia.org/wiki/Push_technology#Long_polling">wiki</a>). Returns an Array of <see cref="Update"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetUpdates" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<Update>> GetUpdatesAsync(this ITelegramBotClient client, GetUpdatesArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<IEnumerable<Update>>(MethodNames.GetUpdates, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to receive incoming updates using long polling (<a href="https://en.wikipedia.org/wiki/Push_technology#Long_polling">wiki</a>). Returns an Array of <see cref="Update"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="offset">Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned. An update is considered confirmed as soon as <a href="https://core.telegram.org/bots/api#getupdates">getUpdates</a> is called with an <em>offset</em> higher than its <em>update_id</em>. The negative offset can be specified to retrieve updates starting from <em>-offset</em> update from the end of the updates queue. All previous updates will be forgotten.</param>
    /// <param name="limit">Limits the number of updates to be retrieved. Values between 1-100 are accepted. Defaults to 100.</param>
    /// <param name="timeout">Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</param>
    /// <param name="allowedUpdates">A JSON-serialized list of the update types you want your bot to receive. For example, specify <em>["message", "edited_channel_post", "callback_query"]</em> to only receive updates of these types. See <see cref="Update"/> for a complete list of available update types. Specify an empty list to receive all update types except <em>chat_member</em>, <em>message_reaction</em>, and <em>message_reaction_count</em> (default). If not specified, the previous setting will be used.<br /><br />Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<Update> GetUpdates(this ITelegramBotClient client, int? offset = null, int? limit = null, int? timeout = null, IEnumerable<string>? allowedUpdates = null) =>
        client.GetUpdatesAsync(offset, limit, timeout, allowedUpdates).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to receive incoming updates using long polling (<a href="https://en.wikipedia.org/wiki/Push_technology#Long_polling">wiki</a>). Returns an Array of <see cref="Update"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="offset">Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned. An update is considered confirmed as soon as <a href="https://core.telegram.org/bots/api#getupdates">getUpdates</a> is called with an <em>offset</em> higher than its <em>update_id</em>. The negative offset can be specified to retrieve updates starting from <em>-offset</em> update from the end of the updates queue. All previous updates will be forgotten.</param>
    /// <param name="limit">Limits the number of updates to be retrieved. Values between 1-100 are accepted. Defaults to 100.</param>
    /// <param name="timeout">Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</param>
    /// <param name="allowedUpdates">A JSON-serialized list of the update types you want your bot to receive. For example, specify <em>["message", "edited_channel_post", "callback_query"]</em> to only receive updates of these types. See <see cref="Update"/> for a complete list of available update types. Specify an empty list to receive all update types except <em>chat_member</em>, <em>message_reaction</em>, and <em>message_reaction_count</em> (default). If not specified, the previous setting will be used.<br /><br />Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<Update>> GetUpdatesAsync(this ITelegramBotClient client, int? offset = null, int? limit = null, int? timeout = null, IEnumerable<string>? allowedUpdates = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (offset is not null)
        {
            args.Add(PropertyNames.Offset, offset);
        }
        if (limit is not null)
        {
            args.Add(PropertyNames.Limit, limit);
        }
        if (timeout is not null)
        {
            args.Add(PropertyNames.Timeout, timeout);
        }
        if (allowedUpdates is not null)
        {
            args.Add(PropertyNames.AllowedUpdates, allowedUpdates);
        }

        return client.CallMethodAsync<IEnumerable<Update>>(MethodNames.GetUpdates, args, cancellationToken);
    }
}
