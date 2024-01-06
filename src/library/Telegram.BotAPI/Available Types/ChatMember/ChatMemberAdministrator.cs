// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a chat member that has some additional privileges.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ChatMemberAdministrator : ChatMember
{
	/// <summary>
	/// The member's status in the chat, always “administrator”
	/// </summary>
	[JsonPropertyName(PropertyNames.Status)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Status => ChatMemberStatus.Administrator;
	/// <summary>
	/// Information about the user
	/// </summary>
	[JsonPropertyName(PropertyNames.User)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User User { get; set; }
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
	/// True, if the administrator can access the chat event log, chat statistics, boost list in channels, message statistics in channels, see channel members, see anonymous administrators in supergroups and ignore slow mode. Implied by any other administrator privilege
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
	/// True, if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by the user)
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
	/// Optional. True, if the administrator can post messages in the channel; channels only
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
	/// Optional. True, if the administrator can post stories in the channel; channels only
	/// </summary>
	[JsonPropertyName(PropertyNames.CanPostStories)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? CanPostStories { get; set; }
	/// <summary>
	/// Optional. True, if the administrator can edit stories posted by other users; channels only
	/// </summary>
	[JsonPropertyName(PropertyNames.CanEditStories)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? CanEditStories { get; set; }
	/// <summary>
	/// Optional. True, if the administrator can delete stories posted by other users; channels only
	/// </summary>
	[JsonPropertyName(PropertyNames.CanDeleteStories)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? CanDeleteStories { get; set; }
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
}
