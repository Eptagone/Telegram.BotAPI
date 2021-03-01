// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.TelegramPassport;

namespace Telegram.BotAPI
{
    internal static class Tools
    {
        internal static async Task<Stream> SerializeAsStreamAsync(object args, [Optional] JsonSerializerOptions options, [Optional] CancellationToken cancellationToken)
        {
            if (options == default)
            {
                options = new JsonSerializerOptions { IgnoreNullValues = true };
                options.Converters.Add(new ReplyMarkupConverter());
                options.Converters.Add(new InlineKeyboardMarkupConverter());
                options.Converters.Add(new InputMediaJsonConverter());
            }
            var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, args, args.GetType(), options, cancellationToken).ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        internal static bool IsNumber(this object value)
        {
            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal;
        }
        public class InputMediaJsonConverter : JsonConverter<InputMedia>
        {
            public override InputMedia Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override void Write(Utf8JsonWriter writer, InputMedia value, JsonSerializerOptions options)
            {
                if (value is InputMediaAnimation inputMediaAnimation)
                {
                    JsonSerializer.Serialize(writer, inputMediaAnimation, typeof(InputMediaAnimation), options);
                    return;
                }
                if (value is InputMediaAudio inputMediaAudio)
                {
                    JsonSerializer.Serialize(writer, inputMediaAudio, typeof(InputMediaAudio), options);
                    return;
                }
                if (value is InputMediaDocument inputMediaDocument)
                {
                    JsonSerializer.Serialize(writer, inputMediaDocument, typeof(InputMediaDocument), options);
                    return;
                }
                if (value is InputMediaPhoto inputMediaPhoto)
                {
                    JsonSerializer.Serialize(writer, inputMediaPhoto, typeof(InputMediaPhoto), options);
                    return;
                }
                if (value is InputMediaVideo inputMediaVideo)
                {
                    JsonSerializer.Serialize(writer, inputMediaVideo, typeof(InputMediaVideo), options);
                    return;
                }
                writer.WriteNullValue();
            }
        }
        public class PassportElementErrorJsonConverter : JsonConverter<PassportElementError>
        {
            public override PassportElementError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, PassportElementError value, JsonSerializerOptions options)
            {
                if (value is PassportElementErrorDataField dataField)
                {
                    JsonSerializer.Serialize(writer, dataField, typeof(PassportElementErrorDataField), options);
                    return;
                }
                if (value is PassportElementErrorFrontSide frontSide)
                {
                    JsonSerializer.Serialize(writer, frontSide, typeof(PassportElementErrorFrontSide), options);
                    return;
                }
                if (value is PassportElementErrorReverseSide reverseSide)
                {
                    JsonSerializer.Serialize(writer, reverseSide, typeof(PassportElementErrorReverseSide), options);
                    return;
                }
                if (value is PassportElementErrorSelfie errorSelfie)
                {
                    JsonSerializer.Serialize(writer, errorSelfie, typeof(PassportElementErrorSelfie), options);
                    return;
                }
                if (value is PassportElementErrorFile errorFile)
                {
                    JsonSerializer.Serialize(writer, errorFile, typeof(PassportElementErrorFile), options);
                    return;
                }
                if (value is PassportElementErrorFiles errorFiles)
                {
                    JsonSerializer.Serialize(writer, errorFiles, typeof(PassportElementErrorFiles), options);
                    return;
                }
                if (value is PassportElementErrorTranslationFile translationFile)
                {
                    JsonSerializer.Serialize(writer, translationFile, typeof(PassportElementErrorTranslationFile), options);
                    return;
                }
                if (value is PassportElementErrorTranslationFiles translationFiles)
                {
                    JsonSerializer.Serialize(writer, translationFiles, typeof(PassportElementErrorTranslationFiles), options);
                    return;
                }
                if (value is PassportElementErrorUnspecified unspecified)
                {
                    JsonSerializer.Serialize(writer, unspecified, typeof(PassportElementErrorUnspecified), options);
                    return;
                }
                writer.WriteNullValue();
            }
        }
        public class InlineQueryResultConverter : JsonConverter<InlineQueryResult>
        {
            public override InlineQueryResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, InlineQueryResult value, JsonSerializerOptions options)
            {
                if (value is InlineQueryResultCachedAudio cachedAudio)
                {
                    JsonSerializer.Serialize(writer, cachedAudio, typeof(InlineQueryResultCachedAudio), options);
                    return;
                }
                if (value is InlineQueryResultCachedDocument cachedDocument)
                {
                    JsonSerializer.Serialize(writer, cachedDocument, typeof(InlineQueryResultCachedDocument), options);
                    return;
                }
                if (value is InlineQueryResultCachedGif cachedGif)
                {
                    JsonSerializer.Serialize(writer, cachedGif, typeof(InlineQueryResultCachedGif), options);
                    return;
                }
                if (value is InlineQueryResultCachedMpeg4Gif cachedMpeg4Gif)
                {
                    JsonSerializer.Serialize(writer, cachedMpeg4Gif, typeof(InlineQueryResultCachedMpeg4Gif), options);
                    return;
                }
                if (value is InlineQueryResultCachedPhoto cachedPhoto)
                {
                    JsonSerializer.Serialize(writer, cachedPhoto, typeof(InlineQueryResultCachedPhoto), options);
                    return;
                }
                if (value is InlineQueryResultCachedSticker cachedSticker)
                {
                    JsonSerializer.Serialize(writer, cachedSticker, typeof(InlineQueryResultCachedSticker), options);
                    return;
                }
                if (value is InlineQueryResultCachedVideo cachedVideo)
                {
                    JsonSerializer.Serialize(writer, cachedVideo, typeof(InlineQueryResultCachedVideo), options);
                    return;
                }
                if (value is InlineQueryResultCachedVoice cachedVoice)
                {
                    JsonSerializer.Serialize(writer, cachedVoice, typeof(InlineQueryResultCachedVoice), options);
                    return;
                }
                if (value is InlineQueryResultArticle article)
                {
                    JsonSerializer.Serialize(writer, article, typeof(InlineQueryResultArticle), options);
                    return;
                }
                if (value is InlineQueryResultAudio audio)
                {
                    JsonSerializer.Serialize(writer, audio, typeof(InlineQueryResultAudio), options);
                    return;
                }
                if (value is InlineQueryResultContact contact)
                {
                    JsonSerializer.Serialize(writer, contact, typeof(InlineQueryResultContact), options);
                    return;
                }
                if (value is InlineQueryResultGame game)
                {
                    JsonSerializer.Serialize(writer, game, typeof(InlineQueryResultGame), options);
                    return;
                }
                if (value is InlineQueryResultDocument document)
                {
                    JsonSerializer.Serialize(writer, document, typeof(InlineQueryResultDocument), options);
                    return;
                }
                if (value is InlineQueryResultGif gif)
                {
                    JsonSerializer.Serialize(writer, gif, typeof(InlineQueryResultGif), options);
                    return;
                }
                if (value is InlineQueryResultLocation location)
                {
                    JsonSerializer.Serialize(writer, location, typeof(InlineQueryResultLocation), options);
                    return;
                }
                if (value is InlineQueryResultMpeg4Gif mpeg4Gif)
                {
                    JsonSerializer.Serialize(writer, mpeg4Gif, typeof(InlineQueryResultMpeg4Gif), options);
                    return;
                }
                if (value is InlineQueryResultPhoto photo)
                {
                    JsonSerializer.Serialize(writer, photo, typeof(InlineQueryResultPhoto), options);
                    return;
                }
                if (value is InlineQueryResultVenue venue)
                {
                    JsonSerializer.Serialize(writer, venue, typeof(InlineQueryResultVenue), options);
                    return;
                }
                if (value is InlineQueryResultVideo video)
                {
                    JsonSerializer.Serialize(writer, video, typeof(InlineQueryResultVideo), options);
                    return;
                }
                if (value is InlineQueryResultVoice voice)
                {
                    JsonSerializer.Serialize(writer, voice, typeof(InlineQueryResultVoice), options);
                    return;
                }
                writer.WriteNullValue();
            }
        }
        public class InputMessageContentConverter : JsonConverter<InputMessageContent>
        {
            public override InputMessageContent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, InputMessageContent value, JsonSerializerOptions options)
            {
                if (value is InputTextMessageContent inputText)
                {
                    JsonSerializer.Serialize(writer, inputText, typeof(InputTextMessageContent), options);
                    return;
                }
                if (value is InputLocationMessageContent inputLocation)
                {
                    JsonSerializer.Serialize(writer, inputLocation, typeof(InputLocationMessageContent), options);
                    return;
                }
                if (value is InputVenueMessageContent inputVenue)
                {
                    JsonSerializer.Serialize(writer, inputVenue, typeof(InputVenueMessageContent), options);
                    return;
                }
                if (value is InputContactMessageContent inputContact)
                {
                    JsonSerializer.Serialize(writer, inputContact, typeof(InputContactMessageContent), options);
                    return;
                }
                writer.WriteNullValue();
            }
        }
        public class InlineKeyboardMarkupConverter : JsonConverter<InlineKeyboardMarkup>
        {
            public override InlineKeyboardMarkup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override void Write(Utf8JsonWriter writer, InlineKeyboardMarkup value, JsonSerializerOptions options)
            {
                writer.WriteStartObject();
                writer.WriteStartArray(PropertyNames.InlineKeyboard);
                foreach (var ink in value.InlineKeyboard)
                {
                    writer.WriteStartArray();
                    foreach (var button in ink)
                    {
                        writer.WriteStartObject();
                        writer.WriteString(PropertyNames.Text, button.Text);
                        switch (button.Type)
                        {
                            case InlineKeyboardButtonType.Url:
                                writer.WriteString(PropertyNames.Url, button.Url);
                                break;
                            case InlineKeyboardButtonType.LoginUrl:
                                writer.WriteStartObject(PropertyNames.LoginUrl);
                                writer.WriteString(PropertyNames.Url, button.LoginUrl.Url);
                                if (button.LoginUrl.ForwardText != default)
                                {
                                    writer.WriteString(PropertyNames.ForwardText, button.LoginUrl.ForwardText);
                                }

                                if (button.LoginUrl.BotUsername != default)
                                {
                                    writer.WriteString(PropertyNames.BotUsername, button.LoginUrl.BotUsername);
                                }

                                if (button.LoginUrl.RequestWriteAccess)
                                {
                                    writer.WriteBoolean(PropertyNames.RequestWriteAccess, true);
                                }

                                writer.WriteEndObject();
                                break;
                            case InlineKeyboardButtonType.CallbackData:
                                writer.WriteString(PropertyNames.CallbackData, button.CallbackData);
                                break;
                            case InlineKeyboardButtonType.SwitchInlineQuery:
                                writer.WriteString(PropertyNames.SwitchInlineQuery, button.SwitchInlineQuery);
                                break;
                            case InlineKeyboardButtonType.SwitchInlineQueryCurrentChat:
                                writer.WriteString(PropertyNames.SwitchInlineQueryCurrentChat, button.SwitchInlineQueryCurrentChat);
                                break;
                            case InlineKeyboardButtonType.CallbackGame:
                                writer.WriteStartObject(PropertyNames.CallbackGame);
                                writer.WriteString(PropertyNames.GameShortName, button.CallbackGame.GameShortName);
                                writer.WriteEndObject();
                                break;
                            case InlineKeyboardButtonType.Pay:
                                writer.WriteBoolean(PropertyNames.Pay, button.Pay);
                                break;
                        }
                        writer.WriteEndObject();
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
                writer.WriteEndObject();
                return;
            }
        }
        public class ReplyMarkupConverter : JsonConverter<ReplyMarkup>
        {
            public override ReplyMarkup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                var replymarkup = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
                if (replymarkup.TryGetProperty(PropertyNames.ForceReply, out _))
                {
                    return JsonSerializer.Deserialize<ForceReply>(ref reader, options);
                }
                if (replymarkup.TryGetProperty(PropertyNames.Keyboard, out _))
                {
                    return JsonSerializer.Deserialize<ReplyKeyboardMarkup>(ref reader, options);
                }
                if (replymarkup.TryGetProperty(PropertyNames.InlineKeyboard, out _))
                {
                    return JsonSerializer.Deserialize<InlineKeyboardMarkup>(ref reader, options);
                }
                if (replymarkup.TryGetProperty(PropertyNames.RemoveKeyboard, out _))
                {
                    return JsonSerializer.Deserialize<ReplyKeyboardRemove>(ref reader, options);
                }
                return default;
            }
            public override void Write(Utf8JsonWriter writer, ReplyMarkup value, JsonSerializerOptions options)
            {
                if (value is ForceReply forceReply)
                {
                    writer.WriteStartObject();
                    writer.WriteBoolean(PropertyNames.ForceReply, true);
                    if (forceReply.Selective)
                    {
                        writer.WriteBoolean(PropertyNames.Selective, true);
                    }

                    writer.WriteEndObject();
                    return;
                }
                if (value is ReplyKeyboardMarkup)
                {
                    JsonSerializer.Serialize(writer, value, typeof(ReplyKeyboardMarkup), options);
                    return;
                }
                if (value is InlineKeyboardMarkup)
                {
                    JsonSerializer.Serialize(writer, value, typeof(InlineKeyboardMarkup), options);
                    return;
                }
                if (value is ReplyKeyboardRemove replyKeyboardRemove)
                {
                    writer.WriteStartObject();
                    writer.WriteBoolean(PropertyNames.RemoveKeyboard, true);
                    if (replyKeyboardRemove.Selective)
                    {
                        writer.WriteBoolean(PropertyNames.Selective, true);
                    }

                    writer.WriteEndObject();
                    return;
                }
                writer.WriteNullValue();
            }
        }
    }
}
