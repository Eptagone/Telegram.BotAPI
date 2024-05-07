// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="MessageOrigin"/> to or from JSON.
/// </summary>
public sealed class MessageOriginConverter : DiscriminatorJsonConverter<MessageOrigin>
{
	/// <inheritdoc />
	public override string PropertyName => PropertyNames.Type;
}
