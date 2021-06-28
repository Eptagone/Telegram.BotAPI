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
using Telegram.BotAPI.Converters;

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
                options.Converters.Add(new InputMediaConverter());
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
    }
}
