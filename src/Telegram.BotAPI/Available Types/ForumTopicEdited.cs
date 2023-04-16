// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about an edited forum topic.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ForumTopicEdited : IEquatable<ForumTopicEdited?>
{
	/// <summary>
	/// Optional. New name of the topic, if it was edited
	/// </summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Name { get; set; }
	/// <summary>
	/// Optional. New identifier of the custom emoji shown as the topic icon, if it was edited; an empty string if the icon was removed
	/// </summary>
	[JsonPropertyName(PropertyNames.IconCustomEmojiId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? IconCustomEmojiId { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object? obj)
	{
		return this.Equals(obj as ForumTopicEdited);
	}
	/// <inheritdoc/>
	public bool Equals(ForumTopicEdited? other)
	{
		return other is not null &&
			   this.Name == other.Name &&
			   this.IconCustomEmojiId == other.IconCustomEmojiId;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1495497240;
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Name);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.IconCustomEmojiId);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(ForumTopicEdited? left, ForumTopicEdited? right)
	{
#pragma warning disable CS8604 // Possible null reference argument.
		return EqualityComparer<ForumTopicEdited>.Default.Equals(left!, right!);
#pragma warning restore CS8604 // Possible null reference argument.
	}
	/// <inheritdoc/>
	public static bool operator !=(ForumTopicEdited? left, ForumTopicEdited? right)
	{
		return !(left == right);
	}

}
