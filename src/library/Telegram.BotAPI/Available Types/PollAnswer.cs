// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an answer of a user in a non-anonymous poll.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class PollAnswer : IEquatable<PollAnswer?>
{
	/// <summary>
	/// Unique poll identifier
	/// </summary>
	[JsonPropertyName(PropertyNames.PollId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string PollId { get; set; } = null!;
	/// <summary>
	/// 0-based identifiers of chosen answer options. May be empty if the vote was retracted.
	/// </summary>
	[JsonPropertyName(PropertyNames.OptionIds)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<uint> OptionIds { get; set; }
	/// <summary>
	/// Optional. The chat that changed the answer to the poll, if the voter is anonymous
	/// </summary>
	[JsonPropertyName(PropertyNames.VoterChat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat? VoterChat { get; set; }
	/// <summary>
	/// Optional. The user that changed the answer to the poll, if the voter isn't anonymous
	/// </summary>
	[JsonPropertyName(PropertyNames.User)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User? User { get; set; }

	/// <inheritdoc/>
	public override bool Equals(object? obj)
	{
		return this.Equals(obj as PollAnswer);
	}

	/// <inheritdoc/>
	public bool Equals(PollAnswer? other)
	{
		return other is not null &&
			   this.PollId == other.PollId &&
			   EqualityComparer<IEnumerable<uint>>.Default.Equals(this.OptionIds, other.OptionIds) &&
			   EqualityComparer<Chat?>.Default.Equals(this.VoterChat, other.VoterChat) &&
			   EqualityComparer<User?>.Default.Equals(this.User, other.User);
	}

	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -1324086704;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.PollId);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<uint>>.Default.GetHashCode(this.OptionIds);
		hashCode = hashCode * -1521134295 + EqualityComparer<Chat?>.Default.GetHashCode(this.VoterChat);
		hashCode = hashCode * -1521134295 + EqualityComparer<User?>.Default.GetHashCode(this.User);
		return hashCode;
	}

	/// <inheritdoc/>
	public static bool operator ==(PollAnswer? left, PollAnswer? right)
	{
		return EqualityComparer<PollAnswer?>.Default.Equals(left, right);
	}

	/// <inheritdoc/>
	public static bool operator !=(PollAnswer? left, PollAnswer? right)
	{
		return !(left == right);
	}
}
