// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="ReactionType"/> to or from JSON.
/// </summary>
public sealed class ReactionTypeConverter : JsonConverter<ReactionType>
{
	/// <summary>
	/// Reads and converts the JSON to type <see cref="ReactionType"/>.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	public override ReactionType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var ReactionType = JsonSerializer.Deserialize<JsonElement>(ref reader, options)!;
		var rawText = ReactionType.GetRawText();
		if (ReactionType.TryGetProperty(PropertyNames.Type, out var value))
		{
			var typeName = value.GetString();
			return typeName switch
			{
				"emoji" => JsonSerializer.Deserialize<ReactionTypeEmoji>(rawText, options),
				"custom_emoji" => JsonSerializer.Deserialize<ReactionTypeCustomEmoji>(rawText, options),
				_ => throw new JsonException($"Json object is not a valid reaction type."),
			};
		}

		throw new JsonException($"Json object is not a valid reaction type.");
	}

	/// <summary>
	/// Writes a <see cref="ReactionType"/> object as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	public override void Write(Utf8JsonWriter writer, ReactionType value, JsonSerializerOptions options)
	{
		if (value == null)
		{
			throw new ArgumentNullException(nameof(value));
		}
		var type = value.GetType();
		JsonSerializer.Serialize(writer, value, type, options);
	}
}
