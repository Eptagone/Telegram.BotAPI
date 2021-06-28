// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.TelegramPassport;

namespace Telegram.BotAPI.Converters
{
    /// <summary>
    /// Converts an <see cref="PassportElementError"/> to or from JSON.
    /// </summary>
    public sealed class PassportElementErrorConverter : JsonConverter<PassportElementError>
    {
        /// <summary>
        /// Reads and converts the JSON to type <see cref="PassportElementError"/>.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="typeToConvert">The type to convert.</param>
        /// <param name="options">An object that specifies serialization options to use.</param>
        /// <returns>The converted value.</returns>
        public override PassportElementError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options);
            var isValid = jsonDoc.RootElement.TryGetProperty(PropertyNames.Source, out JsonElement prop);
            var rawText = jsonDoc.RootElement.GetRawText();
            if (isValid)
            {
                if (prop.ValueKind != JsonValueKind.String)
                    throw new JsonException($"Property type of {PropertyNames.Source} must be a String.");
                var source = prop.GetString();
                switch (source)
                {
                    case PassportElementErrorSource.Data:
                        return JsonSerializer.Deserialize<PassportElementErrorDataField>(rawText, options);
                    case PassportElementErrorSource.File:
                        return JsonSerializer.Deserialize<PassportElementErrorFile>(rawText, options);
                    case PassportElementErrorSource.Files:
                        return JsonSerializer.Deserialize<PassportElementErrorFiles>(rawText, options);
                    case PassportElementErrorSource.FrontSide:
                        return JsonSerializer.Deserialize<PassportElementErrorFrontSide>(rawText, options);
                    case PassportElementErrorSource.ReverseSide:
                        return JsonSerializer.Deserialize<PassportElementErrorReverseSide>(rawText, options);
                    case PassportElementErrorSource.Selfie:
                        return JsonSerializer.Deserialize<PassportElementErrorSelfie>(rawText, options);
                    case PassportElementErrorSource.TranslationFile:
                        return JsonSerializer.Deserialize<PassportElementErrorTranslationFile>(rawText, options);
                    case PassportElementErrorSource.TranslationFiles:
                        return JsonSerializer.Deserialize<PassportElementErrorTranslationFiles>(rawText, options);
                    case PassportElementErrorSource.Unspecified:
                        return JsonSerializer.Deserialize<PassportElementErrorUnspecified>(rawText, options);
                    default:
                        throw new JsonException($"Json object is not a valid PassportElementError.");
                }
            }
            else
            {
                throw new JsonException($"Missing required property: {PropertyNames.Source}");
            }
        }

        /// <summary>
        /// Writes a <see cref="PassportElementError"/> object as JSON.
        /// </summary>
        /// <param name="writer">The writer to write to.</param>
        /// <param name="value">The value to convert to JSON.</param>
        /// <param name="options">An object that specifies serialization options to use.</param>
        public override void Write(Utf8JsonWriter writer, PassportElementError value, JsonSerializerOptions options)
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
