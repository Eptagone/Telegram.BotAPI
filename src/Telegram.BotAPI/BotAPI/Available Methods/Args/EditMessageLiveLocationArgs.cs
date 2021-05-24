// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>EditMessageLiveLocation method arguments.</summary>}
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class EditMessageLiveLocationArgs : ILocation, ICustomizableReplyMarkup<InlineKeyboardMarkup>
    {
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ChatId { get; set; }
        ///<summary>Required if inline_message_id is not specified. Identifier of the sent message.</summary>
        [JsonPropertyName(PropertyNames.MessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MessageId { get; set; }
        ///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonPropertyName(PropertyNames.InlineMessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InlineMessageId { get; set; }
        ///<summary>Longitude as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.Longitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
        ///<summary>Latitude as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.Latitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        ///<summary>Optional. The radius of uncertainty for the location, measured in meters; 0-1500.</summary>
        [JsonPropertyName(PropertyNames.HorizontalAccuracy)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float HorizontalAccuracy { get; set; }
        ///<summary>Optional. Time relative to the message sending date, during which the location can be updated, in seconds. For active live locations only.</summary>
        [JsonPropertyName(PropertyNames.LivePeriod)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint LivePeriod { get; set; }
        ///<summary>Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
        [JsonPropertyName(PropertyNames.Heading)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort Heading { get; set; }
        ///<summary>Optional. Maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
        [JsonPropertyName(PropertyNames.ProximityAlertRadius)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ProximityAlertRadius { get; set; }
        ///<summary>Optional. A <see cref="InlineKeyboardMarkup"/> object for a new inline keyboard.</summary>
        [JsonPropertyName(PropertyNames.ReplyMarkup)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
}