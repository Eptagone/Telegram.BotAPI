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
    /// Edits a story previously posted by the bot on behalf of a managed business account. Requires the <em>can_manage_stories</em> business bot right. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditStory" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Story EditStory(this ITelegramBotClient client, EditStoryArgs args) =>
        client.EditStoryAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Edits a story previously posted by the bot on behalf of a managed business account. Requires the <em>can_manage_stories</em> business bot right. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditStory" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Story> EditStoryAsync(this ITelegramBotClient client, EditStoryArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<Story>(MethodNames.EditStory, args, cancellationToken);
    }

    /// <summary>
    /// Edits a story previously posted by the bot on behalf of a managed business account. Requires the <em>can_manage_stories</em> business bot right. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="storyId">Unique identifier of the story to edit</param>
    /// <param name="content">Content of the story</param>
    /// <param name="caption">Caption of the story, 0-2048 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the story caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="areas">A JSON-serialized list of clickable areas to be shown on the story</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Story EditStory(this ITelegramBotClient client, string businessConnectionId, int storyId, InputStoryContent content, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, IEnumerable<StoryArea>? areas = null) =>
        client.EditStoryAsync(businessConnectionId, storyId, content, caption, parseMode, captionEntities, areas).GetAwaiter().GetResult();

    /// <summary>
    /// Edits a story previously posted by the bot on behalf of a managed business account. Requires the <em>can_manage_stories</em> business bot right. Returns <see cref="Story"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="storyId">Unique identifier of the story to edit</param>
    /// <param name="content">Content of the story</param>
    /// <param name="caption">Caption of the story, 0-2048 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the story caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="areas">A JSON-serialized list of clickable areas to be shown on the story</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Story> EditStoryAsync(this ITelegramBotClient client, string businessConnectionId, int storyId, InputStoryContent content, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, IEnumerable<StoryArea>? areas = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.StoryId, storyId },
            { PropertyNames.Content, content ?? throw new ArgumentNullException(nameof(content)) }
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

        return client.CallMethodAsync<Story>(MethodNames.EditStory, args, cancellationToken);
    }
}
