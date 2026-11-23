// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SetMySettings" method.
/// </summary>
public class SetMySettingsArgs
{
    /// <summary>
    /// Pass <em>True</em> to enable <a href="https://core.telegram.org/bots/api#inline-mode">inline mode</a> for the bot or <em>False</em> to disable it
    /// </summary>
    [JsonPropertyName(PropertyNames.SupportsInlineQueries)]
    public bool? SupportsInlineQueries { get; set; }

    /// <summary>
    /// New placeholder for inline queries, which is shown in the input field after the bot's username. Pass an empty string to use the default placeholder.
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineQueryPlaceholder)]
    public string? InlineQueryPlaceholder { get; set; }

    /// <summary>
    /// Pass <em>True</em> to request the location of the user with every inline query to the bot or <em>False</em> to stop requesting it
    /// </summary>
    [JsonPropertyName(PropertyNames.NeedsInlineQueryLocation)]
    public bool? NeedsInlineQueryLocation { get; set; }

    /// <summary>
    /// Denominator of the share of <a href="https://core.telegram.org/bots/api#choseninlineresult">chosen inline results</a> received by the bot; the bot receives 1 out of <em>inline_feedback_share_denominator</em> chosen results. Must be one of 1, 10, 100, or 1000. Pass 0 to stop receiving chosen inline results.
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineFeedbackShareDenominator)]
    public int? InlineFeedbackShareDenominator { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow adding the bot to groups or <em>False</em> to disallow it
    /// </summary>
    [JsonPropertyName(PropertyNames.CanJoinGroups)]
    public bool? CanJoinGroups { get; set; }

    /// <summary>
    /// Pass <em>True</em> to disable <a href="https://core.telegram.org/bots/features#privacy-mode">privacy mode</a> for the bot or <em>False</em> to enable it
    /// </summary>
    [JsonPropertyName(PropertyNames.CanReadAllGroupMessages)]
    public bool? CanReadAllGroupMessages { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow connecting the bot to user accounts to manage them or <em>False</em> to disallow it
    /// </summary>
    [JsonPropertyName(PropertyNames.CanConnectToBusiness)]
    public bool? CanConnectToBusiness { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow creating other bots that will be controlled by the bot or <em>False</em> to disallow it
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageBots)]
    public bool? CanManageBots { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow guest queries to the bot from chats it isn't a member of or <em>False</em> to disallow them
    /// </summary>
    [JsonPropertyName(PropertyNames.SupportsGuestQueries)]
    public bool? SupportsGuestQueries { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow assigning the bot to process join request queries or <em>False</em> to disallow it
    /// </summary>
    [JsonPropertyName(PropertyNames.SupportsJoinRequestQueries)]
    public bool? SupportsJoinRequestQueries { get; set; }

    /// <summary>
    /// Pass <em>True</em> to enable forum topic mode in private chats with the bot or <em>False</em> to disable it
    /// </summary>
    [JsonPropertyName(PropertyNames.HasTopicsEnabled)]
    public bool? HasTopicsEnabled { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow users to create and delete topics in private chats with the bot or <em>False</em> to disallow it
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowsUsersToCreateTopics)]
    public bool? AllowsUsersToCreateTopics { get; set; }

    /// <summary>
    /// Pass <em>True</em> to show topics in private chats with the bot in a sidebar or <em>False</em> to stop showing them in a sidebar
    /// </summary>
    [JsonPropertyName(PropertyNames.HasTopicSidebar)]
    public bool? HasTopicSidebar { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow the bot to communicate with other bots in groups, private chats, and through business accounts or <em>False</em> to disallow it
    /// </summary>
    [JsonPropertyName(PropertyNames.CanCommunicateWithBots)]
    public bool? CanCommunicateWithBots { get; set; }

    /// <summary>
    /// Mode in which the bot receives <a href="https://core.telegram.org/bots/api#callbackquery">callback queries</a> from buttons in messages sent by the bot. Must be one of “default” (the field <em>message</em> is always used and contains an <see cref="InaccessibleMessage"/> if the message is inaccessible to the bot), “auto” (the field <em>inline_message_id</em> is used instead of the field <em>message</em> if the message is inaccessible to the bot; the field <em>message</em> can still contain an inaccessible message if the message has just been deleted), or “inline” (the field <em>inline_message_id</em> is always used instead of the field <em>message</em>).
    /// </summary>
    [JsonPropertyName(PropertyNames.CallbackQueryMode)]
    public string? CallbackQueryMode { get; set; }
}
