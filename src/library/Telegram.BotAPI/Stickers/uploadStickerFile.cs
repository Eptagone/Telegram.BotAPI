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
    /// Use this method to upload a file with a sticker for later use in the <a href="https://core.telegram.org/bots/api#createnewstickerset">createNewStickerSet</a>, <a href="https://core.telegram.org/bots/api#addstickertoset">addStickerToSet</a>, or <a href="https://core.telegram.org/bots/api#replacestickerinset">replaceStickerInSet</a> methods (the file can be used multiple times). Returns the uploaded <see cref="File"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "UploadStickerFile" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static File UploadStickerFile(this ITelegramBotClient client, UploadStickerFileArgs args) =>
        client.UploadStickerFileAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to upload a file with a sticker for later use in the <a href="https://core.telegram.org/bots/api#createnewstickerset">createNewStickerSet</a>, <a href="https://core.telegram.org/bots/api#addstickertoset">addStickerToSet</a>, or <a href="https://core.telegram.org/bots/api#replacestickerinset">replaceStickerInSet</a> methods (the file can be used multiple times). Returns the uploaded <see cref="File"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "UploadStickerFile" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<File> UploadStickerFileAsync(this ITelegramBotClient client, UploadStickerFileArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<File>(MethodNames.UploadStickerFile, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to upload a file with a sticker for later use in the <a href="https://core.telegram.org/bots/api#createnewstickerset">createNewStickerSet</a>, <a href="https://core.telegram.org/bots/api#addstickertoset">addStickerToSet</a>, or <a href="https://core.telegram.org/bots/api#replacestickerinset">replaceStickerInSet</a> methods (the file can be used multiple times). Returns the uploaded <see cref="File"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of sticker file owner</param>
    /// <param name="sticker">A file with the sticker in .WEBP, .PNG, .TGS, or .WEBM format. See <a href="/stickers"></a><a href="https://core.telegram.org/stickers">https://core.telegram.org/stickers</a> for technical requirements. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="stickerFormat">Format of the sticker, must be one of “static”, “animated”, “video”</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static File UploadStickerFile(this ITelegramBotClient client, long userId, InputFile sticker, string stickerFormat) =>
        client.UploadStickerFileAsync(userId, sticker, stickerFormat).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to upload a file with a sticker for later use in the <a href="https://core.telegram.org/bots/api#createnewstickerset">createNewStickerSet</a>, <a href="https://core.telegram.org/bots/api#addstickertoset">addStickerToSet</a>, or <a href="https://core.telegram.org/bots/api#replacestickerinset">replaceStickerInSet</a> methods (the file can be used multiple times). Returns the uploaded <see cref="File"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of sticker file owner</param>
    /// <param name="sticker">A file with the sticker in .WEBP, .PNG, .TGS, or .WEBM format. See <a href="/stickers"></a><a href="https://core.telegram.org/stickers">https://core.telegram.org/stickers</a> for technical requirements. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="stickerFormat">Format of the sticker, must be one of “static”, “animated”, “video”</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<File> UploadStickerFileAsync(this ITelegramBotClient client, long userId, InputFile sticker, string stickerFormat, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.Sticker, sticker ?? throw new ArgumentNullException(nameof(sticker)) },
            { PropertyNames.StickerFormat, stickerFormat ?? throw new ArgumentNullException(nameof(stickerFormat)) }
        };

        return client.CallMethodAsync<File>(MethodNames.UploadStickerFile, args, cancellationToken);
    }
}
