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
    /// Use this method to get information about custom emoji stickers by their identifiers. Returns an Array of <see cref="Sticker"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetCustomEmojiStickers" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<Sticker> GetCustomEmojiStickers(this ITelegramBotClient client, GetCustomEmojiStickersArgs args) =>
        client.GetCustomEmojiStickersAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get information about custom emoji stickers by their identifiers. Returns an Array of <see cref="Sticker"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetCustomEmojiStickers" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<Sticker>> GetCustomEmojiStickersAsync(this ITelegramBotClient client, GetCustomEmojiStickersArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<IEnumerable<Sticker>>(MethodNames.GetCustomEmojiStickers, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to get information about custom emoji stickers by their identifiers. Returns an Array of <see cref="Sticker"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="customEmojiIds">A JSON-serialized list of custom emoji identifiers. At most 200 custom emoji identifiers can be specified.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<Sticker> GetCustomEmojiStickers(this ITelegramBotClient client, IEnumerable<string> customEmojiIds) =>
        client.GetCustomEmojiStickersAsync(customEmojiIds).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get information about custom emoji stickers by their identifiers. Returns an Array of <see cref="Sticker"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="customEmojiIds">A JSON-serialized list of custom emoji identifiers. At most 200 custom emoji identifiers can be specified.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<Sticker>> GetCustomEmojiStickersAsync(this ITelegramBotClient client, IEnumerable<string> customEmojiIds, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.CustomEmojiIds, customEmojiIds ?? throw new ArgumentNullException(nameof(customEmojiIds)) }
        };

        return client.CallMethodAsync<IEnumerable<Sticker>>(MethodNames.GetCustomEmojiStickers, args, cancellationToken);
    }
}
