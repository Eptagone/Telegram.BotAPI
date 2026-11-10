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
    /// Verifies a chat <a href="https://telegram.org/verify#third-party-verification">on behalf of the organization</a> which is represented by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "VerifyChat" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool VerifyChat(this ITelegramBotClient client, VerifyChatArgs args) =>
        client.VerifyChatAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Verifies a chat <a href="https://telegram.org/verify#third-party-verification">on behalf of the organization</a> which is represented by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "VerifyChat" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> VerifyChatAsync(this ITelegramBotClient client, VerifyChatArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.VerifyChat, args, cancellationToken);
    }

    /// <summary>
    /// Verifies a chat <a href="https://telegram.org/verify#third-party-verification">on behalf of the organization</a> which is represented by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot, supergroup, or channel in the format <em>@username</em>. Channel direct messages chats can't be verified.</param>
    /// <param name="customDescription">Custom description for the verification; 0-70 characters. Must be empty if the organization isn't allowed to provide a custom verification description.</param>
    /// <param name="customDescriptionParseMode">Mode for parsing entities in the custom description. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Only “text_link” entities are supported.</param>
    /// <param name="customDescriptionEntities">A JSON-serialized list of special entities that appear in the custom description, which can be specified instead of <em>custom_description_parse_mode</em>. Only “text_link” entities are supported.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool VerifyChat(this ITelegramBotClient client, long chatId, string? customDescription = null, string? customDescriptionParseMode = null, IEnumerable<MessageEntity>? customDescriptionEntities = null) =>
        client.VerifyChatAsync(chatId, customDescription, customDescriptionParseMode, customDescriptionEntities).GetAwaiter().GetResult();

    /// <summary>
    /// Verifies a chat <a href="https://telegram.org/verify#third-party-verification">on behalf of the organization</a> which is represented by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot, supergroup, or channel in the format <em>@username</em>. Channel direct messages chats can't be verified.</param>
    /// <param name="customDescription">Custom description for the verification; 0-70 characters. Must be empty if the organization isn't allowed to provide a custom verification description.</param>
    /// <param name="customDescriptionParseMode">Mode for parsing entities in the custom description. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Only “text_link” entities are supported.</param>
    /// <param name="customDescriptionEntities">A JSON-serialized list of special entities that appear in the custom description, which can be specified instead of <em>custom_description_parse_mode</em>. Only “text_link” entities are supported.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> VerifyChatAsync(this ITelegramBotClient client, long chatId, string? customDescription = null, string? customDescriptionParseMode = null, IEnumerable<MessageEntity>? customDescriptionEntities = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId }
        };
        if (customDescription is not null)
        {
            args.Add(PropertyNames.CustomDescription, customDescription);
        }
        if (customDescriptionParseMode is not null)
        {
            args.Add(PropertyNames.CustomDescriptionParseMode, customDescriptionParseMode);
        }
        if (customDescriptionEntities is not null)
        {
            args.Add(PropertyNames.CustomDescriptionEntities, customDescriptionEntities);
        }

        return client.CallMethodAsync<bool>(MethodNames.VerifyChat, args, cancellationToken);
    }

    /// <summary>
    /// Verifies a chat <a href="https://telegram.org/verify#third-party-verification">on behalf of the organization</a> which is represented by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot, supergroup, or channel in the format <em>@username</em>. Channel direct messages chats can't be verified.</param>
    /// <param name="customDescription">Custom description for the verification; 0-70 characters. Must be empty if the organization isn't allowed to provide a custom verification description.</param>
    /// <param name="customDescriptionParseMode">Mode for parsing entities in the custom description. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Only “text_link” entities are supported.</param>
    /// <param name="customDescriptionEntities">A JSON-serialized list of special entities that appear in the custom description, which can be specified instead of <em>custom_description_parse_mode</em>. Only “text_link” entities are supported.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool VerifyChat(this ITelegramBotClient client, string chatId, string? customDescription = null, string? customDescriptionParseMode = null, IEnumerable<MessageEntity>? customDescriptionEntities = null) =>
        client.VerifyChatAsync(chatId, customDescription, customDescriptionParseMode, customDescriptionEntities).GetAwaiter().GetResult();

    /// <summary>
    /// Verifies a chat <a href="https://telegram.org/verify#third-party-verification">on behalf of the organization</a> which is represented by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot, supergroup, or channel in the format <em>@username</em>. Channel direct messages chats can't be verified.</param>
    /// <param name="customDescription">Custom description for the verification; 0-70 characters. Must be empty if the organization isn't allowed to provide a custom verification description.</param>
    /// <param name="customDescriptionParseMode">Mode for parsing entities in the custom description. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Only “text_link” entities are supported.</param>
    /// <param name="customDescriptionEntities">A JSON-serialized list of special entities that appear in the custom description, which can be specified instead of <em>custom_description_parse_mode</em>. Only “text_link” entities are supported.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> VerifyChatAsync(this ITelegramBotClient client, string chatId, string? customDescription = null, string? customDescriptionParseMode = null, IEnumerable<MessageEntity>? customDescriptionEntities = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) }
        };
        if (customDescription is not null)
        {
            args.Add(PropertyNames.CustomDescription, customDescription);
        }
        if (customDescriptionParseMode is not null)
        {
            args.Add(PropertyNames.CustomDescriptionParseMode, customDescriptionParseMode);
        }
        if (customDescriptionEntities is not null)
        {
            args.Add(PropertyNames.CustomDescriptionEntities, customDescriptionEntities);
        }

        return client.CallMethodAsync<bool>(MethodNames.VerifyChat, args, cancellationToken);
    }
}
