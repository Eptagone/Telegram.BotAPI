// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents the bot's name.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class BotName : IEquatable<BotName?>
{
	/// <summary>
	/// The bot's name
	/// </summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Name { get; set; } = null!;

	/// <inheritdoc />
	public override bool Equals(object? obj)
	{
		return this.Equals(obj as BotName);
	}

	/// <inheritdoc />
	public bool Equals(BotName? other)
	{
		return other is not null &&
			   this.Name == other.Name;
	}

	/// <inheritdoc />
	public override int GetHashCode()
	{
		return 539060726 + EqualityComparer<string>.Default.GetHashCode(this.Name);
	}

	/// <inheritdoc />
	public static bool operator ==(BotName? left, BotName? right)
	{
		return EqualityComparer<BotName?>.Default.Equals(left, right);
	}

	/// <inheritdoc />
	public static bool operator !=(BotName? left, BotName? right)
	{
		return !(left == right);
	}
}
