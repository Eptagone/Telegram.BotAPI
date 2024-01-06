// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Tests;

public sealed class MethodTests
{
	[Fact]
	public void SendMessageWithNullClient()
	{
		Assert.Throws<ArgumentNullException>(() =>
		{
			AvailableMethodsExtensions.SendMessage(null, 0, "Hello World");
		});
	}
}
