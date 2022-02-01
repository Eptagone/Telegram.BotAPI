using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;
using Xunit;
using Xunit.Abstractions;

namespace UnitTests
{
    public sealed class Serialization
    {
        private readonly ITestOutputHelper _outputHelper;

        public Serialization(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void SerializeAnyObject()
        {
            var obj = new EditMessageLiveLocationArgs()
            {
                ChatId = 1
            };

            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            var rawText = JsonSerializer.Serialize(obj, options);
            _outputHelper.WriteLine(rawText);
        }
    }
}
