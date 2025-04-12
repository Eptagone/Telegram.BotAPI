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
    /// Gifts a Telegram Premium subscription to the given user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GiftPremiumSubscription" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool GiftPremiumSubscription(this ITelegramBotClient client, GiftPremiumSubscriptionArgs args) =>
        client.GiftPremiumSubscriptionAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Gifts a Telegram Premium subscription to the given user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GiftPremiumSubscription" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> GiftPremiumSubscriptionAsync(this ITelegramBotClient client, GiftPremiumSubscriptionArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.GiftPremiumSubscription, args, cancellationToken);
    }

    /// <summary>
    /// Gifts a Telegram Premium subscription to the given user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user who will receive a Telegram Premium subscription</param>
    /// <param name="monthCount">Number of months the Telegram Premium subscription will be active for the user; must be one of 3, 6, or 12</param>
    /// <param name="starCount">Number of Telegram Stars to pay for the Telegram Premium subscription; must be 1000 for 3 months, 1500 for 6 months, and 2500 for 12 months</param>
    /// <param name="text">Text that will be shown along with the service message about the subscription; 0-128 characters</param>
    /// <param name="textParseMode">Mode for parsing entities in the text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <param name="textEntities">A JSON-serialized list of special entities that appear in the gift text. It can be specified instead of <em>text_parse_mode</em>. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool GiftPremiumSubscription(this ITelegramBotClient client, long userId, int monthCount, int starCount, string? text = null, string? textParseMode = null, IEnumerable<MessageEntity>? textEntities = null) =>
        client.GiftPremiumSubscriptionAsync(userId, monthCount, starCount, text, textParseMode, textEntities).GetAwaiter().GetResult();

    /// <summary>
    /// Gifts a Telegram Premium subscription to the given user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user who will receive a Telegram Premium subscription</param>
    /// <param name="monthCount">Number of months the Telegram Premium subscription will be active for the user; must be one of 3, 6, or 12</param>
    /// <param name="starCount">Number of Telegram Stars to pay for the Telegram Premium subscription; must be 1000 for 3 months, 1500 for 6 months, and 2500 for 12 months</param>
    /// <param name="text">Text that will be shown along with the service message about the subscription; 0-128 characters</param>
    /// <param name="textParseMode">Mode for parsing entities in the text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <param name="textEntities">A JSON-serialized list of special entities that appear in the gift text. It can be specified instead of <em>text_parse_mode</em>. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> GiftPremiumSubscriptionAsync(this ITelegramBotClient client, long userId, int monthCount, int starCount, string? text = null, string? textParseMode = null, IEnumerable<MessageEntity>? textEntities = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.MonthCount, monthCount },
            { PropertyNames.StarCount, starCount }
        };
        if (text is not null)
        {
            args.Add(PropertyNames.Text, text);
        }
        if (textParseMode is not null)
        {
            args.Add(PropertyNames.TextParseMode, textParseMode);
        }
        if (textEntities is not null)
        {
            args.Add(PropertyNames.TextEntities, textEntities);
        }

        return client.CallMethodAsync<bool>(MethodNames.GiftPremiumSubscription, args, cancellationToken);
    }
}
