// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a bot command.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class BotCommand : IEquatable<BotCommand>
	{
		/// <summary>New Bot Command</summary>
		public BotCommand()
		{
			this.Command = null!;
			this.Description = null!;
		}

		/// <summary>New Bot Command</summary>
		/// <param name="command">Text of the command, 1-32 characters. Can contain only lowercase English letters, digits and underscores.</param>
		/// <param name="description">Description of the command, 3-256 characters.</param>
		public BotCommand(string command, string description)
		{
			this.Command = command;
			this.Description = description;
		}

		/// <summary>Text of the command, 1-32 characters. Can contain only lowercase English letters, digits and underscores.</summary>
		[JsonPropertyName(PropertyNames.Command)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Command { get; set; }
		/// <summary>Description of the command, 3-256 characters.</summary>
		[JsonPropertyName(PropertyNames.Description)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Description { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as BotCommand);
		}
		/// <inheritdoc/>
		public bool Equals(BotCommand? other)
		{
			return other != null &&
				   this.Command == other.Command &&
				   this.Description == other.Description;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -56514517;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Command);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Description);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(BotCommand? left, BotCommand? right)
		{
			return EqualityComparer<BotCommand>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(BotCommand? left, BotCommand? right)
		{
			return !(left == right);
		}

	}
}
