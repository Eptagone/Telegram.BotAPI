// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.InlineMode;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="InputMessageContent"/> to or from JSON.
/// </summary>
public sealed class InputMessageContentConverter : JsonConverter<InputMessageContent>
{
	/// <summary>
	/// Reads and converts the JSON to type <see cref="InputMessageContent"/>.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	public override InputMessageContent? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options)!;
		var rawText = jsonDoc.RootElement.GetRawText();
		if (jsonDoc.RootElement.TryGetProperty(PropertyNames.MessageText, out JsonElement _))
		{
			return JsonSerializer.Deserialize<InputTextMessageContent>(rawText, options);
		}
		if (jsonDoc.RootElement.TryGetProperty(PropertyNames.Latitude, out JsonElement _))
		{
			if (jsonDoc.RootElement.TryGetProperty(PropertyNames.Address, out JsonElement _))
			{
				return JsonSerializer.Deserialize<InputVenueMessageContent>(rawText, options);
			}
			else
			{
				return JsonSerializer.Deserialize<InputLocationMessageContent>(rawText, options);
			}
		}
		if (jsonDoc.RootElement.TryGetProperty(PropertyNames.PhoneNumber, out JsonElement _))
		{
			return JsonSerializer.Deserialize<InputContactMessageContent>(rawText, options);
		}
		if (jsonDoc.RootElement.TryGetProperty(PropertyNames.Payload, out JsonElement _))
		{
			return JsonSerializer.Deserialize<InputInvoiceMessageContent>(rawText, options);
		}
		throw new JsonException($"Json object is not a valid InputMessageContent.");
	}

	/// <summary>
	/// Writes a <see cref="InputMessageContent"/> object as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	public override void Write(Utf8JsonWriter writer, InputMessageContent value, JsonSerializerOptions options)
	{
		if (value == null)
		{
			throw new ArgumentNullException(nameof(value));
		}
		var type = value.GetType();
		JsonSerializer.Serialize(writer, value, type, options);
	}
}
