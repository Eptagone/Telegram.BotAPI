// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object describes the source of a transaction, or its recipient for outgoing transactions. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="TransactionPartnerUser"/></description></item>
/// <item><description><see cref="TransactionPartnerFragment"/></description></item>
/// <item><description><see cref="TransactionPartnerTelegramAds"/></description></item>
/// <item><description><see cref="TransactionPartnerOther"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(TransactionPartnerConverter))]
public abstract class TransactionPartner
{
    /// <summary>
    /// Type of the transaction partner
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
