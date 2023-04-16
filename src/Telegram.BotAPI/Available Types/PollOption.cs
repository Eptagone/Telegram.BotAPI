// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object contains information about one answer option in a poll.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class PollOption : IEquatable<PollOption>
{
	/// <summary>Option text, 1-100 characters.</summary>
	[JsonPropertyName(PropertyNames.Text)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Text { get; set; }
	/// <summary>Number of users that voted for this option.</summary>
	[JsonPropertyName(PropertyNames.VoterCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint VoterCount { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as PollOption);
	}
	/// <inheritdoc/>
	public bool Equals(PollOption? other)
	{
		return other != null &&
			   this.Text == other.Text &&
			   this.VoterCount == other.VoterCount;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -274894174;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Text);
		hashCode = hashCode * -1521134295 + this.VoterCount.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(PollOption? left, PollOption? right)
	{
		return EqualityComparer<PollOption>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(PollOption? left, PollOption? right)
	{
		return !(left == right);
	}

}
