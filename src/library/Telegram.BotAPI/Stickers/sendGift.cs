// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class StickersExtensions
{
    /// <summary>
    /// Sends a gift to the given user. The gift can't be converted to Telegram Stars by the user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendGift" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendGift(this ITelegramBotClient client, SendGiftArgs args) =>
        client.SendGiftAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Sends a gift to the given user. The gift can't be converted to Telegram Stars by the user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendGift" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendGiftAsync(this ITelegramBotClient client, SendGiftArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SendGift, args, cancellationToken);
    }

    /// <summary>
    /// Sends a gift to the given user. The gift can't be converted to Telegram Stars by the user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user that will receive the gift</param>
    /// <param name="giftId">Identifier of the gift</param>
    /// <param name="payForUpgrade">Pass <em>True</em> to pay for the gift upgrade from the bot's balance, thereby making the upgrade free for the receiver</param>
    /// <param name="text">Text that will be shown along with the gift; 0-255 characters</param>
    /// <param name="textParseMode">Mode for parsing entities in the text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <param name="textEntities">A JSON-serialized list of special entities that appear in the gift text. It can be specified instead of <em>text_parse_mode</em>. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendGift(this ITelegramBotClient client, long userId, string giftId, bool? payForUpgrade = null, string? text = null, string? textParseMode = null, IEnumerable<MessageEntity>? textEntities = null) =>
        client.SendGiftAsync(userId, giftId, payForUpgrade, text, textParseMode, textEntities).GetAwaiter().GetResult();

    /// <summary>
    /// Sends a gift to the given user. The gift can't be converted to Telegram Stars by the user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user that will receive the gift</param>
    /// <param name="giftId">Identifier of the gift</param>
    /// <param name="payForUpgrade">Pass <em>True</em> to pay for the gift upgrade from the bot's balance, thereby making the upgrade free for the receiver</param>
    /// <param name="text">Text that will be shown along with the gift; 0-255 characters</param>
    /// <param name="textParseMode">Mode for parsing entities in the text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <param name="textEntities">A JSON-serialized list of special entities that appear in the gift text. It can be specified instead of <em>text_parse_mode</em>. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendGiftAsync(this ITelegramBotClient client, long userId, string giftId, bool? payForUpgrade = null, string? text = null, string? textParseMode = null, IEnumerable<MessageEntity>? textEntities = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.GiftId, giftId ?? throw new ArgumentNullException(nameof(giftId)) }
        };
        if (payForUpgrade is not null)
        {
            args.Add(PropertyNames.PayForUpgrade, payForUpgrade);
        }
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

        return client.CallMethodAsync<bool>(MethodNames.SendGift, args, cancellationToken);
    }
}
