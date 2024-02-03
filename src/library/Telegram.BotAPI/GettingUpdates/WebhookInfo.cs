// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// Describes the current status of a webhook.
/// </summary>
public class WebhookInfo
{
    /// <summary>
    /// Webhook URL, may be empty if webhook is not set up
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string Url { get; set; } = null!;

    /// <summary>
    /// <em>True</em>, if a custom certificate was provided for webhook certificate checks
    /// </summary>
    [JsonPropertyName(PropertyNames.HasCustomCertificate)]
    public bool HasCustomCertificate { get; set; }

    /// <summary>
    /// Number of updates awaiting delivery
    /// </summary>
    [JsonPropertyName(PropertyNames.PendingUpdateCount)]
    public int PendingUpdateCount { get; set; }

    /// <summary>
    /// Optional. Currently used webhook IP address
    /// </summary>
    [JsonPropertyName(PropertyNames.IpAddress)]
    public string? IpAddress { get; set; }

    /// <summary>
    /// Optional. Unix time for the most recent error that happened when trying to deliver an update via webhook
    /// </summary>
    [JsonPropertyName(PropertyNames.LastErrorDate)]
    public int? LastErrorDate { get; set; }

    /// <summary>
    /// Optional. Error message in human-readable format for the most recent error that happened when trying to deliver an update via webhook
    /// </summary>
    [JsonPropertyName(PropertyNames.LastErrorMessage)]
    public string? LastErrorMessage { get; set; }

    /// <summary>
    /// Optional. Unix time of the most recent error that happened when trying to synchronize available updates with Telegram datacenters
    /// </summary>
    [JsonPropertyName(PropertyNames.LastSynchronizationErrorDate)]
    public int? LastSynchronizationErrorDate { get; set; }

    /// <summary>
    /// Optional. The maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery
    /// </summary>
    [JsonPropertyName(PropertyNames.MaxConnections)]
    public int? MaxConnections { get; set; }

    /// <summary>
    /// Optional. A list of update types the bot is subscribed to. Defaults to all update types except <em>chat_member</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowedUpdates)]
    public IEnumerable<string>? AllowedUpdates { get; set; }
}
