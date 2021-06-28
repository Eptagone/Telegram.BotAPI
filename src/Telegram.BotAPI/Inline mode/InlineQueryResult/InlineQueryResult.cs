// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.Converters;

using JsonConverter = System.Text.Json.Serialization.JsonConverterAttribute;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>This object represents one result of an inline query. Telegram clients currently support results of the following 20 types: <br /><br />
    /// • <see cref="InlineQueryResultCachedAudio"/><br />
    /// • <see cref="InlineQueryResultCachedDocument"/><br />
    /// • <see cref="InlineQueryResultCachedGif"/><br />
    /// • <see cref="InlineQueryResultCachedMpeg4Gif"/><br />
    /// • <see cref="InlineQueryResultCachedPhoto"/><br />
    /// • <see cref="InlineQueryResultCachedSticker"/><br />
    /// • <see cref="InlineQueryResultCachedVideo"/><br />
    /// • <see cref="InlineQueryResultCachedVoice"/><br />
    /// • <see cref="InlineQueryResultArticle"/><br />
    /// • <see cref="InlineQueryResultAudio"/><br />
    /// • <see cref="InlineQueryResultContact"/><br />
    /// • <see cref="InlineQueryResultGame"/><br />
    /// • <see cref="InlineQueryResultDocument"/><br />
    /// • <see cref="InlineQueryResultGif"/><br />
    /// • <see cref="InlineQueryResultLocation"/><br />
    /// • <see cref="InlineQueryResultMpeg4Gif"/><br />
    /// • <see cref="InlineQueryResultPhoto"/><br />
    /// • <see cref="InlineQueryResultVenue"/><br />
    /// • <see cref="InlineQueryResultVideo"/><br />
    /// • <see cref="InlineQueryResultVoice"/></summary>
    [JsonConverter(typeof(InlineQueryResultConverter))]
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class InlineQueryResult : ICustomizableReplyMarkup<InlineKeyboardMarkup>
    {
        /// <summary>Type of the result.</summary>
        public abstract string Type { get; }
        /// <summary>Unique identifier for this result, 1-64 Bytes.</summary>
        [JsonPropertyName(PropertyNames.Id)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>Optional. Inline keyboard attached to the message.</summary>
        [JsonPropertyName(PropertyNames.ReplyMarkup)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
    /// <summary>This object represents one result of an inline query with caption entities. Support results of the following 15 types: <br /><br />
    /// • <see cref="InlineQueryResultCachedAudio"/><br />
    /// • <see cref="InlineQueryResultCachedDocument"/><br />
    /// • <see cref="InlineQueryResultCachedGif"/><br />
    /// • <see cref="InlineQueryResultCachedMpeg4Gif"/><br />
    /// • <see cref="InlineQueryResultCachedPhoto"/><br />
    /// • <see cref="InlineQueryResultCachedVideo"/><br />
    /// • <see cref="InlineQueryResultCachedVoice"/><br />
    /// • <see cref="InlineQueryResultAudio"/><br />
    /// • <see cref="InlineQueryResultDocument"/><br />
    /// • <see cref="InlineQueryResultGif"/><br />
    /// • <see cref="InlineQueryResultLocation"/><br />
    /// • <see cref="InlineQueryResultMpeg4Gif"/><br />
    /// • <see cref="InlineQueryResultPhoto"/><br />
    /// • <see cref="InlineQueryResultVideo"/><br />
    /// • <see cref="InlineQueryResultVoice"/></summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class InlineQueryResultWithEntities : InlineQueryResult, IFormattableMessage
    {
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName(PropertyNames.ParseMode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ParseMode { get; set; }
        /// <summary>Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName(PropertyNames.CaptionEntities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] CaptionEntities { get; set; }
    }
}
