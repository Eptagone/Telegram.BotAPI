﻿// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>Converts an <see cref="InputStoryContent"/> to or from JSON.</summary>
public sealed class InputStoryContentConverter : DiscriminatorJsonConverter<InputStoryContent>
{
	/// <inheritdoc />
	public override string PropertyName => PropertyNames.Type;
}
