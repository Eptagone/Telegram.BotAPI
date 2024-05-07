// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="ReactionType"/> to or from JSON.
/// </summary>
public sealed class ReactionTypeConverter : DiscriminatorJsonConverter<ReactionType>
{
	/// <inheritdoc />
	public override string PropertyName => PropertyNames.Type;
}
