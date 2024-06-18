// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Extensions;

namespace Telegram.BotAPI.Tests;

public sealed class ConverterTests(ITestOutputHelper outputHelper)
{
    private readonly ITestOutputHelper outputHelper = outputHelper;

    [Theory]
    [InlineData(
        @"{
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
    }"
    )]
    [InlineData(
        @"{
      ""user"": {
        ""id"": 777000,
        ""is_bot"": false,
        ""first_name"": ""Telegram""
      },
      ""status"": ""member""
    }"
    )]
    [InlineData(
        @"{
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
    }"
    )]
    public void DeserializeChatMember(string jsonChatMember)
    {
        var chatMember = JsonSerializer.Deserialize<ChatMember>(jsonChatMember);
        switch (chatMember.Status)
        {
            case "member":
                Assert.IsType<ChatMemberMember>(chatMember);
                break;
            case "kicked":
                Assert.IsType<ChatMemberBanned>(chatMember);
                break;
            case "administrator":
                Assert.IsType<ChatMemberAdministrator>(chatMember);
                break;
            case "creator":
                Assert.IsType<ChatMemberOwner>(chatMember);
                break;
            case "restricted":
                Assert.IsType<ChatMemberRestricted>(chatMember);
                break;
            case "left":
                Assert.IsType<ChatMemberLeft>(chatMember);
                break;
            default:
                break;
        }
    }

    [Theory]
    [InlineData(
        @"{
      ""type"": ""solid"",
      ""color"": 128
    }"
    )]
    [InlineData(
        @"{
      ""type"": ""gradient"",
      ""top_color"": 1,
      ""bottom_color"": 2,
      ""rotation_angle"": 3
    }"
    )]
    [InlineData(
        @"{
      ""type"": ""freeform_gradient"",
      ""colors"": [1,2,3]
    }"
    )]
    public void DeserializeBackgroundFill(string jsonBackgroundFill)
    {
        var chatMember = JsonSerializer.Deserialize<BackgroundFill>(jsonBackgroundFill);
        switch (chatMember.Type)
        {
            case "solid":
                Assert.IsType<BackgroundFillSolid>(chatMember);
                break;
            case "gradient":
                Assert.IsType<BackgroundFillGradient>(chatMember);
                break;
            case "freeform_gradient":
                Assert.IsType<BackgroundFillFreeformGradient>(chatMember);
                Assert.Equal(3, ((BackgroundFillFreeformGradient)chatMember).Colors.Count());
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
                UntilDate = (int)TimeSpan.FromSeconds(3819829182).TotalSeconds
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
            this.outputHelper.WriteLine(jsonObject);
            Assert.NotNull(jsonObject);
        }
    }

    [Fact]
    public void SerializeAndDeserializeInlineKeyboardMarkup()
    {
        var keyboard = new InlineKeyboardBuilder()
            .AppendCallbackData("Your text", "example")
            .AppendCallbackData("Your chatId", "example")
            .AppendRow()
            .AppendCallbackData("Your text", "example");
        var markup = new InlineKeyboardMarkup(keyboard);

        var options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var rawText = JsonSerializer.Serialize(markup, options);
        this.outputHelper.WriteLine(rawText);
        var keyboardAgain = JsonSerializer.Deserialize<InlineKeyboardMarkup>(rawText, options);
        Assert.Equal(rawText, JsonSerializer.Serialize(keyboardAgain, options));
    }

    [Fact]
    public void SerializeAndDeserializeTransactionPartner()
    {
        var partner = new TransactionPartnerFragment();
        var options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        var rawText = JsonSerializer.Serialize(partner, options);
        this.outputHelper.WriteLine(rawText);
        var partnerAgain = JsonSerializer.Deserialize<TransactionPartnerFragment>(rawText, options);
        Assert.Equal(rawText, JsonSerializer.Serialize(partnerAgain, options));
    }

    [Fact]
    public void SerializeAndDeserializeRevenueWithdrawalState()
    {
        var state = new RevenueWithdrawalStateSucceeded();

        var options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        var rawText = JsonSerializer.Serialize(state, options);
        this.outputHelper.WriteLine(rawText);
        var stateAgain = JsonSerializer.Deserialize<RevenueWithdrawalStateSucceeded>(
            rawText,
            options
        );
        Assert.Equal(rawText, JsonSerializer.Serialize(stateAgain, options));
    }
}
