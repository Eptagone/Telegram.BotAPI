// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents a Telegram user or bot.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class User : ITelegramUser, IEquatable<User>
{
	/// <summary>Unique identifier for this user or bot.</summary>
	[JsonPropertyName(PropertyNames.Id)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long Id { get; set; }
	/// <summary>True, if this user is a bot.</summary>
	[JsonPropertyName(PropertyNames.IsBot)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool IsBot { get; set; }
	/// <summary>User‘s or bot’s first name.</summary>
	[JsonPropertyName(PropertyNames.FirstName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string FirstName { get; set; }
	/// <summary>Optional. User‘s or bot’s last name.</summary>
	[JsonPropertyName(PropertyNames.LastName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? LastName { get; set; }
	/// <summary>Optional. User‘s or bot’s username.</summary>
	[JsonPropertyName(PropertyNames.Username)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Username { get; set; }
	/// <summary>Optional. IETF language tag of the user's language.</summary>
	[JsonPropertyName(PropertyNames.LanguageCode)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? LanguageCode { get; set; }
	/// <summary>
	/// Optional. True, if this user is a Telegram Premium user
	/// </summary>
	[JsonPropertyName(PropertyNames.IsPremium)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? IsPremium { get; set; }
	/// <summary>
	/// Optional. True, if this user added the bot to the attachment menu
	/// </summary>
	[JsonPropertyName(PropertyNames.AddedToAttachmentMenu)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? AddedToAttachmentMenu { get; set; }
	/// <summary>Optional. True, if the bot can be invited to groups. Returned only in getMe.</summary>
	[JsonPropertyName(PropertyNames.CanJoinGroups)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? CanJoinGroups { get; set; }
	/// <summary>Optional. True, if privacy mode is disabled for the bot. Returned only in getMe.</summary>
	[JsonPropertyName(PropertyNames.CanReadAllGroupMessages)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? CanReadAllGroupMessages { get; set; }
	/// <summary>Optional. True, if the bot supports inline queries. Returned only in getMe.</summary>
	[JsonPropertyName(PropertyNames.SupportsInlineQueries)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? SupportsInlineQueries { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as User);
	}
	/// <inheritdoc/>
	public bool Equals(User? other)
	{
		return other != null &&
			   this.Id == other.Id &&
			   this.IsBot == other.IsBot &&
			   this.FirstName == other.FirstName &&
			   this.LastName == other.LastName &&
			   this.Username == other.Username &&
			   this.LanguageCode == other.LanguageCode &&
			   this.CanJoinGroups == other.CanJoinGroups &&
			   this.CanReadAllGroupMessages == other.CanReadAllGroupMessages &&
			   this.SupportsInlineQueries == other.SupportsInlineQueries;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1040595173;
		hashCode = hashCode * -1521134295 + this.Id.GetHashCode();
		hashCode = hashCode * -1521134295 + this.IsBot.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FirstName);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.LastName);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Username);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.LanguageCode);
		hashCode = hashCode * -1521134295 + this.CanJoinGroups.GetHashCode();
		hashCode = hashCode * -1521134295 + this.CanReadAllGroupMessages.GetHashCode();
		hashCode = hashCode * -1521134295 + this.SupportsInlineQueries.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(User? left, User? right)
	{
		return EqualityComparer<User>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(User? left, User? right)
	{
		return !(left == right);
	}

}
