// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Extensions.Commands;

namespace Telegram.BotAPI.Tests;

public sealed class CommandParserTests
{
    [Theory]
    [InlineData(@"/start", "start")]
    [InlineData(@"/help", "help")]
    [InlineData(@"/example@potato", "example")]
    [InlineData(@"/potato@robert", "potato")]
    [InlineData(@"/potato@robert cat", "potato")]
    public void ParseCommandName(string text, string expectedCommandName)
    {
        var (commandName, _, _) = BotCommandParser.Parse(text);
        Assert.Equal(expectedCommandName, commandName);
    }

    [Theory]
    [InlineData(@"/start", "")]
    [InlineData(@"/help", "")]
    [InlineData(@"/example@potato", "")]
    [InlineData(@"/potato@robert", "")]
    [InlineData(@"/potato@robert cat", "cat")]
    public void ParseParameters(string text, string expectedParameters)
    {
        var (_, parameters, _) = BotCommandParser.Parse(text);
        Assert.Equal(expectedParameters, parameters);
    }

    [Theory]
    [InlineData(@"/start", "")]
    [InlineData(@"/help", "")]
    [InlineData(@"/example@potato", "potato")]
    [InlineData(@"/potato@robert", "robert")]
    [InlineData(@"/potato@robert cat", "robert")]
    public void ParseUsername(string text, string expectedUsername)
    {
        var (_, _, username) = BotCommandParser.Parse(text);
        Assert.Equal(expectedUsername, username);
    }

    [Theory]
    [InlineData(@"Hello world")]
    [InlineData(@"A cat driver")]
    [InlineData(@"!badcommand")]
    [InlineData(@"the command is /commandName")]
    public void FailParse(string text)
    {
        Assert.Throws<ArgumentException>(() => BotCommandParser.Parse(text));
    }

    [Theory]
    [InlineData(@"Hello world", false)]
    [InlineData(@"", false)]
    [InlineData(@"!badcommand", false)]
    [InlineData(@"the command is /commandName", false)]
    [InlineData(@"/start", true)]
    [InlineData(@"/help", true)]
    [InlineData(@"/example@potato", true)]
    [InlineData(@"/potato@robert", true)]
    [InlineData(@"/potato@robert cat", true)]
    public void TryParse(string text, bool expectedResult)
    {
        Assert.Equal(expectedResult, BotCommandParser.TryParse(text, out _));
    }
}
