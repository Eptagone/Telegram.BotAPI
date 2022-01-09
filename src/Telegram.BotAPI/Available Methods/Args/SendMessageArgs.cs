// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>SendMessage method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendMessageArgs : SendMessageWithReplyMarkupBase, IFormattableMessage
    {
        /// <summary>Initialize a new instance of <see cref="SendMessageArgs"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        public SendMessageArgs(long chatId, string text) : base(chatId)
        {
            Text = text;
        }
        /// <summary>Initialize a new instance of <see cref="SendMessageArgs"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        public SendMessageArgs(string chatId, string text) : base(chatId)
        {
            Text = text;
        }

        ///<summary>Text of the message to be sent.</summary>
        [JsonPropertyName(PropertyNames.Text)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
        [JsonPropertyName(PropertyNames.ParseMode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? ParseMode { get; set; }
        /// <summary>List of special entities that appear in message text, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName(PropertyNames.Entities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity>? Entities { get; set; }
        /// <summary>Optional. Disables link previews for links in this message.</summary>
        [JsonPropertyName(PropertyNames.DisableWebPagePreview)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DisableWebPagePreview { get; set; }
    }
}