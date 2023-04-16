// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Linq;

namespace UnitTests;

public class CommandHelper
{
	private readonly ITestOutputHelper _outputHelper;
	private IBotProperties _botProperties;

	public CommandHelper(ITestOutputHelper outputHelper)
	{
		this._outputHelper = outputHelper;
		this._botProperties = new FakeBotProperties();
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
		this._outputHelper.WriteLine("Input text: {0}", text);

		var match = this._botProperties.CommandHelper.Match(text);
		if (match.Success)
		{
			this._outputHelper.WriteLine("New command: {0}, Parameters: {1}", match.Name, match.Params);
		}
		else
		{
			this._outputHelper.WriteLine("It's not a command or it's not for me.");
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
		this._outputHelper.WriteLine("Input text: {0}", @params);

		var args = BotCommandHelper.MatchParameters(@params);

		this._outputHelper.WriteLine("{0} parameters has been detected", args.Count());
		foreach (var arg in args)
		{
			this._outputHelper.WriteLine(arg);
		}
	}
}
