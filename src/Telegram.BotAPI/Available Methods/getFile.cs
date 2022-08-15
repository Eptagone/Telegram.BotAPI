// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using File = Telegram.BotAPI.AvailableTypes.File;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="fileId">File identifier to get info about.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="File"/></returns>
        public static File GetFile(this BotClient bot, string fileId)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteString(PropertyNames.FileId, fileId);
            json.WriteEndObject();
            json.Flush();
            json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<File>(MethodNames.GetFile, stream);
        }

        /// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="fileId">File identifier to get info about.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="File"/></returns>
        public static async Task<File> GetFileAsync(this BotClient bot, string fileId,
            [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteString(PropertyNames.FileId, fileId);
            json.WriteEndObject();
            json.Flush();
            json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<File>(MethodNames.GetFile, stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to get byte array of the file using the file path</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="filePath">File path to get byte array of.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="T:System.Net.Http.HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
        /// <returns><see cref="T:byte[]"/></returns>
        public static byte[] GetFileByteArray(this BotClient bot, string filePath)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var request = $"https://api.telegram.org/bot{bot.Token}/{filePath}";
            using var httpClient = new HttpClient();
            return httpClient.GetByteArrayAsync(request).Result;
        }
        
        
        /// <summary>Use this method to get byte array of the file using the file path</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="filePath">File path to get byte array of.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="T:System.Net.Http.HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
        /// <returns><see cref="T:byte[]"/></returns>
        public static async Task<byte[]> GetFileByteArrayAsync(this BotClient bot, string filePath)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var request = $"https://api.telegram.org/file/bot{bot.Token}/{filePath}";
            using var httpClient = new HttpClient();
            return await httpClient.GetByteArrayAsync(request);
        }
    }
}
