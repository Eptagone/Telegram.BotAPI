// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters
{
    /// <summary>Converts an <see cref="BotCommandScope"/> to or from JSON.</summary>
    public sealed class BotCommandScopeConverter : JsonConverter<BotCommandScope>
    {
        /// <summary>
        /// Reads and converts the JSON to type <see cref="BotCommandScope"/>.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="typeToConvert">The type to convert.</param>
        /// <param name="options">An object that specifies serialization options to use.</param>
        /// <returns>The converted value.</returns>
        public override BotCommandScope Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options);
            var isValid = jsonDoc.RootElement.TryGetProperty(PropertyNames.Status, out JsonElement prop);
            var rawText = jsonDoc.RootElement.GetRawText();
            if (isValid)
            {
                if (prop.ValueKind != JsonValueKind.String)
                    throw new JsonException($"Property type of {PropertyNames.Status} must be a String.");
                var status = prop.GetString();
                switch (status)
                {
                    case BotCommandScopeType.AllChatAdministrators:
                        return JsonSerializer.Deserialize<BotCommandScopeAllChatAdministrators>(rawText, options);
                    case BotCommandScopeType.AllGroupChats:
                        return JsonSerializer.Deserialize<BotCommandScopeAllGroupChats>(rawText, options);
                    case BotCommandScopeType.AllPrivateChats:
                        return JsonSerializer.Deserialize<BotCommandScopeAllPrivateChats>(rawText, options);
                    case BotCommandScopeType.Chat:
                        return JsonSerializer.Deserialize<BotCommandScopeChat>(rawText, options);
                    case BotCommandScopeType.ChatAdministrators:
                        return JsonSerializer.Deserialize<BotCommandScopeChatAdministrators>(rawText, options);
                    case BotCommandScopeType.ChatMember:
                        return JsonSerializer.Deserialize<BotCommandScopeChatMember>(rawText, options);
                    case BotCommandScopeType.Default:
                        return JsonSerializer.Deserialize<BotCommandScopeDefault>(rawText, options);
                    default:
                        throw new JsonException($"Json object is not a valid bot command scope.");
                }
            }
            else
            {
                throw new JsonException($"Missing required property: {PropertyNames.Type}");
            }
        }

        /// <summary>
        /// Writes a <see cref="BotCommandScope"/> object as JSON.
        /// </summary>
        /// <param name="writer">The writer to write to.</param>
        /// <param name="value">The value to convert to JSON.</param>
        /// <param name="options">An object that specifies serialization options to use.</param>
        public override void Write(Utf8JsonWriter writer, BotCommandScope value, JsonSerializerOptions options)
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
