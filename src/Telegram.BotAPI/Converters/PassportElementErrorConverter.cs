// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.TelegramPassport;

namespace Telegram.BotAPI.Converters;

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
	public override PassportElementError? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options)!;
		var isValid = jsonDoc.RootElement.TryGetProperty(PropertyNames.Source, out JsonElement prop);
		var rawText = jsonDoc.RootElement.GetRawText();
		if (isValid)
		{
			if (prop.ValueKind != JsonValueKind.String)
				throw new JsonException($"Property type of {PropertyNames.Source} must be a String.");
			var source = prop.GetString();
			return source switch
			{
				PassportElementErrorSource.Data => JsonSerializer.Deserialize<PassportElementErrorDataField>(rawText, options),
				PassportElementErrorSource.File => JsonSerializer.Deserialize<PassportElementErrorFile>(rawText, options),
				PassportElementErrorSource.Files => JsonSerializer.Deserialize<PassportElementErrorFiles>(rawText, options),
				PassportElementErrorSource.FrontSide => JsonSerializer.Deserialize<PassportElementErrorFrontSide>(rawText, options),
				PassportElementErrorSource.ReverseSide => JsonSerializer.Deserialize<PassportElementErrorReverseSide>(rawText, options),
				PassportElementErrorSource.Selfie => JsonSerializer.Deserialize<PassportElementErrorSelfie>(rawText, options),
				PassportElementErrorSource.TranslationFile => JsonSerializer.Deserialize<PassportElementErrorTranslationFile>(rawText, options),
				PassportElementErrorSource.TranslationFiles => JsonSerializer.Deserialize<PassportElementErrorTranslationFiles>(rawText, options),
				PassportElementErrorSource.Unspecified => JsonSerializer.Deserialize<PassportElementErrorUnspecified>(rawText, options),
				_ => throw new JsonException($"Json object is not a valid PassportElementError."),
			};
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
