// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
	/// <summary>RestrictChatMember method summaryeters.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class RestrictChatMemberArgs
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RestrictChatMemberArgs"/> class.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="userId">Unique identifier of the target user.</param>
		/// <param name="permissions">New user permissions.</param>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="chatId"/> or <paramref name="userId"/> or <paramref name="permissions"/> is null.</exception>
		public RestrictChatMemberArgs(long chatId, long userId, ChatPermissions permissions)
		{
			this.ChatId = chatId;
			this.UserId = userId;
			this.Permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="RestrictChatMemberArgs"/> class.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="userId">Unique identifier of the target user.</param>
		/// <param name="permissions">New user permissions.</param>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="chatId"/> or <paramref name="userId"/> or <paramref name="permissions"/> is null.</exception>
		public RestrictChatMemberArgs(string chatId, long userId, ChatPermissions permissions)
		{
			this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
			this.UserId = userId;
			this.Permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
		}

		/// <summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
		[JsonPropertyName(PropertyNames.ChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object ChatId { get; }
		/// <summary>Unique identifier of the target user.</summary>
		[JsonPropertyName(PropertyNames.UserId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public long UserId { get; }
		/// <summary>New user permissions.</summary>
		[JsonPropertyName(PropertyNames.Permissions)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ChatPermissions Permissions { get; }
		/// <summary>Optional. Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever.</summary>
		[JsonPropertyName(PropertyNames.UntilDate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? UntilDate { get; set; }
	}
}
