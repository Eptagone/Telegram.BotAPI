// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="InputPaidMedia"/> to or from JSON.
/// </summary>
public sealed class InputPaidMediaConverter : DiscriminatorJsonConverter<InputPaidMedia>
{
    /// <inheritdoc />
    public override string PropertyName => PropertyNames.Type;
}
