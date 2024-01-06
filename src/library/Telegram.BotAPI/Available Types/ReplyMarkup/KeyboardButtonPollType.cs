// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents type of a poll, which is allowed to be created and sent when the corresponding button is pressed.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class KeyboardButtonPollType : IEquatable<KeyboardButtonPollType>
{
	/// <summary>Optional. If quiz is passed, the user will be allowed to create only polls in the quiz mode. If regular is passed, only regular polls will be allowed. Otherwise, the user will be allowed to create a poll of any type.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Type { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as KeyboardButtonPollType);
	}
	/// <inheritdoc/>
	public bool Equals(KeyboardButtonPollType? other)
	{
		return other != null &&
			   this.Type == other.Type;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		return 2049151605 + EqualityComparer<string>.Default.GetHashCode(this.Type);
	}
	/// <inheritdoc/>
	public static bool operator ==(KeyboardButtonPollType? left, KeyboardButtonPollType? right)
	{
		return EqualityComparer<KeyboardButtonPollType>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(KeyboardButtonPollType? left, KeyboardButtonPollType? right)
	{
		return !(left == right);
	}

}
