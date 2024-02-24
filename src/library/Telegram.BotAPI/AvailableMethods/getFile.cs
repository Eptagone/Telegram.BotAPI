// Copyright (c) 2024 Quetzal Rivera.
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
    /// Use this method to get basic information about a file and prepare it for downloading. For the moment, bots can download files of up to 20MB in size. On success, a <see cref="File"/> object is returned. The file can then be downloaded via the link <em>https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt;</em>, where <em>&lt;file_path&gt;</em> is taken from the response. It is guaranteed that the link will be valid for at least 1 hour. When the link expires, a new one can be requested by calling <a href="https://core.telegram.org/bots/api#getfile">getFile</a> again.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="fileId">File identifier to get information about</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static File GetFile(this ITelegramBotClient client, string fileId) =>
        client.GetFileAsync(fileId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get basic information about a file and prepare it for downloading. For the moment, bots can download files of up to 20MB in size. On success, a <see cref="File"/> object is returned. The file can then be downloaded via the link <em>https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt;</em>, where <em>&lt;file_path&gt;</em> is taken from the response. It is guaranteed that the link will be valid for at least 1 hour. When the link expires, a new one can be requested by calling <a href="https://core.telegram.org/bots/api#getfile">getFile</a> again.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="fileId">File identifier to get information about</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<File> GetFileAsync(this ITelegramBotClient client, string fileId, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.FileId, fileId ?? throw new ArgumentNullException(nameof(fileId)) }
        };

        return client.CallMethodAsync<File>(MethodNames.GetFile, args, cancellationToken);
    }
}
