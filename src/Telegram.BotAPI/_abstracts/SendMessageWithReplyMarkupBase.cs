// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI
{
    /// <summary>Base object for message-sending methods arguments with reply markup property.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class SendMessageWithReplyMarkupBase : SendMessageBase, ICustomizableReplyMarkup<ReplyMarkup>
    {
        /// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        protected SendMessageWithReplyMarkupBase(long chatId) : base(chatId)
        {
        }
        /// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        protected SendMessageWithReplyMarkupBase(string chatId) : base(chatId)
        {
        }

        /// <summary>Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></summary>
        [JsonPropertyName(PropertyNames.ReplyMarkup)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ReplyMarkup? ReplyMarkup { get; set; }
    }
}
