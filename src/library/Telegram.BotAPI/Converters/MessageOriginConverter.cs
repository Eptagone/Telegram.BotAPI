// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="MessageOrigin"/> to or from JSON.
/// </summary>
public sealed class MessageOriginConverter : JsonConverter<MessageOrigin>
{
	/// <summary>
	/// Reads and converts the JSON to type <see cref="MessageOrigin"/>.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	public override MessageOrigin? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options)!;
		var isValid = jsonDoc.RootElement.TryGetProperty(PropertyNames.Type, out JsonElement prop);
		var rawText = jsonDoc.RootElement.GetRawText();
		if (isValid)
		{
			if (prop.ValueKind != JsonValueKind.String)
				throw new JsonException($"Property type of {PropertyNames.Type} must be a String.");
			var type = prop.GetString();
			return type switch
			{
				"user" => JsonSerializer.Deserialize<MessageOriginUser>(rawText, options),
				"hidden_user" => JsonSerializer.Deserialize<MessageOriginHiddenUser>(rawText, options),
				"chat" => JsonSerializer.Deserialize<MessageOriginChat>(rawText, options),
				"channel" => JsonSerializer.Deserialize<MessageOriginChannel>(rawText, options),
				_ => throw new JsonException($"Json object is not a valid MessageOrigin."),
			};
		}
		else
		{
			throw new JsonException($"Missing required property: {PropertyNames.Type}");
		}
	}

	/// <summary>
	/// Writes a <see cref="MessageOrigin"/> object as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	public override void Write(Utf8JsonWriter writer, MessageOrigin value, JsonSerializerOptions options)
	{
		if (value == null)
		{
			throw new ArgumentNullException(nameof(value));
		}
		var type = value.GetType();
		JsonSerializer.Serialize(writer, value, type, options);
	}
}
