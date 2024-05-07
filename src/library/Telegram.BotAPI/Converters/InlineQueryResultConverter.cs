// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.InlineMode;

namespace Telegram.BotAPI.Converters;

/// <summary>Converts an <see cref="InlineQueryResult"/> to or from JSON.</summary>
public sealed class InlineQueryResultConverter : DiscriminatorJsonConverter<InlineQueryResult>
{
	/// <inheritdoc />
	public override string PropertyName => PropertyNames.Type;
}
