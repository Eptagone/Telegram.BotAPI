// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Posts a story on behalf of a managed business account. Requires the <em>can_manage_stories</em> business bot right. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "PostStory" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Story PostStory(this ITelegramBotClient client, PostStoryArgs args) =>
        client.PostStoryAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Posts a story on behalf of a managed business account. Requires the <em>can_manage_stories</em> business bot right. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "PostStory" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Story> PostStoryAsync(this ITelegramBotClient client, PostStoryArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<Story>(MethodNames.PostStory, args, cancellationToken);
    }

    /// <summary>
    /// Posts a story on behalf of a managed business account. Requires the <em>can_manage_stories</em> business bot right. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="content">Content of the story</param>
    /// <param name="activePeriod">Period after which the story is moved to the archive, in seconds; must be one of <em>6 * 3600</em>, <em>12 * 3600</em>, <em>86400</em>, or <em>2 * 86400</em></param>
    /// <param name="caption">Caption of the story, 0-2048 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the story caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="areas">A JSON-serialized list of clickable areas to be shown on the story</param>
    /// <param name="postToChatPage">Pass <em>True</em> to keep the story accessible after it expires</param>
    /// <param name="protectContent">Pass <em>True</em> if the content of the story must be protected from forwarding and screenshotting</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Story PostStory(this ITelegramBotClient client, string businessConnectionId, InputStoryContent content, int activePeriod, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, IEnumerable<StoryArea>? areas = null, bool? postToChatPage = null, bool? protectContent = null) =>
        client.PostStoryAsync(businessConnectionId, content, activePeriod, caption, parseMode, captionEntities, areas, postToChatPage, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Posts a story on behalf of a managed business account. Requires the <em>can_manage_stories</em> business bot right. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="content">Content of the story</param>
    /// <param name="activePeriod">Period after which the story is moved to the archive, in seconds; must be one of <em>6 * 3600</em>, <em>12 * 3600</em>, <em>86400</em>, or <em>2 * 86400</em></param>
    /// <param name="caption">Caption of the story, 0-2048 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the story caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="areas">A JSON-serialized list of clickable areas to be shown on the story</param>
    /// <param name="postToChatPage">Pass <em>True</em> to keep the story accessible after it expires</param>
    /// <param name="protectContent">Pass <em>True</em> if the content of the story must be protected from forwarding and screenshotting</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Story> PostStoryAsync(this ITelegramBotClient client, string businessConnectionId, InputStoryContent content, int activePeriod, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, IEnumerable<StoryArea>? areas = null, bool? postToChatPage = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.Content, content ?? throw new ArgumentNullException(nameof(content)) },
            { PropertyNames.ActivePeriod, activePeriod }
        };
        if (caption is not null)
        {
            args.Add(PropertyNames.Caption, caption);
        }
        if (parseMode is not null)
        {
            args.Add(PropertyNames.ParseMode, parseMode);
        }
        if (captionEntities is not null)
        {
            args.Add(PropertyNames.CaptionEntities, captionEntities);
        }
        if (areas is not null)
        {
            args.Add(PropertyNames.Areas, areas);
        }
        if (postToChatPage is not null)
        {
            args.Add(PropertyNames.PostToChatPage, postToChatPage);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }

        return client.CallMethodAsync<Story>(MethodNames.PostStory, args, cancellationToken);
    }
}
