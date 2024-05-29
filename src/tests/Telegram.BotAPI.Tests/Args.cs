// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Tests;

public sealed class Args
{
    [Theory]
    [InlineData(777000, "Pizza", "pepperoni, ham, cheese", "pizza", "PROVIDER TOKEN", "USD")]
    [InlineData(123456789, "Burger", "ham, avocado, cheese", "burger", "PROVIDER TOKEN", "USD")]
    public void SendInvoice(
        long chatId,
        string title,
        string description,
        string payload,
        string providerToken,
        string currency
    )
    {
        var prices = new LabeledPrice[] { new("Large", 499), new("Small", 199) };
        var invoiceArgs = new SendInvoiceArgs(chatId, title, description, payload, currency, prices)
        {
            ProviderToken = providerToken
        };
        Assert.IsType<long>(invoiceArgs.ChatId);
    }
}
