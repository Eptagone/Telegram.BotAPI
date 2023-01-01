// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace UnitTests
{
	internal class FakeBotProperties : IBotProperties
	{
		public FakeBotProperties()
		{
			this.User = new User()
			{
				FirstName = "Fake bot",
				Username = "FakeBot",
				IsBot = true
			};
			this.CommandHelper = new BotCommandHelper(this, true);
		}

		public BotClient Api => throw new NotImplementedException();

		public User User { get; }
		public BotCommandHelper CommandHelper { get; }

		IBotCommandHelper IBotProperties.CommandHelper => this.CommandHelper;
	}
}
