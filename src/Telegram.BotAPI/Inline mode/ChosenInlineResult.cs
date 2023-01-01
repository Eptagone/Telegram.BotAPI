// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents a result of an inline query that was chosen by the user and sent to their chat partner.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ChosenInlineResult : IEquatable<ChosenInlineResult?>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChosenInlineResult"/> class.
		/// </summary>
		public ChosenInlineResult()
		{
			this.ResultId = null!;
			this.From = null!;
			this.Query = null!;
		}

		/// <summary>The unique identifier for the result that was chosen.</summary>
		[JsonPropertyName(PropertyNames.ResultId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string ResultId { get; set; }
		/// <summary>The user that chose the result.</summary>
		[JsonPropertyName(PropertyNames.From)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User From { get; set; }
		/// <summary>Optional. Sender location, only for bots that require user location.</summary>
		[JsonPropertyName(PropertyNames.Location)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Location? Location { get; set; }
		/// <summary>Optional. Identifier of the sent inline message. Available only if there is an inline keyboard attached to the message. Will be also received in callback queries and can be used to edit the message.</summary>
		[JsonPropertyName(PropertyNames.InlineMessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? InlineMessageId { get; set; }
		/// <summary>The query that was used to obtain the result.</summary>
		[JsonPropertyName(PropertyNames.Query)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Query { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as ChosenInlineResult);
		}
		/// <inheritdoc/>
		public bool Equals(ChosenInlineResult? other)
		{
			return other is not null &&
				   this.ResultId == other.ResultId &&
				   EqualityComparer<User>.Default.Equals(this.From, other.From) &&
				   EqualityComparer<Location?>.Default.Equals(this.Location, other.Location) &&
				   this.InlineMessageId == other.InlineMessageId &&
				   this.Query == other.Query;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -807511667;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ResultId);
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.From);
			hashCode = hashCode * -1521134295 + EqualityComparer<Location?>.Default.GetHashCode(this.Location);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.InlineMessageId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Query);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ChosenInlineResult? left, ChosenInlineResult? right)
		{
			return EqualityComparer<ChosenInlineResult>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ChosenInlineResult? left, ChosenInlineResult? right)
		{
			return !(left == right);
		}

	}
}
