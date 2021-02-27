// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.TelegramPassport
{
    /// <summary>Telegram Passport</summary>
    public static partial class TelegramPassportExtensions
    {
        /// <summary>Informs a user that some of the Telegram Passport elements they provided contains errors. The user will not be able to re-submit their Passport to you until the errors are fixed (the contents of the field for which you returned the error must change). Returns True on success.
        /// <para>Use this if the data submitted by the user doesn't satisfy the standards your service requires for any reason. For example, if a birthday date seems invalid, a submitted document is blurry, a scan shows evidence of tampering, etc. Supply some details in the error message to make sure the user knows how to correct the issues.</para></summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="userId">User identifier</param>
        /// <param name="errors">An array of <see cref="PassportElementError"/> describing the errors</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool SetPassportDataErrors(this BotClient bot, int userId, IEnumerable<PassportElementError> errors)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (errors == default)
            {
                throw new ArgumentNullException(nameof(errors));
            }

            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new Tools.PassportElementErrorJsonConverter());
            var args = new SetPassportDataErrorsArgs
            {
                UserId = userId,
                Errors = errors
            };
            var stream = new MemoryStream();
            var json = new Utf8JsonWriter(stream);
            JsonSerializer.Serialize(json, args, options);
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.SetPassportDataErrors, stream);
        }
        /// <summary>Informs a user that some of the Telegram Passport elements they provided contains errors. The user will not be able to re-submit their Passport to you until the errors are fixed (the contents of the field for which you returned the error must change). Returns True on success.
        /// <para>Use this if the data submitted by the user doesn't satisfy the standards your service requires for any reason. For example, if a birthday date seems invalid, a submitted document is blurry, a scan shows evidence of tampering, etc. Supply some details in the error message to make sure the user knows how to correct the issues.</para></summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="userId">User identifier</param>
        /// <param name="errors">An array of <see cref="PassportElementError"/> describing the errors</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> SetPassportDataErrorsAsync(
            this BotClient bot,
            int userId,
            IEnumerable<PassportElementError> errors,
            [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (errors == default)
            {
                throw new ArgumentNullException(nameof(errors));
            }

            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new Tools.PassportElementErrorJsonConverter());
            var args = new SetPassportDataErrorsArgs
            {
                UserId = userId,
                Errors = errors
            };
            var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, args, typeof(SetPassportDataErrorsArgs), options, cancellationToken: cancellationToken).ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.SetPassportDataErrors, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
