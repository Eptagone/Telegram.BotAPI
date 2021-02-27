// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to change the list of the bot's commands. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="commands">A list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetMyCommands(this BotClient bot, params BotCommand[] commands)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (commands == default)
            {
                throw new ArgumentNullException(nameof(commands));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteStartArray("commands");
            foreach (var cmd in commands)
            {
                if (string.IsNullOrEmpty(cmd.Command) || string.IsNullOrEmpty(cmd.Description))
                {
                    throw new ArgumentNullException($"{nameof(commands)} properties can't be null");
                }

                json.WriteStartObject();
                json.WriteString(PropertyNames.Command, cmd.Command);
                json.WriteString(PropertyNames.Description, cmd.Description);
                json.WriteEndObject();
            }
            json.WriteEndArray();
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.SetMyCommands, stream);
        }
        /// <summary>Use this method to change the list of the bot's commands. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="commands">A list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetMyCommands(this BotClient bot, IEnumerable<BotCommand> commands)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (commands == default)
            {
                throw new ArgumentNullException(nameof(commands));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteStartArray("commands");
            foreach (var cmd in commands)
            {
                if (string.IsNullOrEmpty(cmd.Command) || string.IsNullOrEmpty(cmd.Description))
                {
                    throw new ArgumentNullException($"{nameof(commands)} properties can't be null");
                }

                json.WriteStartObject();
                json.WriteString(PropertyNames.Command, cmd.Command);
                json.WriteString(PropertyNames.Description, cmd.Description);
                json.WriteEndObject();
            }
            json.WriteEndArray();
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.SetMyCommands, stream);
        }
        /// <summary>Use this method to change the list of the bot's commands. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="commands">A list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetMyCommandsAsync(this BotClient bot, IEnumerable<BotCommand> commands, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (commands == default)
            {
                throw new ArgumentNullException(nameof(commands));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteStartArray("commands");
            foreach (var cmd in commands)
            {
                if (string.IsNullOrEmpty(cmd.Command) || string.IsNullOrEmpty(cmd.Description))
                {
                    throw new ArgumentNullException($"{nameof(commands)} properties can't be null");
                }

                json.WriteStartObject();
                json.WriteString(PropertyNames.Command, cmd.Command);
                json.WriteString(PropertyNames.Description, cmd.Description);
                json.WriteEndObject();
            }
            json.WriteEndArray();
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.SetMyCommands, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
