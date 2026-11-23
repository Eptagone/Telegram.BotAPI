// Copyright (c) 2026 Quetzal Rivera.
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
    /// Use this method to change settings of the bot. Settings that aren't specified remain unchanged. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetMySettings" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetMySettings(this ITelegramBotClient client, SetMySettingsArgs args) =>
        client.SetMySettingsAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change settings of the bot. Settings that aren't specified remain unchanged. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetMySettings" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetMySettingsAsync(this ITelegramBotClient client, SetMySettingsArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SetMySettings, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to change settings of the bot. Settings that aren't specified remain unchanged. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="supportsInlineQueries">Pass <em>True</em> to enable <a href="https://core.telegram.org/bots/api#inline-mode">inline mode</a> for the bot or <em>False</em> to disable it</param>
    /// <param name="inlineQueryPlaceholder">New placeholder for inline queries, which is shown in the input field after the bot's username. Pass an empty string to use the default placeholder.</param>
    /// <param name="needsInlineQueryLocation">Pass <em>True</em> to request the location of the user with every inline query to the bot or <em>False</em> to stop requesting it</param>
    /// <param name="inlineFeedbackShareDenominator">Denominator of the share of <a href="https://core.telegram.org/bots/api#choseninlineresult">chosen inline results</a> received by the bot; the bot receives 1 out of <em>inline_feedback_share_denominator</em> chosen results. Must be one of 1, 10, 100, or 1000. Pass 0 to stop receiving chosen inline results.</param>
    /// <param name="canJoinGroups">Pass <em>True</em> to allow adding the bot to groups or <em>False</em> to disallow it</param>
    /// <param name="canReadAllGroupMessages">Pass <em>True</em> to disable <a href="https://core.telegram.org/bots/features#privacy-mode">privacy mode</a> for the bot or <em>False</em> to enable it</param>
    /// <param name="canConnectToBusiness">Pass <em>True</em> to allow connecting the bot to user accounts to manage them or <em>False</em> to disallow it</param>
    /// <param name="canManageBots">Pass <em>True</em> to allow creating other bots that will be controlled by the bot or <em>False</em> to disallow it</param>
    /// <param name="supportsGuestQueries">Pass <em>True</em> to allow guest queries to the bot from chats it isn't a member of or <em>False</em> to disallow them</param>
    /// <param name="supportsJoinRequestQueries">Pass <em>True</em> to allow assigning the bot to process join request queries or <em>False</em> to disallow it</param>
    /// <param name="hasTopicsEnabled">Pass <em>True</em> to enable forum topic mode in private chats with the bot or <em>False</em> to disable it</param>
    /// <param name="allowsUsersToCreateTopics">Pass <em>True</em> to allow users to create and delete topics in private chats with the bot or <em>False</em> to disallow it</param>
    /// <param name="hasTopicSidebar">Pass <em>True</em> to show topics in private chats with the bot in a sidebar or <em>False</em> to stop showing them in a sidebar</param>
    /// <param name="canCommunicateWithBots">Pass <em>True</em> to allow the bot to communicate with other bots in groups, private chats, and through business accounts or <em>False</em> to disallow it</param>
    /// <param name="callbackQueryMode">Mode in which the bot receives <a href="https://core.telegram.org/bots/api#callbackquery">callback queries</a> from buttons in messages sent by the bot. Must be one of “default” (the field <em>message</em> is always used and contains an <see cref="InaccessibleMessage"/> if the message is inaccessible to the bot), “auto” (the field <em>inline_message_id</em> is used instead of the field <em>message</em> if the message is inaccessible to the bot; the field <em>message</em> can still contain an inaccessible message if the message has just been deleted), or “inline” (the field <em>inline_message_id</em> is always used instead of the field <em>message</em>).</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetMySettings(this ITelegramBotClient client, bool? supportsInlineQueries = null, string? inlineQueryPlaceholder = null, bool? needsInlineQueryLocation = null, int? inlineFeedbackShareDenominator = null, bool? canJoinGroups = null, bool? canReadAllGroupMessages = null, bool? canConnectToBusiness = null, bool? canManageBots = null, bool? supportsGuestQueries = null, bool? supportsJoinRequestQueries = null, bool? hasTopicsEnabled = null, bool? allowsUsersToCreateTopics = null, bool? hasTopicSidebar = null, bool? canCommunicateWithBots = null, string? callbackQueryMode = null) =>
        client.SetMySettingsAsync(supportsInlineQueries, inlineQueryPlaceholder, needsInlineQueryLocation, inlineFeedbackShareDenominator, canJoinGroups, canReadAllGroupMessages, canConnectToBusiness, canManageBots, supportsGuestQueries, supportsJoinRequestQueries, hasTopicsEnabled, allowsUsersToCreateTopics, hasTopicSidebar, canCommunicateWithBots, callbackQueryMode).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change settings of the bot. Settings that aren't specified remain unchanged. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="supportsInlineQueries">Pass <em>True</em> to enable <a href="https://core.telegram.org/bots/api#inline-mode">inline mode</a> for the bot or <em>False</em> to disable it</param>
    /// <param name="inlineQueryPlaceholder">New placeholder for inline queries, which is shown in the input field after the bot's username. Pass an empty string to use the default placeholder.</param>
    /// <param name="needsInlineQueryLocation">Pass <em>True</em> to request the location of the user with every inline query to the bot or <em>False</em> to stop requesting it</param>
    /// <param name="inlineFeedbackShareDenominator">Denominator of the share of <a href="https://core.telegram.org/bots/api#choseninlineresult">chosen inline results</a> received by the bot; the bot receives 1 out of <em>inline_feedback_share_denominator</em> chosen results. Must be one of 1, 10, 100, or 1000. Pass 0 to stop receiving chosen inline results.</param>
    /// <param name="canJoinGroups">Pass <em>True</em> to allow adding the bot to groups or <em>False</em> to disallow it</param>
    /// <param name="canReadAllGroupMessages">Pass <em>True</em> to disable <a href="https://core.telegram.org/bots/features#privacy-mode">privacy mode</a> for the bot or <em>False</em> to enable it</param>
    /// <param name="canConnectToBusiness">Pass <em>True</em> to allow connecting the bot to user accounts to manage them or <em>False</em> to disallow it</param>
    /// <param name="canManageBots">Pass <em>True</em> to allow creating other bots that will be controlled by the bot or <em>False</em> to disallow it</param>
    /// <param name="supportsGuestQueries">Pass <em>True</em> to allow guest queries to the bot from chats it isn't a member of or <em>False</em> to disallow them</param>
    /// <param name="supportsJoinRequestQueries">Pass <em>True</em> to allow assigning the bot to process join request queries or <em>False</em> to disallow it</param>
    /// <param name="hasTopicsEnabled">Pass <em>True</em> to enable forum topic mode in private chats with the bot or <em>False</em> to disable it</param>
    /// <param name="allowsUsersToCreateTopics">Pass <em>True</em> to allow users to create and delete topics in private chats with the bot or <em>False</em> to disallow it</param>
    /// <param name="hasTopicSidebar">Pass <em>True</em> to show topics in private chats with the bot in a sidebar or <em>False</em> to stop showing them in a sidebar</param>
    /// <param name="canCommunicateWithBots">Pass <em>True</em> to allow the bot to communicate with other bots in groups, private chats, and through business accounts or <em>False</em> to disallow it</param>
    /// <param name="callbackQueryMode">Mode in which the bot receives <a href="https://core.telegram.org/bots/api#callbackquery">callback queries</a> from buttons in messages sent by the bot. Must be one of “default” (the field <em>message</em> is always used and contains an <see cref="InaccessibleMessage"/> if the message is inaccessible to the bot), “auto” (the field <em>inline_message_id</em> is used instead of the field <em>message</em> if the message is inaccessible to the bot; the field <em>message</em> can still contain an inaccessible message if the message has just been deleted), or “inline” (the field <em>inline_message_id</em> is always used instead of the field <em>message</em>).</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetMySettingsAsync(this ITelegramBotClient client, bool? supportsInlineQueries = null, string? inlineQueryPlaceholder = null, bool? needsInlineQueryLocation = null, int? inlineFeedbackShareDenominator = null, bool? canJoinGroups = null, bool? canReadAllGroupMessages = null, bool? canConnectToBusiness = null, bool? canManageBots = null, bool? supportsGuestQueries = null, bool? supportsJoinRequestQueries = null, bool? hasTopicsEnabled = null, bool? allowsUsersToCreateTopics = null, bool? hasTopicSidebar = null, bool? canCommunicateWithBots = null, string? callbackQueryMode = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (supportsInlineQueries is not null)
        {
            args.Add(PropertyNames.SupportsInlineQueries, supportsInlineQueries);
        }
        if (inlineQueryPlaceholder is not null)
        {
            args.Add(PropertyNames.InlineQueryPlaceholder, inlineQueryPlaceholder);
        }
        if (needsInlineQueryLocation is not null)
        {
            args.Add(PropertyNames.NeedsInlineQueryLocation, needsInlineQueryLocation);
        }
        if (inlineFeedbackShareDenominator is not null)
        {
            args.Add(PropertyNames.InlineFeedbackShareDenominator, inlineFeedbackShareDenominator);
        }
        if (canJoinGroups is not null)
        {
            args.Add(PropertyNames.CanJoinGroups, canJoinGroups);
        }
        if (canReadAllGroupMessages is not null)
        {
            args.Add(PropertyNames.CanReadAllGroupMessages, canReadAllGroupMessages);
        }
        if (canConnectToBusiness is not null)
        {
            args.Add(PropertyNames.CanConnectToBusiness, canConnectToBusiness);
        }
        if (canManageBots is not null)
        {
            args.Add(PropertyNames.CanManageBots, canManageBots);
        }
        if (supportsGuestQueries is not null)
        {
            args.Add(PropertyNames.SupportsGuestQueries, supportsGuestQueries);
        }
        if (supportsJoinRequestQueries is not null)
        {
            args.Add(PropertyNames.SupportsJoinRequestQueries, supportsJoinRequestQueries);
        }
        if (hasTopicsEnabled is not null)
        {
            args.Add(PropertyNames.HasTopicsEnabled, hasTopicsEnabled);
        }
        if (allowsUsersToCreateTopics is not null)
        {
            args.Add(PropertyNames.AllowsUsersToCreateTopics, allowsUsersToCreateTopics);
        }
        if (hasTopicSidebar is not null)
        {
            args.Add(PropertyNames.HasTopicSidebar, hasTopicSidebar);
        }
        if (canCommunicateWithBots is not null)
        {
            args.Add(PropertyNames.CanCommunicateWithBots, canCommunicateWithBots);
        }
        if (callbackQueryMode is not null)
        {
            args.Add(PropertyNames.CallbackQueryMode, callbackQueryMode);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetMySettings, args, cancellationToken);
    }
}
