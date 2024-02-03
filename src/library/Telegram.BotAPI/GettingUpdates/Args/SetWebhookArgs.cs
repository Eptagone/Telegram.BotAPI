// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// Represents the arguments of the "SetWebhook" method.
/// </summary>
public class SetWebhookArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetWebhookArgs"/> class.
    /// </summary>
    /// <param name="url">HTTPS URL to send updates to. Use an empty string to remove webhook integration</param>
    public SetWebhookArgs(string url)
    {
        this.Url = url ?? throw new ArgumentNullException(nameof(url));
    }

    /// <summary>
    /// HTTPS URL to send updates to. Use an empty string to remove webhook integration
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string Url { get; set; }

    /// <summary>
    /// Upload your public key certificate so that the root certificate in use can be checked. See our <a href="https://core.telegram.org/bots/self-signed">self-signed guide</a> for details.
    /// </summary>
    [JsonPropertyName(PropertyNames.Certificate)]
    public InputFile? Certificate { get; set; }

    /// <summary>
    /// The fixed IP address which will be used to send webhook requests instead of the IP address resolved through DNS
    /// </summary>
    [JsonPropertyName(PropertyNames.IpAddress)]
    public string? IpAddress { get; set; }

    /// <summary>
    /// The maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to <em>40</em>. Use lower values to limit the load on your bot's server, and higher values to increase your bot's throughput.
    /// </summary>
    [JsonPropertyName(PropertyNames.MaxConnections)]
    public int? MaxConnections { get; set; }

    /// <summary>
    /// A JSON-serialized list of the update types you want your bot to receive. For example, specify <em>["message", "edited_channel_post", "callback_query"]</em> to only receive updates of these types. See <see cref="Update"/> for a complete list of available update types. Specify an empty list to receive all update types except <em>chat_member</em>, <em>message_reaction</em>, and <em>message_reaction_count</em> (default). If not specified, the previous setting will be used.<br />Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowedUpdates)]
    public IEnumerable<string>? AllowedUpdates { get; set; }

    /// <summary>
    /// Pass <em>True</em> to drop all pending updates
    /// </summary>
    [JsonPropertyName(PropertyNames.DropPendingUpdates)]
    public bool? DropPendingUpdates { get; set; }

    /// <summary>
    /// A secret token to be sent in a header “X-Telegram-Bot-Api-Secret-Token” in every webhook request, 1-256 characters. Only characters <em>A-Z</em>, <em>a-z</em>, <em>0-9</em>, <em>_</em> and <em>-</em> are allowed. The header is useful to ensure that the request comes from a webhook set by you.
    /// </summary>
    [JsonPropertyName(PropertyNames.SecretToken)]
    public string? SecretToken { get; set; }
}
