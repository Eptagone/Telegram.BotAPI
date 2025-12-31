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
    /// Sends a gift to the given user or channel chat. The gift can't be converted to Telegram Stars by the receiver. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendGift" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendGift(this ITelegramBotClient client, SendGiftArgs args) =>
        client.SendGiftAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Sends a gift to the given user or channel chat. The gift can't be converted to Telegram Stars by the receiver. Returns <em>True</em> on success.
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
    /// Sends a gift to the given user or channel chat. The gift can't be converted to Telegram Stars by the receiver. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="giftId">Identifier of the gift; limited gifts can't be sent to channel chats</param>
    /// <param name="userId">Required if <em>chat_id</em> is not specified. Unique identifier of the target user who will receive the gift.</param>
    /// <param name="chatId">Required if <em>user_id</em> is not specified. Unique identifier for the chat or username of the channel (in the format <em>@channelusername</em>) that will receive the gift.</param>
    /// <param name="payForUpgrade">Pass <em>True</em> to pay for the gift upgrade from the bot's balance, thereby making the upgrade free for the receiver</param>
    /// <param name="text">Text that will be shown along with the gift; 0-128 characters</param>
    /// <param name="textParseMode">Mode for parsing entities in the text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <param name="textEntities">A JSON-serialized list of special entities that appear in the gift text. It can be specified instead of <em>text_parse_mode</em>. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendGift(this ITelegramBotClient client, string giftId, long? userId = null, long? chatId = null, bool? payForUpgrade = null, string? text = null, string? textParseMode = null, IEnumerable<MessageEntity>? textEntities = null) =>
        client.SendGiftAsync(giftId, userId, chatId, payForUpgrade, text, textParseMode, textEntities).GetAwaiter().GetResult();

    /// <summary>
    /// Sends a gift to the given user or channel chat. The gift can't be converted to Telegram Stars by the receiver. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="giftId">Identifier of the gift; limited gifts can't be sent to channel chats</param>
    /// <param name="userId">Required if <em>chat_id</em> is not specified. Unique identifier of the target user who will receive the gift.</param>
    /// <param name="chatId">Required if <em>user_id</em> is not specified. Unique identifier for the chat or username of the channel (in the format <em>@channelusername</em>) that will receive the gift.</param>
    /// <param name="payForUpgrade">Pass <em>True</em> to pay for the gift upgrade from the bot's balance, thereby making the upgrade free for the receiver</param>
    /// <param name="text">Text that will be shown along with the gift; 0-128 characters</param>
    /// <param name="textParseMode">Mode for parsing entities in the text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <param name="textEntities">A JSON-serialized list of special entities that appear in the gift text. It can be specified instead of <em>text_parse_mode</em>. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendGiftAsync(this ITelegramBotClient client, string giftId, long? userId = null, long? chatId = null, bool? payForUpgrade = null, string? text = null, string? textParseMode = null, IEnumerable<MessageEntity>? textEntities = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.GiftId, giftId ?? throw new ArgumentNullException(nameof(giftId)) }
        };
        if (userId is not null)
        {
            args.Add(PropertyNames.UserId, userId);
        }
        if (chatId is not null)
        {
            args.Add(PropertyNames.ChatId, chatId);
        }
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
