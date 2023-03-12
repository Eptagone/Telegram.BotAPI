// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>Represents a chat member that has some additional privileges.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ChatMemberAdministrator : ChatMember, IEquatable<ChatMemberAdministrator?>
	{
		///	<summary>
		///	The member's status in the chat, always “administrator”.
		/// </summary>
		[JsonPropertyName(PropertyNames.Status)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Status => ChatMemberStatus.Administrator;
		/// <summary>
		/// True, if the bot is allowed to edit administrator privileges of that user
		/// </summary>
		[JsonPropertyName(PropertyNames.CanBeEdited)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanBeEdited { get; set; }
		/// <summary>
		/// True, if the user's presence in the chat is hidden
		/// </summary>
		[JsonPropertyName(PropertyNames.IsAnonymous)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool IsAnonymous { get; set; }
		/// <summary>
		/// True, if the administrator can access the chat event log, chat statistics, message statistics in channels, see channel members, see anonymous administrators in supergroups and ignore slow mode. Implied by any other administrator privilege
		/// </summary>
		[JsonPropertyName(PropertyNames.CanManageChat)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanManageChat { get; set; }
		/// <summary>
		/// True, if the administrator can delete messages of other users
		/// </summary>
		[JsonPropertyName(PropertyNames.CanDeleteMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanDeleteMessages { get; set; }
		/// <summary>
		/// True, if the administrator can manage video chats
		/// </summary>
		[JsonPropertyName(PropertyNames.CanManageVideoChats)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanManageVideoChats { get; set; }
		/// <summary>
		/// True, if the administrator can restrict, ban or unban chat members
		/// </summary>
		[JsonPropertyName(PropertyNames.CanRestrictMembers)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanRestrictMembers { get; set; }
		/// <summary>
		/// True, if the administrator can add new administrators with a subset of their own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by the user)
		/// </summary>
		[JsonPropertyName(PropertyNames.CanPromoteMembers)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool CanPromoteMembers { get; set; }
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
		/// Optional. True, if the administrator can post in the channel; channels only
		/// </summary>
		[JsonPropertyName(PropertyNames.CanPostMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? CanPostMessages { get; set; }
		/// <summary>
		/// Optional. True, if the administrator can edit messages of other users and can pin messages; channels only
		/// </summary>
		[JsonPropertyName(PropertyNames.CanEditMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? CanEditMessages { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to pin messages; groups and supergroups only
		/// </summary>
		[JsonPropertyName(PropertyNames.CanPinMessages)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? CanPinMessages { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to create, rename, close, and reopen forum topics; supergroups only
		/// </summary>
		[JsonPropertyName(PropertyNames.CanManageTopics)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? CanManageTopics { get; set; }
		/// <summary>
		/// Optional. Custom title for this user
		/// </summary>
		[JsonPropertyName(PropertyNames.CustomTitle)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? CustomTitle { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as ChatMemberAdministrator);
		}
		/// <inheritdoc/>
		public bool Equals(ChatMemberAdministrator? other)
		{
			return other is not null &&
				   this.Status == other.Status &&
				   EqualityComparer<User>.Default.Equals(this.User, other.User) &&
				   this.Status == other.Status &&
				   this.CanBeEdited == other.CanBeEdited &&
				   this.IsAnonymous == other.IsAnonymous &&
				   this.CanManageChat == other.CanManageChat &&
				   this.CanDeleteMessages == other.CanDeleteMessages &&
				   this.CanManageVideoChats == other.CanManageVideoChats &&
				   this.CanRestrictMembers == other.CanRestrictMembers &&
				   this.CanPromoteMembers == other.CanPromoteMembers &&
				   this.CanChangeInfo == other.CanChangeInfo &&
				   this.CanInviteUsers == other.CanInviteUsers &&
				   this.CanPostMessages == other.CanPostMessages &&
				   this.CanEditMessages == other.CanEditMessages &&
				   this.CanPinMessages == other.CanPinMessages &&
				   this.CanManageTopics == other.CanManageTopics &&
				   this.CustomTitle == other.CustomTitle;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 1558406401;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Status);
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.User);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Status);
			hashCode = hashCode * -1521134295 + this.CanBeEdited.GetHashCode();
			hashCode = hashCode * -1521134295 + this.IsAnonymous.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanManageChat.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanDeleteMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanManageVideoChats.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanRestrictMembers.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanPromoteMembers.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanChangeInfo.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanInviteUsers.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanPostMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanEditMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanPinMessages.GetHashCode();
			hashCode = hashCode * -1521134295 + this.CanManageTopics.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.CustomTitle);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ChatMemberAdministrator? left, ChatMemberAdministrator? right)
		{
			return EqualityComparer<ChatMemberAdministrator>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ChatMemberAdministrator? left, ChatMemberAdministrator? right)
		{
			return !(left == right);
		}
	}
}
