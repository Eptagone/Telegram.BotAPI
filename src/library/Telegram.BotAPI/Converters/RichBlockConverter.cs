// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.RichMessages;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="RichBlock"/> to or from JSON.
/// </summary>
public sealed class RichBlockConverter : DiscriminatorJsonConverter<RichBlock>
{
    /// <inheritdoc />
    public override string PropertyName => PropertyNames.Type;
}
