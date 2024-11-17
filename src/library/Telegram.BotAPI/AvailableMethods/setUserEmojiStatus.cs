// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Changes the emoji status for a given user that previously allowed the bot to manage their emoji status via the Mini App method <a href="https://core.telegram.org/bots/webapps#initializing-mini-apps">requestEmojiStatusAccess</a>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="emojiStatusCustomEmojiId">Custom emoji identifier of the emoji status to set. Pass an empty string to remove the status.</param>
    /// <param name="emojiStatusExpirationDate">Expiration date of the emoji status, if any</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetUserEmojiStatus(this ITelegramBotClient client, long userId, string? emojiStatusCustomEmojiId = null, int? emojiStatusExpirationDate = null) =>
        client.SetUserEmojiStatusAsync(userId, emojiStatusCustomEmojiId, emojiStatusExpirationDate).GetAwaiter().GetResult();

    /// <summary>
    /// Changes the emoji status for a given user that previously allowed the bot to manage their emoji status via the Mini App method <a href="https://core.telegram.org/bots/webapps#initializing-mini-apps">requestEmojiStatusAccess</a>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="emojiStatusCustomEmojiId">Custom emoji identifier of the emoji status to set. Pass an empty string to remove the status.</param>
    /// <param name="emojiStatusExpirationDate">Expiration date of the emoji status, if any</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetUserEmojiStatusAsync(this ITelegramBotClient client, long userId, string? emojiStatusCustomEmojiId = null, int? emojiStatusExpirationDate = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId }
        };
        if (emojiStatusCustomEmojiId is not null)
        {
            args.Add(PropertyNames.EmojiStatusCustomEmojiId, emojiStatusCustomEmojiId);
        }
        if (emojiStatusExpirationDate is not null)
        {
            args.Add(PropertyNames.EmojiStatusExpirationDate, emojiStatusExpirationDate);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetUserEmojiStatus, args, cancellationToken);
    }
}
