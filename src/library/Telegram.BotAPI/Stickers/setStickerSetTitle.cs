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
    /// Use this method to set the title of a created sticker set. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">Sticker set name</param>
    /// <param name="title">Sticker set title, 1-64 characters</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetStickerSetTitle(this ITelegramBotClient client, string name, string title) =>
        client.SetStickerSetTitleAsync(name, title).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to set the title of a created sticker set. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">Sticker set name</param>
    /// <param name="title">Sticker set title, 1-64 characters</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetStickerSetTitleAsync(this ITelegramBotClient client, string name, string title, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)) },
            { PropertyNames.Title, title ?? throw new ArgumentNullException(nameof(title)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.SetStickerSetTitle, args, cancellationToken);
    }
}
