// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>This object represents the content of a message to be sent as a result of an inline query. Telegram clients currently support the following 5 types: <br /><br />
    /// • <see cref="InputTextMessageContent"/><br />
    /// • <see cref="InputLocationMessageContent"/><br />
    /// • <see cref="InputVenueMessageContent"/><br />
    /// • <see cref="InputContactMessageContent"/><br />
    /// • <see cref="InputInvoiceMessageContent"/></summary>
    [JsonConverter(typeof(InputMessageContentConverter))]
    public abstract class InputMessageContent
    {
        // Base empty class
    }
}
