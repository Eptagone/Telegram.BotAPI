// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="InputMedia"/> to or from JSON.
/// </summary>
public sealed class InputMediaConverter : DiscriminatorJsonConverter<InputMedia>
{
	/// <inheritdoc />
	public override string PropertyName => PropertyNames.Type;

	/// <summary>
	/// Writes a <see cref="InputMedia"/> object as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	public override void Write(
		Utf8JsonWriter writer,
		InputMedia value,
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
