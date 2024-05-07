// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.TelegramPassport;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="PassportElementError"/> to or from JSON.
/// </summary>
public sealed class PassportElementErrorConverter : DiscriminatorJsonConverter<PassportElementError>
{
	/// <inheritdoc />
	public override string PropertyName => PropertyNames.Source;
}
