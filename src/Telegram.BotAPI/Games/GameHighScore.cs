// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Games
{
	/// <summary>This object represents one row of the high scores table for a game.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class GameHighScore : IEquatable<GameHighScore>
	{
		/// <summary>Position in high score table for the game</summary>
		[JsonPropertyName(PropertyNames.Position)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Position { get; set; }
		/// <summary>User</summary>
		[JsonPropertyName(PropertyNames.User)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User User { get; set; }
		/// <summary>Score</summary>
		[JsonPropertyName(PropertyNames.Score)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Score { get; set; }

		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as GameHighScore);
		}
		/// <inheritdoc/>
		public bool Equals(GameHighScore? other)
		{
			return other != null &&
				   this.Position == other.Position &&
				   EqualityComparer<User>.Default.Equals(this.User, other.User) &&
				   this.Score == other.Score;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 1602484449;
			hashCode = hashCode * -1521134295 + this.Position.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.User);
			hashCode = hashCode * -1521134295 + this.Score.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(GameHighScore? left, GameHighScore? right)
		{
			return EqualityComparer<GameHighScore>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(GameHighScore? left, GameHighScore? right)
		{
			return !(left == right);
		}

	}
}
