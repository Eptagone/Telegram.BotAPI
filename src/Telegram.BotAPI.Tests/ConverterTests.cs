// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using System.Text.Json.Serialization;
using IKB = Telegram.BotAPI.AvailableTypes.InlineKeyboardButton;
using IKM = Telegram.BotAPI.AvailableTypes.InlineKeyboardMarkup;
using KB = Telegram.BotAPI.AvailableTypes.KeyboardButton;
using RKM = Telegram.BotAPI.AvailableTypes.ReplyKeyboardMarkup;
using RKR = Telegram.BotAPI.AvailableTypes.ReplyKeyboardRemove;

namespace Telegram.BotAPI.Tests;

public sealed class ConverterTests
{
	private readonly ITestOutputHelper _outputHelper;

	public ConverterTests(ITestOutputHelper outputHelper) => this._outputHelper = outputHelper;

	[Theory]
	[InlineData(@"{
      ""user"": {
        ""id"": 777000,
        ""is_bot"": false,
        ""first_name"": ""Telegram"",
        ""username"": ""Telegram"",
        ""language_code"": ""en""
      },
      ""status"": ""creator"",
      ""custom_title"": ""T"",
      ""is_anonymous"": false
    }")]
	[InlineData(@"{
      ""user"": {
        ""id"": 777000,
        ""is_bot"": false,
        ""first_name"": ""Telegram""
      },
      ""status"": ""member""
    }")]
	[InlineData(@"{
      ""user"": {
        ""id"": 2383311034,
        ""is_bot"": false,
        ""first_name"": ""♡︎mori"",
        ""username"": ""user""
      },
      ""status"": ""administrator"",
      ""can_be_edited"": false,
      ""can_manage_chat"": true,
      ""can_change_info"": true,
      ""can_delete_messages"": true,
      ""can_invite_users"": true,
      ""can_restrict_members"": true,
      ""can_pin_messages"": true,
      ""can_promote_members"": false,
      ""can_manage_voice_chats"": true,
      ""is_anonymous"": false
    }")]
	public void DeserializeChatMemberReturnsIChatMember(string jsonChatMember)
	{
		var chatMember = JsonSerializer.Deserialize<ChatMember>(jsonChatMember);
		switch (chatMember.Status)
		{
			case ChatMemberStatus.Member:
				Assert.IsType<ChatMemberMember>(chatMember);
				break;
			case ChatMemberStatus.Kicked:
				Assert.IsType<ChatMemberBanned>(chatMember);
				break;
			case ChatMemberStatus.Administrator:
				Assert.IsType<ChatMemberAdministrator>(chatMember);
				break;
			case ChatMemberStatus.Creator:
				Assert.IsType<ChatMemberOwner>(chatMember);
				break;
			case ChatMemberStatus.Restricted:
				Assert.IsType<ChatMemberRestricted>(chatMember);
				break;
			case ChatMemberStatus.Left:
				Assert.IsType<ChatMemberLeft>(chatMember);
				break;
			default:
				break;
		}
	}

	[Fact]
	public void SerializeChatMemberReturnsJsonString()
	{
		var members = new ChatMember[]
		{
			new ChatMemberMember
			{
				User = new User
					{
						Id = 777000,
						FirstName = "Telegram",
						IsBot = false
					}
			},
			new ChatMemberBanned
			{
				User = new User
					{
						Id = 777000,
						FirstName = "Sadman",
						IsBot = false
					},
				UntilDate = 3819829182
			},
			new ChatMemberOwner
			{
				CustomTitle = "God",
				User = new User
					{
						Id = 777000,
						FirstName = "Telegram",
						IsBot = false
					}
			},
			new ChatMemberAdministrator
			{
				CustomTitle = "Duckman",
				User = new User
					{
						Id = 777000,
						FirstName = "Cat-Dog ♡︎",
						IsBot = false
					},
				CanBeEdited = true,
				CanRestrictMembers = true,
				CanManageVideoChats = true
			}
		};
		var options = new JsonSerializerOptions
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
		};
		foreach (var chatMember in members)
		{
			var jsonObject = JsonSerializer.Serialize(chatMember, options);
			this._outputHelper.WriteLine(jsonObject);
			Assert.NotNull(jsonObject);
		}
	}

	[Theory]
	[InlineData(777000, "Hello world")]
	[InlineData(123456789, "Hello world Again")]
	public void SerializeSendMessageArgsWithReplyMarkup(long chatId, string text)
	{
		var argsInline = new SendMessageArgs(chatId, text)
		{
			ReplyMarkup = new IKM
			{
				InlineKeyboard = new IKB[][]
				{
					new IKB[]
					{
						IKB.SetCallbackData("Your text", text),
						IKB.SetCallbackData("Your chatId", chatId.ToString())
					},
					new IKB[]
					{
						IKB.SetCallbackData("Your text", text)
					}
				}
			}
		};
		Assert.True(argsInline.ReplyMarkup is ReplyMarkup);
		var argsReply = new SendMessageArgs(chatId, text)
		{
			ReplyMarkup = new RKM
			{
				Keyboard = new KB[][]
				{
					new KB[]
					{
						new KB(text),
						new KB(chatId.ToString()){
							RequestLocation = true,
							RequestPoll = new KeyboardButtonPollType{
								Type = PollType.Quiz
							}
						}
					},
					new KB[]
					{
						new KB(text)
					}
				}
			}
		};
		Assert.True(argsReply.ReplyMarkup is ReplyMarkup);
		var argsRemove = new SendMessageArgs(chatId, text)
		{
			ReplyMarkup = new RKR()
		};
		Assert.True(argsRemove.ReplyMarkup is ReplyMarkup);
		var argsForceReply = new SendMessageArgs(chatId, text)
		{
			ReplyMarkup = new ForceReply()
		};
		Assert.True(argsForceReply.ReplyMarkup is ReplyMarkup);

		var options = new JsonSerializerOptions
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
		};

		var rawArgsInline = JsonSerializer.Serialize(argsInline, options);
		this._outputHelper.WriteLine(rawArgsInline);
		Assert.NotNull(rawArgsInline);
		var rawArgsReply = JsonSerializer.Serialize(argsReply, options);
		this._outputHelper.WriteLine(rawArgsReply);
		Assert.NotNull(rawArgsReply);
		var rawArgsRemove = JsonSerializer.Serialize(argsRemove, options);
		this._outputHelper.WriteLine(rawArgsRemove);
		Assert.NotNull(rawArgsRemove);
		var rawArgsFR = JsonSerializer.Serialize(argsForceReply, options);
		this._outputHelper.WriteLine(rawArgsFR);
		Assert.NotNull(rawArgsFR);
	}

	[Theory]
	[InlineData(777000, "PHOTO UwU")]
	[InlineData(123456789, "PHOTO")]
	public void SerializeSendPhotoArgsWithReplyMarkup(long chatId, string photo)
	{
		var argsInline = new SendPhotoArgs(chatId, photo)
		{
			ReplyMarkup = new IKM
			{
				InlineKeyboard = new IKB[][]
				{
					new IKB[]
					{
						IKB.SetCallbackData("Your text", photo),
						IKB.SetCallbackData("Your chatId", chatId.ToString())
					},
					new IKB[]
					{
						IKB.SetCallbackData("Your text", photo)
					}
				}
			}
		};
		Assert.True(argsInline.ReplyMarkup is ReplyMarkup);
		var argsReply = new SendPhotoArgs(chatId, photo)
		{
			ReplyMarkup = new RKM
			{
				Keyboard = new KB[][]
				{
					new KB[]
					{
						new KB(photo),
						new KB(chatId.ToString()){
							RequestLocation = true,
							RequestPoll = new KeyboardButtonPollType{
								Type = PollType.Quiz
							}
						}
					},
					new KB[]
					{
						new KB(photo)
					}
				}
			}
		};
		Assert.True(argsReply.ReplyMarkup is ReplyMarkup);
		var argsRemove = new SendPhotoArgs(chatId, photo)
		{
			ReplyMarkup = new RKR()
		};
		Assert.True(argsRemove.ReplyMarkup is ReplyMarkup);
		var argsForceReply = new SendPhotoArgs(chatId, photo)
		{
			ReplyMarkup = new ForceReply()
		};
		Assert.True(argsForceReply.ReplyMarkup is ReplyMarkup);

		var options = new JsonSerializerOptions
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
		};

		var rawArgsInline = JsonSerializer.Serialize(argsInline, options);
		this._outputHelper.WriteLine(rawArgsInline);
		Assert.NotNull(rawArgsInline);
		var rawArgsReply = JsonSerializer.Serialize(argsReply, options);
		this._outputHelper.WriteLine(rawArgsReply);
		Assert.NotNull(rawArgsReply);
		var rawArgsRemove = JsonSerializer.Serialize(argsRemove, options);
		this._outputHelper.WriteLine(rawArgsRemove);
		Assert.NotNull(rawArgsRemove);
		var rawArgsFR = JsonSerializer.Serialize(argsForceReply, options);
		this._outputHelper.WriteLine(rawArgsFR);
		Assert.NotNull(rawArgsFR);
	}

	[Fact]
	public void SerializeAndDeserializeInlineKeyboardMarkup()
	{
		var keyboard = new IKM
		{
			InlineKeyboard = new IKB[][]
				{
					new IKB[]
					{
						IKB.SetCallbackData("Your text", "example"),
						IKB.SetCallbackData("Your chatId", "example")
					},
					new IKB[]
					{
IKB.SetCallbackData("Your text", "example")
					}
				}
		};

		var options = new JsonSerializerOptions
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
		};

		var rawText = JsonSerializer.Serialize(keyboard, options);
		this._outputHelper.WriteLine(rawText);
		var keyboardAgain = JsonSerializer.Deserialize<IKM>(rawText, options);
		Assert.Equal(keyboard.InlineKeyboard, keyboardAgain.InlineKeyboard);
	}
}
