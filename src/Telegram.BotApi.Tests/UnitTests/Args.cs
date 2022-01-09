using Telegram.BotAPI.Payments;
using Xunit;
using Xunit.Abstractions;

namespace UnitTests
{
    public sealed class Args
    {
        private readonly ITestOutputHelper _outputHelper;
        public Args(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Theory]
        [InlineData(777000, "Pizza", "pepperoni, ham, cheese", "pizza", "PROVIDER TOKEN", "USD")]
        [InlineData(123456789, "Burger", "ham, avocado, cheese", "burger", "PROVIDER TOKEN", "USD")]
        public void SendInvoice(long chatId, string title, string description, string payload, string providerToken, string currency)
        {
            var prices = new LabeledPrice[] { new LabeledPrice("Large", 499), new LabeledPrice("Small", 199) };
            var invoiceArgs = new SendInvoiceArgs(chatId, title, description, payload, providerToken, currency, prices);
            Assert.IsType<long>(invoiceArgs.ChatId);
        }
    }
}
