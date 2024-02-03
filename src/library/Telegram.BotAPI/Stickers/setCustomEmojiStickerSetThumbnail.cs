// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class StickersExtensions
{
    /// <summary>
    /// Use this method to set the thumbnail of a custom emoji sticker set. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">Sticker set name</param>
    /// <param name="customEmojiId">Custom emoji identifier of a sticker from the sticker set; pass an empty string to drop the thumbnail and use the first sticker as the thumbnail.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetCustomEmojiStickerSetThumbnail(this ITelegramBotClient client, string name, string? customEmojiId = null) =>
        client.SetCustomEmojiStickerSetThumbnailAsync(name, customEmojiId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to set the thumbnail of a custom emoji sticker set. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">Sticker set name</param>
    /// <param name="customEmojiId">Custom emoji identifier of a sticker from the sticker set; pass an empty string to drop the thumbnail and use the first sticker as the thumbnail.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetCustomEmojiStickerSetThumbnailAsync(this ITelegramBotClient client, string name, string? customEmojiId = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)) }
        };
        if (customEmojiId is not null)
        {
            args.Add(PropertyNames.CustomEmojiId, customEmojiId);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetCustomEmojiStickerSetThumbnail, args, cancellationToken);
    }
}
