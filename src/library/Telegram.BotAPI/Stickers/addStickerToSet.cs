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
    /// Use this method to add a new sticker to a set created by the bot. Emoji sticker sets can have up to 200 stickers. Other sticker sets can have up to 120 stickers. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AddStickerToSet" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AddStickerToSet(this ITelegramBotClient client, AddStickerToSetArgs args) =>
        client.AddStickerToSetAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to add a new sticker to a set created by the bot. Emoji sticker sets can have up to 200 stickers. Other sticker sets can have up to 120 stickers. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AddStickerToSet" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AddStickerToSetAsync(this ITelegramBotClient client, AddStickerToSetArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.AddStickerToSet, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to add a new sticker to a set created by the bot. Emoji sticker sets can have up to 200 stickers. Other sticker sets can have up to 120 stickers. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of sticker set owner</param>
    /// <param name="name">Sticker set name</param>
    /// <param name="sticker">A JSON-serialized object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.</param>
    /// <param name="files">The files to upload.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AddStickerToSet(this ITelegramBotClient client, long userId, string name, InputSticker sticker, IDictionary<string, InputFile>? files = null) =>
        client.AddStickerToSetAsync(userId, name, sticker, files).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to add a new sticker to a set created by the bot. Emoji sticker sets can have up to 200 stickers. Other sticker sets can have up to 120 stickers. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of sticker set owner</param>
    /// <param name="name">Sticker set name</param>
    /// <param name="sticker">A JSON-serialized object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.</param>
    /// <param name="files">The files to upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AddStickerToSetAsync(this ITelegramBotClient client, long userId, string name, InputSticker sticker, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)) },
            { PropertyNames.Sticker, sticker ?? throw new ArgumentNullException(nameof(sticker)) }
        };
        if (files is not null)
        {
            foreach (var file in files)
            {
                args.Add(file.Key, file.Value);
            }
        }

        return client.CallMethodAsync<bool>(MethodNames.AddStickerToSet, args, cancellationToken);
    }
}
