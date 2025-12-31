// Copyright (c) 2025 Quetzal Rivera.
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
    /// Reposts a story on behalf of a business account from another business account. Both business accounts must be managed by the same bot, and the story on the source account must have been posted (or reposted) by the bot. Requires the <em>can_manage_stories</em> business bot right for both business accounts. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "RepostStory" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Story RepostStory(this ITelegramBotClient client, RepostStoryArgs args) =>
        client.RepostStoryAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Reposts a story on behalf of a business account from another business account. Both business accounts must be managed by the same bot, and the story on the source account must have been posted (or reposted) by the bot. Requires the <em>can_manage_stories</em> business bot right for both business accounts. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "RepostStory" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Story> RepostStoryAsync(this ITelegramBotClient client, RepostStoryArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<Story>(MethodNames.RepostStory, args, cancellationToken);
    }

    /// <summary>
    /// Reposts a story on behalf of a business account from another business account. Both business accounts must be managed by the same bot, and the story on the source account must have been posted (or reposted) by the bot. Requires the <em>can_manage_stories</em> business bot right for both business accounts. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="fromChatId">Unique identifier of the chat which posted the story that should be reposted</param>
    /// <param name="fromStoryId">Unique identifier of the story that should be reposted</param>
    /// <param name="activePeriod">Period after which the story is moved to the archive, in seconds; must be one of <em>6 * 3600</em>, <em>12 * 3600</em>, <em>86400</em>, or <em>2 * 86400</em></param>
    /// <param name="postToChatPage">Pass <em>True</em> to keep the story accessible after it expires</param>
    /// <param name="protectContent">Pass <em>True</em> if the content of the story must be protected from forwarding and screenshotting</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Story RepostStory(this ITelegramBotClient client, string businessConnectionId, long fromChatId, int fromStoryId, int activePeriod, bool? postToChatPage = null, bool? protectContent = null) =>
        client.RepostStoryAsync(businessConnectionId, fromChatId, fromStoryId, activePeriod, postToChatPage, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Reposts a story on behalf of a business account from another business account. Both business accounts must be managed by the same bot, and the story on the source account must have been posted (or reposted) by the bot. Requires the <em>can_manage_stories</em> business bot right for both business accounts. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="fromChatId">Unique identifier of the chat which posted the story that should be reposted</param>
    /// <param name="fromStoryId">Unique identifier of the story that should be reposted</param>
    /// <param name="activePeriod">Period after which the story is moved to the archive, in seconds; must be one of <em>6 * 3600</em>, <em>12 * 3600</em>, <em>86400</em>, or <em>2 * 86400</em></param>
    /// <param name="postToChatPage">Pass <em>True</em> to keep the story accessible after it expires</param>
    /// <param name="protectContent">Pass <em>True</em> if the content of the story must be protected from forwarding and screenshotting</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Story> RepostStoryAsync(this ITelegramBotClient client, string businessConnectionId, long fromChatId, int fromStoryId, int activePeriod, bool? postToChatPage = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.FromChatId, fromChatId },
            { PropertyNames.FromStoryId, fromStoryId },
            { PropertyNames.ActivePeriod, activePeriod }
        };
        if (postToChatPage is not null)
        {
            args.Add(PropertyNames.PostToChatPage, postToChatPage);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }

        return client.CallMethodAsync<Story>(MethodNames.RepostStory, args, cancellationToken);
    }
}
