// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="InputMedia"/> to or from JSON.
/// </summary>
public sealed class InputMediaConverter : DiscriminatorJsonConverter<InputMedia>
{
	/// <inheritdoc />
	public override string PropertyName => PropertyNames.Type;
}
