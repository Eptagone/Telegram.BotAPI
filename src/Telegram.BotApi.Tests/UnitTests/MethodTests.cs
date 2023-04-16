// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace UnitTests;

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

	[Fact]
	public void EqualOperator()
	{
		var instance1 = new Message();
		var instance2 = new Message();
		Message nullInstance1 = null;
		Message nullInstance2 = null;

		Assert.True(nullInstance1 == nullInstance2);
		Assert.False(instance1 == nullInstance2);
		Assert.False(nullInstance1 == instance2);
		Assert.False(instance1.Equals(null));
		Assert.False(null == instance2);
		Assert.False(instance1 == null);
		Assert.True(instance1 == instance2);
	}
}
