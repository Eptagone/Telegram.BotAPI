// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>Represents a Game.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineQueryResultGame : InlineQueryResult, IEquatable<InlineQueryResultGame>
{
	/// <summary>Type of the result, must be game.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InlineQueryResultType.Game;
	/// <summary>Short name of the game.</summary>
	[JsonPropertyName(PropertyNames.GameShortName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string GameShortName { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as InlineQueryResultGame);
	}
	/// <inheritdoc/>
	public bool Equals(InlineQueryResultGame? other)
	{
		return other != null &&
			   this.Id == other.Id &&
			   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
			   this.Type == other.Type &&
			   this.GameShortName == other.GameShortName;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -2029204352;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.GameShortName);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InlineQueryResultGame? left, InlineQueryResultGame? right)
	{
		return EqualityComparer<InlineQueryResultGame>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InlineQueryResultGame? left, InlineQueryResultGame? right)
	{
		return !(left == right);
	}

}
