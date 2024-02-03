// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="ReplyMarkup"/> to or from JSON.
/// </summary>
public sealed class ReplyMarkupConverter : JsonConverter<ReplyMarkup>
{
	/// <summary>
	/// Reads and converts the JSON to type <see cref="ReplyMarkup"/>.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	public override ReplyMarkup? Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options
	)
	{
		var replymarkup = JsonSerializer.Deserialize<JsonElement>(ref reader, options)!;
		var rawText = replymarkup.GetRawText();
		if (replymarkup.TryGetProperty(PropertyNames.ForceReply, out _))
		{
			return JsonSerializer.Deserialize<ForceReply>(rawText, options);
		}
		if (replymarkup.TryGetProperty(PropertyNames.Keyboard, out _))
		{
			return JsonSerializer.Deserialize<ReplyKeyboardMarkup>(rawText, options);
		}
		if (replymarkup.TryGetProperty(PropertyNames.InlineKeyboard, out _))
		{
			return JsonSerializer.Deserialize<InlineKeyboardMarkup>(rawText, options);
		}
		if (replymarkup.TryGetProperty(PropertyNames.RemoveKeyboard, out _))
		{
			return JsonSerializer.Deserialize<ReplyKeyboardRemove>(rawText, options);
		}
		throw new JsonException($"Json object is not a valid reply markup.");
	}

	/// <summary>
	/// Writes a <see cref="ReplyMarkup"/> object as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	public override void Write(
		Utf8JsonWriter writer,
		ReplyMarkup value,
		JsonSerializerOptions options
	)
	{
		if (value == null)
		{
			throw new ArgumentNullException(nameof(value));
		}
		var type = value.GetType();
		JsonSerializer.Serialize(writer, value, type, options);
	}
}
