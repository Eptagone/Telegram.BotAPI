// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters
{
	/// <summary>Converts an <see cref="MenuButton"/> to or from JSON.</summary>
	public sealed class MenuButtonConverter : JsonConverter<MenuButton>
	{
		/// <summary>
		/// Reads and converts the JSON to type <see cref="MenuButton"/>.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="typeToConvert">The type to convert.</param>
		/// <param name="options">An object that specifies serialization options to use.</param>
		/// <returns>The converted value.</returns>
		public override MenuButton? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
					MenuButtonType.Commands => JsonSerializer.Deserialize<MenuButtonCommands>(rawText, options),
					MenuButtonType.Default => JsonSerializer.Deserialize<MenuButtonDefault>(rawText, options),
					MenuButtonType.WebApp => JsonSerializer.Deserialize<MenuButtonWebApp>(rawText, options),
					_ => throw new JsonException($"Json object is not a valid chat member."),
				};
			}
			else
			{
				throw new JsonException($"Missing required property: {PropertyNames.Status}");
			}
		}

		/// <summary>
		/// Writes a <see cref="MenuButton"/> object as JSON.
		/// </summary>
		/// <param name="writer">The writer to write to.</param>
		/// <param name="value">The value to convert to JSON.</param>
		/// <param name="options">An object that specifies serialization options to use.</param>
		public override void Write(Utf8JsonWriter writer, MenuButton value, JsonSerializerOptions options)
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
