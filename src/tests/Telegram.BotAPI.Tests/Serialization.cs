// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.UpdatingMessages;

namespace Telegram.BotAPI.Tests;

public sealed class Serialization(ITestOutputHelper outputHelper)
{
	private static readonly JsonSerializerOptions options =
		new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

	private readonly ITestOutputHelper _outputHelper = outputHelper;

	[Fact]
	public void SerializeAnyObject()
	{
		var obj = new EditMessageLiveLocationArgs(1, 0);

		var rawText = JsonSerializer.Serialize(obj, options);
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
