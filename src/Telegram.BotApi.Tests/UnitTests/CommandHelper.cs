using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Telegram.BotAPI;

namespace UnitTests
{
    public class CommandHelper
    {
        private readonly ITestOutputHelper _outputHelper;
        private IBotProperties _botProperties;

        public CommandHelper(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _botProperties = new FakeBotProperties();
        }

        [Theory]
        [InlineData("/cmd")]
        [InlineData("/cmd hello world")]
        [InlineData("Not a command")]
        [InlineData("/cmd@OtherBot")]
        [InlineData("/cmd@OtherBot param1 param2")]
        [InlineData("/cmd@FakeBot")]
        [InlineData("/cmd@FakeBot param1 param2")]
        public void MatchCommand(string text)
        {
            _outputHelper.WriteLine("Input text: {0}", text);
            
            var match = _botProperties.CommandHelper.Match(text);
            if (match.Success)
            {
                _outputHelper.WriteLine("New command: {0}, Parameters: {1}", match.Name, match.Params);
            }
            else
            {
                _outputHelper.WriteLine("It's not a command or it's not for me.");
            }
        }

        [Theory]
        [InlineData("Hello world!")]
        [InlineData("Two args")]
        [InlineData("'This is a single parameter'")]
        [InlineData("--paramName \"My parameter value\"")]
        [InlineData("--paramName 'My parameter value'")]
        [InlineData("--paramName \"Wrong value'")]
        public void MatchParams(string @params)
{
            _outputHelper.WriteLine("Input text: {0}", @params);

            var args = _botProperties.CommandHelper.MatchArgs(@params);

            _outputHelper.WriteLine("{0} parameters has been detected", args.Count());
            foreach (var arg in args)
            {
                _outputHelper.WriteLine(arg);
            }
        }
    }
}
