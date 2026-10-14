// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.RichMessages;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="RichText"/> to or from JSON.
/// </summary>
public sealed class RichTextConverter : DiscriminatorJsonConverter<RichText>
{
    /// <inheritdoc />
    public override string PropertyName => PropertyNames.Type;

    /// <inheritdoc/>
    public override RichText? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return reader.TokenType switch
        {
            JsonTokenType.StartArray => new RichTextArray(
                JsonSerializer.Deserialize<RichText[]>(ref reader, options)!
            ),
            JsonTokenType.String => new RichTextPlainText(reader.GetString()!),
            JsonTokenType.StartObject => base.Read(ref reader, typeToConvert, options),
            _ => throw new JsonException(
                $"Failed to deserialize RichText. Unexpected token {reader.TokenType}"
            ),
        };
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, RichText value, JsonSerializerOptions options)
    {
        if (value is RichTextArray array)
        {
            JsonSerializer.Serialize(writer, (IEnumerable<RichText>)array, options);
        }
        else if (value is RichTextPlainText plainText)
        {
            JsonSerializer.Serialize(writer, (string)plainText, options);
        }
        else
        {
            base.Write(writer, value, options);
        }
    }
}
