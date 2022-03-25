// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;

#nullable enable

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>SendDice method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SendDiceArgs : SendMessageWithReplyMarkupBase
    {
        /// <summary>
        /// Initialize a new instance of <see cref="SendDiceArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendDiceArgs(long chatId) : base(chatId)
        {
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendDiceArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendDiceArgs(string chatId) : base(chatId)
        {
        }

        ///<summary>Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, “🏀”, “⚽”, “🎳”, or “🎰”. Dice can have values 1-6 for “🎲”, “🎯” and “🎳”, values 1-5 for “🏀” and “⚽”, and values 1-64 for “🎰”. Defaults to “🎲”.</summary>
        [JsonPropertyName(PropertyNames.Emoji)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Emoji { get; set; }
    }
}
