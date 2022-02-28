using System;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableTypes;

namespace UnitTests
{
    internal class FakeBotProperties : IBotProperties
    {
        public FakeBotProperties()
        {
            User = new User()
            {
                FirstName = "Fake bot",
                Username = "FakeBot",
                IsBot = true
            };
            CommandHelper = new BotCommandHelper(this, true);
        }

        public BotClient Api => throw new NotImplementedException();

        public User User { get; }
        public BotCommandHelper CommandHelper { get; }
    }
}
