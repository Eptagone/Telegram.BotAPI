// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	///<summary>Represents a chat member that is under certain restrictions in the chat. Supergroups only.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ChatMemberRestricted : ChatMember, IEquatable<ChatMemberRestricted>
	{
		///<summary>The member's status in the chat, always “restricted”.</summary>
		[JsonPropertyName(PropertyNames.Status)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Status => ChatMemberStatus.Restricted;
		///<summary>True, if the user is a member of the chat at the moment of the request.</summary>
		[JsonPropertyName(PropertyNames.IsMember)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool IsMember { get; set; }
		///<summary>True, if the user is allowed to change the chat title, photo and other settings.</summary>
		[JsonPropertyName(PropertyNames.CanChangeInfo)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanChangeInfo { get; set; }
		///<summary>True, if the user is allowed to invite new users to the chat.</summary>
		[JsonPropertyName(PropertyNames.CanInviteUsers)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanInviteUsers { get; set; }
		///<summary>True, if the user is allowed to pin messages; groups and supergroups only.</summary>
		[JsonPropertyName(PropertyNames.CanPinMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanPinMessages { get; set; }
		/// <summary>
		/// True, if the user is allowed to create forum topics
		/// </summary>
		[JsonPropertyName(PropertyNames.CanManageTopics)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? CanManageTopics { get; set; }
		///<summary>True, if the user is allowed to send text messages, contacts, locations and venues.</summary>
		[JsonPropertyName(PropertyNames.CanSendMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendMessages { get; set; }
		///<summary>True, if the user is allowed to send audios, documents, photos, videos, video notes and voice notes.</summary>
		[JsonPropertyName(PropertyNames.CanSendMediaMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendMediaMessages { get; set; }
		///<summary>True, if the user is allowed to send polls.</summary>
		[JsonPropertyName(PropertyNames.CanSendPolls)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendPolls { get; set; }
		///<summary>True, if the user is allowed to send animations, games, stickers and use inline bots.</summary>
		[JsonPropertyName(PropertyNames.CanSendOtherMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendOtherMessages { get; set; }
		///<summary>True, if the user is allowed to add web page previews to their messages.</summary>
		[JsonPropertyName(PropertyNames.CanAddWebPagePreviews)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanAddWebPagePreviews { get; set; }
		///<summary>Date when restrictions will be lifted for this user; unix time.</summary>
		[JsonPropertyName(PropertyNames.UntilDate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint UntilDate { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ChatMemberRestricted);
		}
		/// <inheritdoc/>
		public bool Equals(ChatMemberRestricted? other)
		{
			return other is not null &&
				   this.Status == other.Status &&
				   EqualityComparer<User>.Default.Equals(this.User, other.User) &&
				   this.Status == other.Status &&
				   this.IsMember == other.IsMember &&
				   this.CanChangeInfo == other.CanChangeInfo &&
				   this.CanInviteUsers == other.CanInviteUsers &&
				   this.CanPinMessages == other.CanPinMessages &&
				   this.CanManageTopics == other.CanManageTopics &&
				   this.CanSendMessages == other.CanSendMessages &&
				   this.CanSendMediaMessages == other.CanSendMediaMessages &&
				   this.CanSendPolls == other.CanSendPolls &&
				   this.CanSendOtherMessages == other.CanSendOtherMessages &&
				   this.CanAddWebPagePreviews == other.CanAddWebPagePreviews &&
				   this.UntilDate == other.UntilDate;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1957976061;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Status);
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.User);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Status);
			hashCode = hashCode * -1521134295 + this.IsMember.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanChangeInfo.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanInviteUsers.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanPinMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanManageTopics.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendMediaMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendPolls.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendOtherMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanAddWebPagePreviews.GetHashCode();
			hashCode = hashCode * -1521134295 + this.UntilDate.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ChatMemberRestricted? left, ChatMemberRestricted? right)
		{
			return EqualityComparer<ChatMemberRestricted>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ChatMemberRestricted? left, ChatMemberRestricted? right)
		{
			return !(left == right);
		}

	}
}
