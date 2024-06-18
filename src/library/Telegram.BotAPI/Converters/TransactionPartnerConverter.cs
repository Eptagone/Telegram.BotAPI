﻿// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI.Converters;

/// <summary>
/// Converts an <see cref="TransactionPartner"/> to or from JSON.
/// </summary>
public sealed class TransactionPartnerConverter : DiscriminatorJsonConverter<TransactionPartner>
{
    /// <inheritdoc />
    public override string PropertyName => PropertyNames.Type;
}
