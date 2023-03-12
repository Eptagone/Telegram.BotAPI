// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents the content of a venue message to be sent as the result of an inline query.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InputVenueMessageContent : InputMessageContent, IVenue, IEquatable<InputVenueMessageContent>
	{
		/// <summary>
		/// Initialize a new instance of <see cref="InputVenueMessageContent"/>.
		/// </summary>
		/// <param name="latitude">Latitude of the venue in degrees.</param>
		/// <param name="longitude">Longitude of the venue in degrees.</param>
		/// <param name="title">Name of the venue.</param>
		/// <param name="address">Address of the venue.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public InputVenueMessageContent(float latitude, float longitude, string title, string address)
		{
			this.Latitude = latitude;
			this.Longitude = longitude;
			this.Title = title ?? throw new ArgumentNullException(nameof(title));
			this.Address = address ?? throw new ArgumentNullException(nameof(address));
		}

		/// <summary>
		/// Initialize a new instance of <see cref="InputVenueMessageContent"/>.
		/// </summary>
		/// <param name="latitude">Latitude of the venue in degrees.</param>
		/// <param name="longitude">Longitude of the venue in degrees.</param>
		/// <param name="venue">Venue.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public InputVenueMessageContent(float latitude, float longitude, IVenue venue)
		{
			if (venue == null)
			{
				throw new ArgumentNullException(nameof(venue));
			}

			this.Latitude = latitude;
			this.Longitude = longitude;
			this.Title = venue.Title ?? throw new ArgumentNullException(nameof(venue.Title));
			this.Address = venue.Address ?? throw new ArgumentNullException(nameof(venue.Address));
			this.FoursquareId = venue.FoursquareId;
			this.FoursquareType = venue.FoursquareType;
			this.GooglePlaceId = venue.GooglePlaceId;
			this.GooglePlaceType = venue.GooglePlaceType;
		}

		/// <summary>Latitude of the venue in degrees.</summary>
		[JsonPropertyName(PropertyNames.Latitude)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float Latitude { get; }
		/// <summary>Longitude of the venue in degrees.</summary>
		[JsonPropertyName(PropertyNames.Longitude)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float Longitude { get; }
		/// <summary>Name of the venue.</summary>
		[JsonPropertyName(PropertyNames.Title)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Title { get; }
		/// <summary>Address of the venue.</summary>
		[JsonPropertyName(PropertyNames.Address)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Address { get; }
		/// <summary>Optional. Foursquare identifier of the venue.</summary>
		[JsonPropertyName(PropertyNames.FoursquareId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FoursquareId { get; set; }
		/// <summary>Optional. Foursquare type of the venue. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
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
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InputVenueMessageContent);
		}
		/// <inheritdoc/>
		public bool Equals(InputVenueMessageContent? other)
		{
			return other != null &&
				   this.Latitude == other.Latitude &&
				   this.Longitude == other.Longitude &&
				   this.Title == other.Title &&
				   this.Address == other.Address &&
				   this.FoursquareId == other.FoursquareId &&
				   this.FoursquareType == other.FoursquareType &&
				   this.GooglePlaceId == other.GooglePlaceId &&
				   this.GooglePlaceType == other.GooglePlaceType;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -297061995;
			hashCode = hashCode * -1521134295 + this.Latitude.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Longitude.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Title);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Address);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FoursquareId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FoursquareType);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.GooglePlaceId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.GooglePlaceType);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InputVenueMessageContent? left, InputVenueMessageContent? right)
		{
			return EqualityComparer<InputVenueMessageContent>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InputVenueMessageContent? left, InputVenueMessageContent? right)
		{
			return !(left == right);
		}

	}
}
