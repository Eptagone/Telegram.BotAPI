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
    /// Use this method to get a sticker set. On success, a <see cref="StickerSet"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">Name of the sticker set</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static StickerSet GetStickerSet(this ITelegramBotClient client, string name) =>
        client.GetStickerSetAsync(name).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get a sticker set. On success, a <see cref="StickerSet"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">Name of the sticker set</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<StickerSet> GetStickerSetAsync(this ITelegramBotClient client, string name, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)) }
        };

        return client.CallMethodAsync<StickerSet>(MethodNames.GetStickerSet, args, cancellationToken);
    }
}
