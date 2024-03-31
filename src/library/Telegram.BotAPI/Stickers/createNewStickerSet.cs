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
    /// Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "CreateNewStickerSet" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool CreateNewStickerSet(this ITelegramBotClient client, CreateNewStickerSetArgs args) =>
        client.CreateNewStickerSetAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "CreateNewStickerSet" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> CreateNewStickerSetAsync(this ITelegramBotClient client, CreateNewStickerSetArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.CreateNewStickerSet, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of created sticker set owner</param>
    /// <param name="name">Short name of sticker set, to be used in <em>t.me/addstickers/</em> URLs (e.g., <em>animals</em>). Can contain only English letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in <em>"_by_&lt;bot_username&gt;"</em>. <em>&lt;bot_username&gt;</em> is case insensitive. 1-64 characters.</param>
    /// <param name="title">Sticker set title, 1-64 characters</param>
    /// <param name="stickers">A JSON-serialized list of 1-50 initial stickers to be added to the sticker set</param>
    /// <param name="stickerType">Type of stickers in the set, pass “regular”, “mask”, or “custom_emoji”. By default, a regular sticker set is created.</param>
    /// <param name="needsRepainting">Pass <em>True</em> if stickers in the sticker set must be repainted to the color of text when used in messages, the accent color if used as emoji status, white on chat photos, or another appropriate color based on context; for custom emoji sticker sets only</param>
    /// <param name="files">The files to upload.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool CreateNewStickerSet(this ITelegramBotClient client, long userId, string name, string title, IEnumerable<InputSticker> stickers, string? stickerType = null, bool? needsRepainting = null, IDictionary<string, InputFile>? files = null) =>
        client.CreateNewStickerSetAsync(userId, name, title, stickers, stickerType, needsRepainting, files).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of created sticker set owner</param>
    /// <param name="name">Short name of sticker set, to be used in <em>t.me/addstickers/</em> URLs (e.g., <em>animals</em>). Can contain only English letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in <em>"_by_&lt;bot_username&gt;"</em>. <em>&lt;bot_username&gt;</em> is case insensitive. 1-64 characters.</param>
    /// <param name="title">Sticker set title, 1-64 characters</param>
    /// <param name="stickers">A JSON-serialized list of 1-50 initial stickers to be added to the sticker set</param>
    /// <param name="stickerType">Type of stickers in the set, pass “regular”, “mask”, or “custom_emoji”. By default, a regular sticker set is created.</param>
    /// <param name="needsRepainting">Pass <em>True</em> if stickers in the sticker set must be repainted to the color of text when used in messages, the accent color if used as emoji status, white on chat photos, or another appropriate color based on context; for custom emoji sticker sets only</param>
    /// <param name="files">The files to upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> CreateNewStickerSetAsync(this ITelegramBotClient client, long userId, string name, string title, IEnumerable<InputSticker> stickers, string? stickerType = null, bool? needsRepainting = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)) },
            { PropertyNames.Title, title ?? throw new ArgumentNullException(nameof(title)) },
            { PropertyNames.Stickers, stickers ?? throw new ArgumentNullException(nameof(stickers)) }
        };
        if (stickerType is not null)
        {
            args.Add(PropertyNames.StickerType, stickerType);
        }
        if (needsRepainting is not null)
        {
            args.Add(PropertyNames.NeedsRepainting, needsRepainting);
        }
        if (files is not null)
        {
            foreach (var file in files)
            {
                args.Add(file.Key, file.Value);
            }
        }

        return client.CallMethodAsync<bool>(MethodNames.CreateNewStickerSet, args, cancellationToken);
    }
}
