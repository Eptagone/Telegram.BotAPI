// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class GettingUpdatesExtensions
{
    /// <summary>
    /// Use this method to specify a URL and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified URL, containing a JSON-serialized <see cref="Update"/>. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns <em>True</em> on success.
    /// If you'd like to make sure that the webhook was set by you, you can specify secret data in the parameter <em>secret_token</em>. If specified, the request will contain a header “X-Telegram-Bot-Api-Secret-Token” with the secret token as content.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetWebhook" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetWebhook(this ITelegramBotClient client, SetWebhookArgs args) =>
        client.SetWebhookAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to specify a URL and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified URL, containing a JSON-serialized <see cref="Update"/>. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns <em>True</em> on success.
    /// If you'd like to make sure that the webhook was set by you, you can specify secret data in the parameter <em>secret_token</em>. If specified, the request will contain a header “X-Telegram-Bot-Api-Secret-Token” with the secret token as content.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetWebhook" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetWebhookAsync(this ITelegramBotClient client, SetWebhookArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SetWebhook, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to specify a URL and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified URL, containing a JSON-serialized <see cref="Update"/>. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns <em>True</em> on success.
    /// If you'd like to make sure that the webhook was set by you, you can specify secret data in the parameter <em>secret_token</em>. If specified, the request will contain a header “X-Telegram-Bot-Api-Secret-Token” with the secret token as content.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="url">HTTPS URL to send updates to. Use an empty string to remove webhook integration</param>
    /// <param name="certificate">Upload your public key certificate so that the root certificate in use can be checked. See our <a href="https://core.telegram.org/bots/self-signed">self-signed guide</a> for details.</param>
    /// <param name="ipAddress">The fixed IP address which will be used to send webhook requests instead of the IP address resolved through DNS</param>
    /// <param name="maxConnections">The maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to <em>40</em>. Use lower values to limit the load on your bot's server, and higher values to increase your bot's throughput.</param>
    /// <param name="allowedUpdates">A JSON-serialized list of the update types you want your bot to receive. For example, specify <em>["message", "edited_channel_post", "callback_query"]</em> to only receive updates of these types. See <see cref="Update"/> for a complete list of available update types. Specify an empty list to receive all update types except <em>chat_member</em>, <em>message_reaction</em>, and <em>message_reaction_count</em> (default). If not specified, the previous setting will be used.<br />Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</param>
    /// <param name="dropPendingUpdates">Pass <em>True</em> to drop all pending updates</param>
    /// <param name="secretToken">A secret token to be sent in a header “X-Telegram-Bot-Api-Secret-Token” in every webhook request, 1-256 characters. Only characters <em>A-Z</em>, <em>a-z</em>, <em>0-9</em>, <em>_</em> and <em>-</em> are allowed. The header is useful to ensure that the request comes from a webhook set by you.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetWebhook(this ITelegramBotClient client, string url, InputFile? certificate = null, string? ipAddress = null, int? maxConnections = null, IEnumerable<string>? allowedUpdates = null, bool? dropPendingUpdates = null, string? secretToken = null) =>
        client.SetWebhookAsync(url, certificate, ipAddress, maxConnections, allowedUpdates, dropPendingUpdates, secretToken).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to specify a URL and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified URL, containing a JSON-serialized <see cref="Update"/>. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns <em>True</em> on success.
    /// If you'd like to make sure that the webhook was set by you, you can specify secret data in the parameter <em>secret_token</em>. If specified, the request will contain a header “X-Telegram-Bot-Api-Secret-Token” with the secret token as content.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="url">HTTPS URL to send updates to. Use an empty string to remove webhook integration</param>
    /// <param name="certificate">Upload your public key certificate so that the root certificate in use can be checked. See our <a href="https://core.telegram.org/bots/self-signed">self-signed guide</a> for details.</param>
    /// <param name="ipAddress">The fixed IP address which will be used to send webhook requests instead of the IP address resolved through DNS</param>
    /// <param name="maxConnections">The maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to <em>40</em>. Use lower values to limit the load on your bot's server, and higher values to increase your bot's throughput.</param>
    /// <param name="allowedUpdates">A JSON-serialized list of the update types you want your bot to receive. For example, specify <em>["message", "edited_channel_post", "callback_query"]</em> to only receive updates of these types. See <see cref="Update"/> for a complete list of available update types. Specify an empty list to receive all update types except <em>chat_member</em>, <em>message_reaction</em>, and <em>message_reaction_count</em> (default). If not specified, the previous setting will be used.<br />Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</param>
    /// <param name="dropPendingUpdates">Pass <em>True</em> to drop all pending updates</param>
    /// <param name="secretToken">A secret token to be sent in a header “X-Telegram-Bot-Api-Secret-Token” in every webhook request, 1-256 characters. Only characters <em>A-Z</em>, <em>a-z</em>, <em>0-9</em>, <em>_</em> and <em>-</em> are allowed. The header is useful to ensure that the request comes from a webhook set by you.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetWebhookAsync(this ITelegramBotClient client, string url, InputFile? certificate = null, string? ipAddress = null, int? maxConnections = null, IEnumerable<string>? allowedUpdates = null, bool? dropPendingUpdates = null, string? secretToken = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.Url, url ?? throw new ArgumentNullException(nameof(url)) }
        };
        if (certificate is not null)
        {
            args.Add(PropertyNames.Certificate, certificate);
        }
        if (ipAddress is not null)
        {
            args.Add(PropertyNames.IpAddress, ipAddress);
        }
        if (maxConnections is not null)
        {
            args.Add(PropertyNames.MaxConnections, maxConnections);
        }
        if (allowedUpdates is not null)
        {
            args.Add(PropertyNames.AllowedUpdates, allowedUpdates);
        }
        if (dropPendingUpdates is not null)
        {
            args.Add(PropertyNames.DropPendingUpdates, dropPendingUpdates);
        }
        if (secretToken is not null)
        {
            args.Add(PropertyNames.SecretToken, secretToken);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetWebhook, args, cancellationToken);
    }
}
