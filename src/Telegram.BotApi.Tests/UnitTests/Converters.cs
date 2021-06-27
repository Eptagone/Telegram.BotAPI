using Telegram.BotAPI.AvailableTypes;
using Xunit;
using System.Text.Json;
using Telegram.BotAPI.Converters;
using Xunit.Abstractions;

namespace UnitTests
{
    public sealed class Converters
    {
        private readonly ITestOutputHelper _outputHelper;

        public Converters(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

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
            var options = new JsonSerializerOptions();
            options.Converters.Add(new ChatMemberConverter());
            var chatMember = JsonSerializer.Deserialize<IChatMember>(jsonChatMember, options);
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
            var members = new IChatMember[]
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
                    CanManageVoiceChats = true
                }
            };
            var options = new JsonSerializerOptions();
            options.Converters.Add(new ChatMemberConverter());
            foreach (var chatMember in members)
            {
                var jsonObject = JsonSerializer.Serialize(chatMember, options);
                _outputHelper.WriteLine(jsonObject);
                Assert.NotNull(jsonObject);
            }
        }
    }
}
