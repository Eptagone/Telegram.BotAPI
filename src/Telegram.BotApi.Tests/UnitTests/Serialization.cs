using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.Games;
using Xunit;
using Xunit.Abstractions;

namespace UnitTests
{
    public sealed class Serialization
    {
        private static JsonSerializerOptions options = new()
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
		};

		private readonly ITestOutputHelper _outputHelper;

        public Serialization(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void SerializeAnyObject()
        {
            var obj = new EditMessageLiveLocationArgs()
            {
                ChatId = 1
            };

            var rawText = JsonSerializer.Serialize(obj, options);
            _outputHelper.WriteLine(rawText);
        }
        
        [Fact]
        public void SerializeInlineButton()
        {
            var button = InlineKeyboardButton.SetCallbackData("Callback Button", "callback query");

            var rawText = JsonSerializer.Serialize(button, options);
            _outputHelper.WriteLine(rawText);
        }

        [Fact]
        public void SerializeSendGameArgs()
        {
            var args = new SendGameArgs(777777, "Welcome to my game");

			var rawText = JsonSerializer.Serialize(args, options);
			_outputHelper.WriteLine(rawText);
		}
    }
}
