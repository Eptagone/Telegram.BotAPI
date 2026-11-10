// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>Converts an <see cref="EmojiType"/> to or from JSON.</summary>
public sealed class EmojiTypeConverter : DiscriminatorJsonConverter<EmojiType>
{
    /// <inheritdoc />
    public override string PropertyName => PropertyNames.Status;
}
