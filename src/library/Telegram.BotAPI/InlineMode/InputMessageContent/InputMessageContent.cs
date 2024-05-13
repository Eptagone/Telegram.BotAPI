// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// This object represents the content of a message to be sent as a result of an inline query. Telegram clients currently support the following 5 types:
/// <list type="bullet">
/// <item><description><see cref="InputTextMessageContent"/></description></item>
/// <item><description><see cref="InputLocationMessageContent"/></description></item>
/// <item><description><see cref="InputVenueMessageContent"/></description></item>
/// <item><description><see cref="InputContactMessageContent"/></description></item>
/// <item><description><see cref="InputInvoiceMessageContent"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(InputMessageContentConverter))]
public abstract class InputMessageContent
{
}
