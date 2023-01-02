// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>This object represents an incoming inline query. When the user sends an empty query, your bot could return some default or trending results.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineQuery : IEquatable<InlineQuery?>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InlineQuery"/> class.
		/// </summary>
		public InlineQuery()
		{
			this.Id = null!;
			this.From = null!;
			this.Query = null!;
			this.Offset = null!;
		}

		///<summary>Unique identifier for this query.</summary>
		[JsonPropertyName(PropertyNames.Id)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Id { get; set; }
		///<summary>Sender.</summary>
		[JsonPropertyName(PropertyNames.From)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User From { get; set; }
		///<summary>Text of the query (up to 512 characters).</summary>
		[JsonPropertyName(PropertyNames.Query)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Query { get; set; }
		///<summary>Offset of the results to be returned, can be controlled by the bot.</summary>
		[JsonPropertyName(PropertyNames.Offset)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Offset { get; set; }
		///<summary>Optional. Type of the chat, from which the inline query was sent. Can be either �sender� for a private chat with the inline query sender, �private�, �group�, �supergroup�, or �channel�. The chat type should be always known for requests sent from official clients and most third-party clients, unless the request was sent from a secret chat.</summary>
		[JsonPropertyName(PropertyNames.ChatType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ChatType { get; set; }
		///<summary>Optional. Sender location, only for bots that request user location.</summary>
		[JsonPropertyName(PropertyNames.Location)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Location? Location { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as InlineQuery);
		}
		/// <inheritdoc/>
		public bool Equals(InlineQuery? other)
		{
			return other is not null &&
				   this.Id == other.Id &&
				   EqualityComparer<User>.Default.Equals(this.From, other.From) &&
				   this.Query == other.Query &&
				   this.Offset == other.Offset &&
				   this.ChatType == other.ChatType &&
				   EqualityComparer<Location?>.Default.Equals(this.Location, other.Location);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -297749477;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.From);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Query);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Offset);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ChatType);
			hashCode = hashCode * -1521134295 + EqualityComparer<Location?>.Default.GetHashCode(this.Location);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InlineQuery? left, InlineQuery? right)
		{
			return EqualityComparer<InlineQuery>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InlineQuery? left, InlineQuery? right)
		{
			return !(left == right);
		}

	}
}
