// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// Represents the arguments of the "GetUpdates" method.
/// </summary>
public class GetUpdatesArgs
{
    /// <summary>
    /// Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned. An update is considered confirmed as soon as <a href="https://core.telegram.org/bots/api#getupdates">getUpdates</a> is called with an <em>offset</em> higher than its <em>update_id</em>. The negative offset can be specified to retrieve updates starting from <em>-offset</em> update from the end of the updates queue. All previous updates will be forgotten.
    /// </summary>
    [JsonPropertyName(PropertyNames.Offset)]
    public int? Offset { get; set; }

    /// <summary>
    /// Limits the number of updates to be retrieved. Values between 1-100 are accepted. Defaults to 100.
    /// </summary>
    [JsonPropertyName(PropertyNames.Limit)]
    public int? Limit { get; set; }

    /// <summary>
    /// Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.
    /// </summary>
    [JsonPropertyName(PropertyNames.Timeout)]
    public int? Timeout { get; set; }

    /// <summary>
    /// A JSON-serialized list of the update types you want your bot to receive. For example, specify <em>["message", "edited_channel_post", "callback_query"]</em> to only receive updates of these types. See <see cref="Update"/> for a complete list of available update types. Specify an empty list to receive all update types except <em>chat_member</em>, <em>message_reaction</em>, and <em>message_reaction_count</em> (default). If not specified, the previous setting will be used.<br /><br />Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowedUpdates)]
    public IEnumerable<string>? AllowedUpdates { get; set; }
}
