// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using File = Telegram.BotAPI.AvailableTypes.File;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Defines aditional methods for <see cref="ITelegramBotClient"/>.
/// </summary>
public static class TelegramBotClientExtensions
{
    /// <summary>
    /// Constructs the URL to download a Telegram File.
    /// </summary>
    /// <remarks>Don't use this method if you're using the TBA server with --local mode enabled.</remarks>
    /// <param name="client">The Telegram Bot Client.</param>
    /// <param name="file">The File.</param>
    /// <exception cref="ArgumentNullException"></exception>
    public static string? BuildFileDownloadLink(this ITelegramBotClient client, File file) =>
        client.BuildFileDownloadUri(file)?.AbsoluteUri;

    /// <summary>
    /// Constructs the URL to download a Telegram File using the format <c>https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt;</c>
    /// </summary>
    /// <remarks>
    /// <b>Note</b>: If you're using a local <b>TBAS (Telegram Bot API Server)</b> instance, this method will trim the bot folder (e.g. <c>/var/tbas/{BOT_TOKEN}</c>) from the file path and generate the URL accordingly. However, local TBAS doesn't support this kind of download urls. So, you'll need to configure your server to serve static files in that way in order to download files using this kind of URL.
    /// </remarks>
    /// <param name="client">The Telegram Bot Client instance.</param>
    /// <param name="file">The File.</param>
    /// <returns></returns>
    public static Uri? BuildFileDownloadUri(this ITelegramBotClient client, File file) =>
        string.IsNullOrEmpty(file.FilePath) ? null : client.BuildFileDownloadUri(file.FilePath!);

    /// <summary>
    /// Constructs the URL to download a Telegram File using the format <c>https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt;</c>
    /// </summary>
    /// <remarks>
    /// <b>Note</b>: If you're using a local <b>TBAS (Telegram Bot API Server)</b> instance, this method will trim the bot folder (e.g. <c>/var/tbas/{BOT_TOKEN}</c>) from the file path and generate the URL accordingly. However, local TBAS doesn't support this kind of download urls. So, you'll need to configure your server to serve static files in that way in order to download files using this kind of URL.
    /// </remarks>
    /// <param name="client">The Telegram Bot Client instance.</param>
    /// <param name="filePath">The file path.</param>
    /// <returns></returns>
    public static Uri BuildFileDownloadUri(this ITelegramBotClient client, string filePath)
    {
        var safePath = filePath;

        // Remove the bot token from the path
        var tokenIndex = safePath.IndexOf(
            client.Options.BotToken,
            StringComparison.InvariantCulture
        );
        if (tokenIndex != -1)
        {
            safePath = safePath.Substring(tokenIndex + client.Options.BotToken.Length);
        }
        safePath = safePath.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

        return new Uri(
            new Uri(client.Options.ServerAddress),
            Path.Combine($"/file/bot{client.Options.BotToken}", safePath)
        );
    }
}
