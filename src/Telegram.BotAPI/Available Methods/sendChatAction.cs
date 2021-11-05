// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method when you need to tell the user that something is happening on the bot's side. The status is set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status). Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="action">Type of action to broadcast. Choose one, depending on what the user is about to receive: typing for text messages, upload_photo for photos, record_video or upload_video for videos, record_voice or upload_voice for voice notes, upload_document for general files, choose_sticker for stickers, find_location for location data, record_video_note or upload_video_note for video notes.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool SendChatAction(this BotClient bot, long chatId, string action)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteString("action", action);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.SendChatAction, stream);
        }
        /// <summary>Use this method when you need to tell the user that something is happening on the bot's side. The status is set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status). Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="action">Type of action to broadcast. Choose one, depending on what the user is about to receive: typing for text messages, upload_photo for photos, record_video or upload_video for videos, record_voice or upload_voice for voice notes, upload_document for general files, choose_sticker for stickers, find_location for location data, record_video_note or upload_video_note for video notes.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool SendChatAction(this BotClient bot, string chatId, string action)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteString("action", action);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.SendChatAction, stream);
        }
        /// <summary>Use this method when you need to tell the user that something is happening on the bot's side. The status is set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status). Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="action">Type of action to broadcast. Choose one, depending on what the user is about to receive: typing for text messages, upload_photo for photos, record_video or upload_video for videos, record_voice or upload_voice for voice notes, upload_document for general files, choose_sticker for stickers, find_location for location data, record_video_note or upload_video_note for video notes.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> SendChatActionAsync(this BotClient bot, long chatId, string action, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteString("action", action);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.SendChatAction, stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method when you need to tell the user that something is happening on the bot's side. The status is set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status). Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="action">Type of action to broadcast. Choose one, depending on what the user is about to receive: typing for text messages, upload_photo for photos, record_video or upload_video for videos, record_voice or upload_voice for voice notes, upload_document for general files, choose_sticker for stickers, find_location for location data, record_video_note or upload_video_note for video notes.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> SendChatActionAsync(this BotClient bot, string chatId, string action, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteString("action", action);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.SendChatAction, stream, cancellationToken).ConfigureAwait(false);
        }
    }

    /// <summary>Type of action to broadcast. Choose one, depending on what the user is about to receive: typing for text messages, upload_photo for photos, record_video or upload_video for videos, record_voice or upload_voice for voice notes, upload_document for general files, choose_sticker for stickers, find_location for location data, record_video_note or upload_video_note for video notes.</summary>
    public static class ChatAction
    {
        /// <summary>For text messages</summary>
        public const string Typing = "typing";
        /// <summary>For photos</summary>
        public const string UploadPhoto = "upload_photo";
        /// <summary>For videos</summary>
        public const string RecordVideo = "record_video";
        /// <summary>For videos</summary>
        public const string UploadVideo = "upload_video";
        /// <summary>For voice notes</summary>
        public const string RecordVoice = "record_voice";
        /// <summary>For voice notes</summary>
        public const string UploadVoice = "upload_voice";
        /// <summary>For audio files.
        /// <i><br />[Bot API 5.2: Old action name]</i> Use RecordVoice instead RecordAudio</summary>
        [Obsolete("[Bot API 5.2: Old action name]: Use RecordVoice instead RecordAudio")]
        public const string RecordAudio = "record_audio";
        /// <summary>For audio files
        /// <i><br />[Bot API 5.2: Old action name]</i> Use UploadVoice instead UploadAudio</summary>
        [Obsolete("[Bot API 5.2: Old action name]: Use UploadVoice instead UploadAudio")]
        public const string UploadAudio = "upload_audio";
        /// <summary>For general files</summary>
        public const string UploadDocument = "upload_document";
        /// <summary>For location data</summary>
        public const string FindLocation = "find_location";
        /// <summary>For video notes</summary>
        public const string RecordVideoNote = "record_video_note";
        /// <summary>For video notes</summary>
        public const string UploadVideoNote = "upload_video_note";
        /// <summary>For stickers</summary>
        public const string ChooseSticker = "choose_sticker";
    }
}
