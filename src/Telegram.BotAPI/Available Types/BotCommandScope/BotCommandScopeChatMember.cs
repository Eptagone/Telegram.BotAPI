// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>Represents the scope of bot commands, covering a specific member of a group or supergroup chat.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class BotCommandScopeChatMember : BotCommandScope, IEquatable<BotCommandScopeChatMember>
	{
		/// <summary>Inititalize a new instance of <see cref="BotCommandScopeChatMember"/>.</summary>
		public BotCommandScopeChatMember()
		{
		}
		/// <summary>Inititalize a new instance of <see cref="BotCommandScopeChatMember"/>.</summary>
		/// <param name="chatId"><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="userId">Unique identifier of the target user.</param>
		public BotCommandScopeChatMember(string chatId, long userId)
		{
			this.ChatId = chatId;
			this.UserId = userId;
		}
		/// <summary>Inititalize a new instance of <see cref="BotCommandScopeChatMember"/>.</summary>
		/// <param name="chatId"><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="userId">Unique identifier of the target user.</param>
		public BotCommandScopeChatMember(long chatId, long userId)
		{
			this.ChatId = chatId;
			this.UserId = userId;
		}
		/// <summary>Scope type, must be chat_member.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => BotCommandScopeType.ChatMember;
		/// <summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
		[JsonPropertyName(PropertyNames.ChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object ChatId { get; set; }
		/// <summary>Unique identifier of the target user.</summary>
		[JsonPropertyName(PropertyNames.UserId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public long UserId { get; set; }

		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as BotCommandScopeChatMember);
		}
		/// <inheritdoc/>
		public bool Equals(BotCommandScopeChatMember? other)
		{
			return other != null &&
				   EqualityComparer<object>.Default.Equals(this.ChatId, other.ChatId) &&
				   this.UserId == other.UserId;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -329865067;
			hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(this.ChatId);
			hashCode = hashCode * -1521134295 + this.UserId.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(BotCommandScopeChatMember? left, BotCommandScopeChatMember? right)
		{
			return EqualityComparer<BotCommandScopeChatMember>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(BotCommandScopeChatMember? left, BotCommandScopeChatMember? right)
		{
			return !(left == right);
		}
	}
}
