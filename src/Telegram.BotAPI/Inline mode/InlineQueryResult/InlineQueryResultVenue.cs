// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents a venue. By default, the venue will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the venue.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineQueryResultVenue : InlineQueryResult, IVenue, IExternalThumbnail, IEquatable<InlineQueryResultVenue>
	{
		/// <summary>Type of the result, must be venue.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InlineQueryResultType.Venue;
		/// <summary>Latitude of the venue location in degrees.</summary>
		[JsonPropertyName(PropertyNames.Latitude)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float Latitude { get; set; }
		/// <summary>Longitude of the venue location in degrees.</summary>
		[JsonPropertyName(PropertyNames.Longitude)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float Longitude { get; set; }
		/// <summary>Title of the venue.</summary>
		[JsonPropertyName(PropertyNames.Title)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Title { get; set; }
		/// <summary>Address of the venue.</summary>
		[JsonPropertyName(PropertyNames.Address)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Address { get; set; }
		/// <summary>Optional. Foursquare identifier of the venue if known.</summary>
		[JsonPropertyName(PropertyNames.FoursquareId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FoursquareId { get; set; }
		/// <summary>Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
		[JsonPropertyName(PropertyNames.FoursquareType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FoursquareType { get; set; }
		/// <summary>Optional. Google Places identifier of the venue.</summary>
		[JsonPropertyName(PropertyNames.GooglePlaceId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string GooglePlaceId { get; set; }
		/// <summary>Optional. Google Places type of the venue. (See <a href="https://developers.google.com/places/web-service/supported_types">supported types</a>.)</summary>
		[JsonPropertyName(PropertyNames.GooglePlaceType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string GooglePlaceType { get; set; }
		/// <summary>Optional. Content of the message to be sent instead of the venue.</summary>
		[JsonPropertyName(PropertyNames.InputMessageContent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InputMessageContent InputMessageContent { get; set; }
		/// <summary>Optional. Url of the thumbnail for the result.</summary>
		[JsonPropertyName(PropertyNames.ThumbnailUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string ThumbnailUrl { get; set; }
		/// <summary>Optional. Thumbnail width.</summary>
		[JsonPropertyName(PropertyNames.ThumbnailWidth)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? ThumbnailWidth { get; set; }
		/// <summary>Optional. Thumbnail height.</summary>
		[JsonPropertyName(PropertyNames.ThumbnailHeight)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? ThumbnailHeight { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InlineQueryResultVenue);
		}
		/// <inheritdoc/>
		public bool Equals(InlineQueryResultVenue? other)
		{
			return other != null &&
				   this.Id == other.Id &&
				   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
				   this.Type == other.Type &&
				   this.Latitude == other.Latitude &&
				   this.Longitude == other.Longitude &&
				   this.Title == other.Title &&
				   this.Address == other.Address &&
				   this.FoursquareId == other.FoursquareId &&
				   this.FoursquareType == other.FoursquareType &&
				   this.GooglePlaceId == other.GooglePlaceId &&
				   this.GooglePlaceType == other.GooglePlaceType &&
				   EqualityComparer<InputMessageContent>.Default.Equals(this.InputMessageContent, other.InputMessageContent) &&
				   this.ThumbnailUrl == other.ThumbnailUrl &&
				   this.ThumbnailWidth == other.ThumbnailWidth &&
				   this.ThumbnailHeight == other.ThumbnailHeight;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -545969655;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + this.Latitude.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Longitude.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Title);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Address);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FoursquareId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FoursquareType);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.GooglePlaceId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.GooglePlaceType);
			hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(this.InputMessageContent);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ThumbnailUrl);
			hashCode = hashCode * -1521134295 + this.ThumbnailWidth.GetHashCode();
			hashCode = hashCode * -1521134295 + this.ThumbnailHeight.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InlineQueryResultVenue? left, InlineQueryResultVenue? right)
		{
			return EqualityComparer<InlineQueryResultVenue>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InlineQueryResultVenue? left, InlineQueryResultVenue? right)
		{
			return !(left == right);
		}

	}
}
