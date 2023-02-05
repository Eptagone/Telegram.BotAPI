// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>
	/// Represents a chat member that is under certain restrictions in the chat. Supergroups only.
	/// </summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ChatMemberRestricted : ChatMember, IEquatable<ChatMemberRestricted?>
	{
		/// <summary>
		/// The member's status in the chat, always “restricted”
		/// </summary>
		[JsonPropertyName(PropertyNames.Status)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Status => ChatMemberStatus.Restricted;
		/// <summary>
		/// True, if the user is a member of the chat at the moment of the request
		/// </summary>
		[JsonPropertyName(PropertyNames.IsMember)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool IsMember { get; set; }
		/// <summary>
		/// True, if the user is allowed to send text messages, contacts, invoices, locations and venues
		/// </summary>
		[JsonPropertyName(PropertyNames.CanSendMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendMessages { get; set; }
		/// <summary>
		/// True, if the user is allowed to send audios
		/// </summary>
		[JsonPropertyName(PropertyNames.CanSendAudios)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendAudios { get; set; }
		/// <summary>
		/// True, if the user is allowed to send documents
		/// </summary>
		[JsonPropertyName(PropertyNames.CanSendDocuments)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendDocuments { get; set; }
		/// <summary>
		/// True, if the user is allowed to send photos
		/// </summary>
		[JsonPropertyName(PropertyNames.CanSendPhotos)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendPhotos { get; set; }
		/// <summary>
		/// True, if the user is allowed to send videos
		/// </summary>
		[JsonPropertyName(PropertyNames.CanSendVideos)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendVideos { get; set; }
		/// <summary>
		/// True, if the user is allowed to send video notes
		/// </summary>
		[JsonPropertyName(PropertyNames.CanSendVideoNotes)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendVideoNotes { get; set; }
		/// <summary>
		/// True, if the user is allowed to send voice notes
		/// </summary>
		[JsonPropertyName(PropertyNames.CanSendVoiceNotes)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendVoiceNotes { get; set; }
		/// <summary>
		/// True, if the user is allowed to send polls
		/// </summary>
		[JsonPropertyName(PropertyNames.CanSendPolls)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendPolls { get; set; }
		/// <summary>
		/// True, if the user is allowed to send animations, games, stickers and use inline bots
		/// </summary>
		[JsonPropertyName(PropertyNames.CanSendOtherMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanSendOtherMessages { get; set; }
		/// <summary>
		/// True, if the user is allowed to add web page previews to their messages
		/// </summary>
		[JsonPropertyName(PropertyNames.CanAddWebPagePreviews)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanAddWebPagePreviews { get; set; }
		/// <summary>
		/// True, if the user is allowed to change the chat title, photo and other settings
		/// </summary>
		[JsonPropertyName(PropertyNames.CanChangeInfo)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanChangeInfo { get; set; }
		/// <summary>
		/// True, if the user is allowed to invite new users to the chat
		/// </summary>
		[JsonPropertyName(PropertyNames.CanInviteUsers)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanInviteUsers { get; set; }
		/// <summary>
		/// True, if the user is allowed to pin messages
		/// </summary>
		[JsonPropertyName(PropertyNames.CanPinMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanPinMessages { get; set; }
		/// <summary>
		/// True, if the user is allowed to create forum topics
		/// </summary>
		[JsonPropertyName(PropertyNames.CanManageTopics)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanManageTopics { get; set; }
		/// <summary>
		/// Date when restrictions will be lifted for this user; unix time. If 0, then the user is restricted forever
		/// </summary>
		[JsonPropertyName(PropertyNames.UntilDate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int UntilDate { get; set; }

		/// <inheritdoc/>
		public override bool Equals(object? obj)
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
				   this.CanSendMessages == other.CanSendMessages &&
				   this.CanSendAudios == other.CanSendAudios &&
				   this.CanSendDocuments == other.CanSendDocuments &&
				   this.CanSendPhotos == other.CanSendPhotos &&
				   this.CanSendVideos == other.CanSendVideos &&
				   this.CanSendVideoNotes == other.CanSendVideoNotes &&
				   this.CanSendVoiceNotes == other.CanSendVoiceNotes &&
				   this.CanSendPolls == other.CanSendPolls &&
				   this.CanSendOtherMessages == other.CanSendOtherMessages &&
				   this.CanAddWebPagePreviews == other.CanAddWebPagePreviews &&
				   this.CanChangeInfo == other.CanChangeInfo &&
				   this.CanInviteUsers == other.CanInviteUsers &&
				   this.CanPinMessages == other.CanPinMessages &&
				   this.CanManageTopics == other.CanManageTopics &&
				   this.UntilDate == other.UntilDate;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1749013427;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Status);
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.User);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Status);
			hashCode = hashCode * -1521134295 + this.IsMember.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendAudios.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendDocuments.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendPhotos.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendVideos.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendVideoNotes.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendVoiceNotes.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendPolls.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanSendOtherMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanAddWebPagePreviews.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanChangeInfo.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanInviteUsers.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanPinMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanManageTopics.GetHashCode();
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
