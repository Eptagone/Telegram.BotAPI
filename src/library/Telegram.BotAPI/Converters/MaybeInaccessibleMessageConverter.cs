// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="MaybeInaccessibleMessage"/> to or from JSON.
/// </summary>
public sealed class MaybeInaccessibleMessageConverter : JsonConverter<MaybeInaccessibleMessage>
{
	/// <summary>
	/// Reads and converts the JSON to type <see cref="MaybeInaccessibleMessage"/>.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	public override MaybeInaccessibleMessage? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options)!;
		var isValid = jsonDoc.RootElement.TryGetProperty(PropertyNames.Date, out JsonElement prop);
		var rawText = jsonDoc.RootElement.GetRawText();
		if (isValid)
		{
			var date = prop.GetUInt32();
			if (date == 0)
			{
				return JsonSerializer.Deserialize<InaccessibleMessage>(rawText, options);
			}
			else
			{
				return JsonSerializer.Deserialize<Message>(rawText, options);
			}
		}
		else
		{
			throw new JsonException($"Missing required property: {PropertyNames.Date}");
		}
	}

	/// <summary>
	/// Writes a <see cref="MaybeInaccessibleMessage"/> object as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	public override void Write(Utf8JsonWriter writer, MaybeInaccessibleMessage value, JsonSerializerOptions options)
	{
		if (value == null)
		{
			throw new ArgumentNullException(nameof(value));
		}
		var type = value.GetType();
		JsonSerializer.Serialize(writer, value, type, options);
	}
}
