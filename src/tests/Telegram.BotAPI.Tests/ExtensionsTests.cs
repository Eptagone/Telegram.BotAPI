// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Extensions;
using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI.Tests;

public sealed class ExtensionsTests
{
	[Theory]
	[InlineData(
		@"{""update_id"":1,""message"":{""message_id"":1,""date"":1,""chat"":{""id"":1,""type"":""private""},""text"":""test""}}",
		"message"
	)]
	[InlineData(
		@"{""update_id"":1,""edited_message"":{""message_id"":1,""date"":1,""chat"":{""id"":1,""type"":""private""},""text"":""test""}}",
		"edited_message"
	)]
	public void GetUpdateType(string jsonUpdate, string updateType)
	{
		var update = JsonSerializer.Deserialize<Update>(jsonUpdate);
		var uType = update.GetUpdateType();
		Assert.Equal(uType, updateType);
	}

	[Fact]
	public void BuildInlineKeyboard()
	{
		InlineKeyboardButton[][] keyboard = new InlineKeyboardBuilder()
			.AppendUrl("Google", "https://www.google.com")
			.AppendCallbackData("Callback", "callback")
			.AppendWebApp("WebApp", new WebAppInfo("https://www.google.com"))
			.AppendLoginUrl("Login", new LoginUrl("https://www.google.com"))
			.AppendRow()
			.AppendUrl("Google", "https://www.google.com");

		Assert.Equal(2, keyboard.Length);
		Assert.Equal(4, keyboard[0].Length);
		Assert.Single(keyboard[1]);

		var json = JsonSerializer.Serialize(
			keyboard,
			new JsonSerializerOptions
			{
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
			}
		);
		Assert.Equal(
			@"[[{""text"":""Google"",""url"":""https://www.google.com""},{""text"":""Callback"",""callback_data"":""callback""},{""text"":""WebApp"",""web_app"":{""url"":""https://www.google.com""}},{""text"":""Login"",""login_url"":{""url"":""https://www.google.com""}}],[{""text"":""Google"",""url"":""https://www.google.com""}]]",
			json
		);
	}
}
