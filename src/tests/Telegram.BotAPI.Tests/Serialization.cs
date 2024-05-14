// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.UpdatingMessages;

namespace Telegram.BotAPI.Tests;

public sealed class Serialization(ITestOutputHelper outputHelper)
{
    private static readonly JsonSerializerOptions options =
        new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

    private readonly ITestOutputHelper _outputHelper = outputHelper;

    [Fact]
    public void SerializeEditMessageLiveLocationArgs()
    {
        var obj = new EditMessageLiveLocationArgs(1, 0);

        var rawText = JsonSerializer.Serialize(obj, options);
        this._outputHelper.WriteLine(rawText);
    }

    [Fact]
    public void SerializeReplyMarkup()
    {
        ReplyMarkup obj = new InlineKeyboardMarkup(
            [
                [new InlineKeyboardButton("Button") { CallbackData = "data" }]
            ]
        );

        var rawText = JsonSerializer.Serialize(obj, options);
        this._outputHelper.WriteLine(rawText);
        var deserializeMarkup = JsonSerializer.Deserialize<ReplyMarkup>(rawText, options);
        Assert.IsType<InlineKeyboardMarkup>(deserializeMarkup);
        var inlineKeyboard = ((InlineKeyboardMarkup)deserializeMarkup).InlineKeyboard;
        Assert.Equal("Button", inlineKeyboard.First().First().Text);
        Assert.Equal("data", inlineKeyboard.First().First().CallbackData);
    }

    [Fact]
    public void SerializeSendGameArgs()
    {
        var args = new SendGameArgs(777777, "Welcome to my game");

        var rawText = JsonSerializer.Serialize(args, options);
        this._outputHelper.WriteLine(rawText);
        var deserializeArgs = JsonSerializer.Deserialize<SendGameArgs>(rawText, options);
        Assert.Equal(777777, deserializeArgs.ChatId);
        Assert.Equal("Welcome to my game", deserializeArgs.GameShortName);
    }

    [Fact]
    public void SerializeQueryResultWithTextMessageContent()
    {
        var result = new InlineQueryResultArticle
        {
            Id = "1",
            Title = "Title",
            InputMessageContent = new InputTextMessageContent("Hello, World!")
            {
                ParseMode = "MarkdownV2"
            },
            ReplyMarkup = new InlineKeyboardMarkup(
                [
                    [new InlineKeyboardButton("Button") { CallbackData = "data" }]
                ]
            )
        };

        var rawText = JsonSerializer.Serialize(result, options);
        this._outputHelper.WriteLine(rawText);
        var deserializeResult = JsonSerializer.Deserialize<InlineQueryResult>(rawText, options);
        Assert.IsType<InlineQueryResultArticle>(deserializeResult);
        Assert.Equal(
            "data",
            deserializeResult.ReplyMarkup.InlineKeyboard.First().First().CallbackData
        );
        Assert.IsType<InputTextMessageContent>(
            ((InlineQueryResultArticle)deserializeResult).InputMessageContent
        );
        Assert.Equal(
            "Hello, World!",
            (
                (InputTextMessageContent)
                    ((InlineQueryResultArticle)deserializeResult).InputMessageContent
            ).MessageText
        );
    }
}
