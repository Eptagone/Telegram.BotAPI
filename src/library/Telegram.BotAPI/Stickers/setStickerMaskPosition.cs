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
    /// Use this method to change the <a href="https://core.telegram.org/bots/api#maskposition">mask position</a> of a mask sticker. The sticker must belong to a sticker set that was created by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetStickerMaskPosition" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetStickerMaskPosition(this ITelegramBotClient client, SetStickerMaskPositionArgs args) =>
        client.SetStickerMaskPositionAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the <a href="https://core.telegram.org/bots/api#maskposition">mask position</a> of a mask sticker. The sticker must belong to a sticker set that was created by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetStickerMaskPosition" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetStickerMaskPositionAsync(this ITelegramBotClient client, SetStickerMaskPositionArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SetStickerMaskPosition, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to change the <a href="https://core.telegram.org/bots/api#maskposition">mask position</a> of a mask sticker. The sticker must belong to a sticker set that was created by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="sticker">File identifier of the sticker</param>
    /// <param name="maskPosition">A JSON-serialized object with the position where the mask should be placed on faces. Omit the parameter to remove the mask position.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetStickerMaskPosition(this ITelegramBotClient client, string sticker, MaskPosition? maskPosition = null) =>
        client.SetStickerMaskPositionAsync(sticker, maskPosition).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the <a href="https://core.telegram.org/bots/api#maskposition">mask position</a> of a mask sticker. The sticker must belong to a sticker set that was created by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="sticker">File identifier of the sticker</param>
    /// <param name="maskPosition">A JSON-serialized object with the position where the mask should be placed on faces. Omit the parameter to remove the mask position.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetStickerMaskPositionAsync(this ITelegramBotClient client, string sticker, MaskPosition? maskPosition = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.Sticker, sticker ?? throw new ArgumentNullException(nameof(sticker)) }
        };
        if (maskPosition is not null)
        {
            args.Add(PropertyNames.MaskPosition, maskPosition);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetStickerMaskPosition, args, cancellationToken);
    }
}
