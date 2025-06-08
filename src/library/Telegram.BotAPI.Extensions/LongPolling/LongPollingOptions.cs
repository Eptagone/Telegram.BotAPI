// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Extensions.LongPolling;

/// <summary>
/// Represents basic options for long polling.
/// </summary>
public record LongPollingOptions
{
    /// <summary>
    /// Limits the number of updates to be retrieved per call. Values between 1-100 are accepted. Defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// A JSON-serialized list of the update types you want your bot to receive. For example, specify <em>["message", "edited_channel_post", "callback_query"]</em> to only receive updates of these types. See <see cref="Update"/> for a complete list of available update types. Specify an empty list to receive all update types except <em>chat_member</em>, <em>message_reaction</em>, and <em>message_reaction_count</em> (default). If not specified, the previous setting will be used.<br /><br />Please note that this parameter doesn't affect updates created before the call to getUpdates, so unwanted updates may be received for a short period of time.
    /// </summary>
    public IEnumerable<string>? AllowedUpdates { get; set; }

    /// <summary>
    /// Pass <em>True</em> to drop all pending updates
    /// </summary>
    public bool? DropPendingUpdates { get; set; }

    /// <summary>
    /// Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.
    /// </summary>
    public int? Timeout { get; set; }

    /// <summary>
    /// Optional. Enables the parallel update processing by specifying the maximum number of updates to be processed simultaneously.
    /// </summary>
    public int? ParallelLimit { get; set; }
}
