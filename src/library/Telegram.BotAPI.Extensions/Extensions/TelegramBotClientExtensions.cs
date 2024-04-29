// Copyright (c) 2024 Quetzal Rivera.
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
    /// <param name="client">The Telegram Bot Client.</param>
    /// <param name="file">The File.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string? BuildFileDownloadLink(this ITelegramBotClient client, File file)
    {
        if (string.IsNullOrEmpty(file.FilePath))
        {
            return null;
        }

        return $"{client.Options.ServerAddress}/file/bot{client.Options.BotToken}/{file.FilePath}";
    }
}
