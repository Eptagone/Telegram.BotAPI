// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Tests;

public sealed class Serialization
{
	private static JsonSerializerOptions options = new()
	{
		DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
	};

	private readonly ITestOutputHelper _outputHelper;

	public Serialization(ITestOutputHelper outputHelper) => this._outputHelper = outputHelper;

	[Fact]
	public void SerializeAnyObject()
	{
		var obj = new EditMessageLiveLocationArgs(0, 0)
		{
			ChatId = 1
		};

		var rawText = JsonSerializer.Serialize(obj, options);
		this._outputHelper.WriteLine(rawText);
	}

	[Fact]
	public void SerializeInlineButton()
	{
		var button = InlineKeyboardButton.SetCallbackData("Callback Button", "callback query");

		var rawText = JsonSerializer.Serialize(button, options);
		this._outputHelper.WriteLine(rawText);
	}

	[Fact]
	public void SerializeSendGameArgs()
	{
		var args = new SendGameArgs(777777, "Welcome to my game");

		var rawText = JsonSerializer.Serialize(args, options);
		this._outputHelper.WriteLine(rawText);
	}
}
