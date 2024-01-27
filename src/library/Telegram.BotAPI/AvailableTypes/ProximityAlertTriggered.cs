// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents the content of a service message, sent whenever a user in the chat triggers a proximity alert set by another user.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ProximityAlertTriggered : IEquatable<ProximityAlertTriggered>
{
	/// <summary>User that triggered the alert.</summary>
	[JsonPropertyName(PropertyNames.Traveler)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User Traveler { get; set; }
	/// <summary>User that set the alert.</summary>
	[JsonPropertyName(PropertyNames.Watcher)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User Watcher { get; set; }
	/// <summary>The distance between the users.</summary>
	[JsonPropertyName(PropertyNames.Distance)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint Distance { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as ProximityAlertTriggered);
	}
	/// <inheritdoc/>
	public bool Equals(ProximityAlertTriggered? other)
	{
		return other != null &&
			   EqualityComparer<User>.Default.Equals(this.Traveler, other.Traveler) &&
			   EqualityComparer<User>.Default.Equals(this.Watcher, other.Watcher) &&
			   this.Distance == other.Distance;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -665126421;
		hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.Traveler);
		hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.Watcher);
		hashCode = hashCode * -1521134295 + this.Distance.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(ProximityAlertTriggered? left, ProximityAlertTriggered? right)
	{
		return EqualityComparer<ProximityAlertTriggered>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(ProximityAlertTriggered? left, ProximityAlertTriggered? right)
	{
		return !(left == right);
	}

}
