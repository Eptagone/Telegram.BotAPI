// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.InlineMode;

namespace Telegram.BotAPI.Converters
{
    /// <summary>Converts an <see cref="InlineQueryResult"/> to or from JSON.</summary>
    public sealed class InlineQueryResultConverter : JsonConverter<InlineQueryResult>
    {
        /// <summary>
        /// Reads and converts the JSON to type <see cref="InlineQueryResult"/>.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="typeToConvert">The type to convert.</param>
        /// <param name="options">An object that specifies serialization options to use.</param>
        /// <returns>The converted value.</returns>
        public override InlineQueryResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options);
            var isValid = jsonDoc.RootElement.TryGetProperty(PropertyNames.Type, out JsonElement prop);
            var rawText = jsonDoc.RootElement.GetRawText();
            if (isValid)
            {
                if (prop.ValueKind != JsonValueKind.String)
                    throw new JsonException($"Property type of {PropertyNames.Type} must be a String.");
                var type = prop.GetString();
                bool isCached;
                switch (type)
                {
                    case InlineQueryResultType.Article:
                        return JsonSerializer.Deserialize<InlineQueryResultArticle>(rawText, options);
                    case InlineQueryResultType.Audio:
                        isCached = jsonDoc.RootElement.TryGetProperty(PropertyNames.AudioFileId, out JsonElement _);
                        if (isCached)
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultCachedAudio>(rawText, options);
                        }
                        else
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultAudio>(rawText, options);
                        }
                    case InlineQueryResultType.Contact:
                        return JsonSerializer.Deserialize<InlineQueryResultContact>(rawText, options);
                    case InlineQueryResultType.Document:
                        isCached = jsonDoc.RootElement.TryGetProperty(PropertyNames.DocumentFileId, out JsonElement _);
                        if (isCached)
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultCachedDocument>(rawText, options);
                        }
                        else
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultDocument>(rawText, options);
                        }
                    case InlineQueryResultType.Game:
                        return JsonSerializer.Deserialize<InlineQueryResultGame>(rawText, options);
                    case InlineQueryResultType.Gif:
                        isCached = jsonDoc.RootElement.TryGetProperty(PropertyNames.GifFileId, out JsonElement _);
                        if (isCached)
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultCachedGif>(rawText, options);
                        }
                        else
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultGif>(rawText, options);
                        }
                    case InlineQueryResultType.Location:
                        return JsonSerializer.Deserialize<InlineQueryResultLocation>(rawText, options);
                    case InlineQueryResultType.Mpeg4Gif:
                        isCached = jsonDoc.RootElement.TryGetProperty(PropertyNames.Mpeg4FileId, out JsonElement _);
                        if (isCached)
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultCachedMpeg4Gif>(rawText, options);
                        }
                        else
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultMpeg4Gif>(rawText, options);
                        }
                    case InlineQueryResultType.Photo:
                        isCached = jsonDoc.RootElement.TryGetProperty(PropertyNames.PhotoFileId, out JsonElement _);
                        if (isCached)
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultCachedPhoto>(rawText, options);
                        }
                        else
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultPhoto>(rawText, options);
                        }
                    case InlineQueryResultType.Sticker:
                        return JsonSerializer.Deserialize<InlineQueryResultCachedSticker>(rawText, options);
                    case InlineQueryResultType.Venue:
                        return JsonSerializer.Deserialize<InlineQueryResultVenue>(rawText, options);
                    case InlineQueryResultType.Video:
                        isCached = jsonDoc.RootElement.TryGetProperty(PropertyNames.VideoFileId, out JsonElement _);
                        if (isCached)
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultCachedVideo>(rawText, options);
                        }
                        else
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultVideo>(rawText, options);
                        }
                    case InlineQueryResultType.Voice:
                        isCached = jsonDoc.RootElement.TryGetProperty(PropertyNames.VoiceFileId, out JsonElement _);
                        if (isCached)
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultCachedVoice>(rawText, options);
                        }
                        else
                        {
                            return JsonSerializer.Deserialize<InlineQueryResultVoice>(rawText, options);
                        }
                    default:
                        throw new JsonException($"Json object is not a valid InlineQueryResult.");
                }
            }
            else
            {
                throw new JsonException($"Missing required property: {PropertyNames.Type}");
            }
        }

        /// <summary>
        /// Writes a <see cref="InlineQueryResult"/> object as JSON.
        /// </summary>
        /// <param name="writer">The writer to write to.</param>
        /// <param name="value">The value to convert to JSON.</param>
        /// <param name="options">An object that specifies serialization options to use.</param>
        public override void Write(Utf8JsonWriter writer, InlineQueryResult value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            var type = value.GetType();
            JsonSerializer.Serialize(writer, value, type, options);
        }
    }
}
