// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>SendSticker method arguments</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendStickerArgs : SendMessageWithReplyMarkupBase, IMultipartForm
    {
        /// <summary>
        /// Initialize a new instance of <see cref="SendStickerArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendStickerArgs(long chatId, InputFile sticker) : base(chatId)
        {
            Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendStickerArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendStickerArgs(long chatId, string sticker) : base(chatId)
        {
            Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendStickerArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendStickerArgs(string chatId, InputFile sticker) : base(chatId)
        {
            Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendStickerArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendStickerArgs(string chatId, string sticker) : base(chatId)
        {
            Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
        }

        /// <summary>Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonPropertyName(PropertyNames.Sticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Sticker { get; set; }

        bool IMultipartForm.UseMultipart()
        {
            if (Sticker != default)
            {
                if (Sticker.GetType() == typeof(InputFile))
                {
                    return true;
                }
            }

            return false;
        }
    }
}