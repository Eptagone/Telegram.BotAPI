// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Telegram.BotAPI.AvailableMethods
{
	/// <summary>Send Venue.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SendVenueArgs : SendMessageWithReplyMarkupBase, IVenue
	{
		/// <summary>
		/// Initialize a new instance of <see cref="SendVenueArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="latitude">Latitude of the venue.</param>
		/// <param name="longitude">Longitude of the venue.</param>
		/// <param name="title">Name of the venue.</param>
		/// <param name="address">Address of the venue.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendVenueArgs(long chatId, float latitude, float longitude, string title, string address) : base(chatId)
		{
			this.Latitude = latitude;
			this.Longitude = longitude;
			this.Title = title ?? throw new ArgumentNullException(nameof(title));
			this.Address = address ?? throw new ArgumentNullException(nameof(address));
		}

		/// <summary>
		/// Initialize a new instance of <see cref="SendVenueArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="latitude">Latitude of the venue.</param>
		/// <param name="longitude">Longitude of the venue.</param>
		/// <param name="title">Name of the venue.</param>
		/// <param name="address">Address of the venue.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendVenueArgs(string chatId, float latitude, float longitude, string title, string address) : base(chatId)
		{
			this.Latitude = latitude;
			this.Longitude = longitude;
			this.Title = title ?? throw new ArgumentNullException(nameof(title));
			this.Address = address ?? throw new ArgumentNullException(nameof(address));
		}

		/// <summary>Latitude of the venue.</summary>
		[JsonPropertyName(PropertyNames.Latitude)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float Latitude { get; }
		/// <summary>Longitude of the venue.</summary>
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
		public string? FoursquareId { get; set; }
		/// <summary>Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”).</summary>
		[JsonPropertyName(PropertyNames.FoursquareType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? FoursquareType { get; set; }
		/// <summary>Optional. Google Places identifier of the venue.</summary>
		[JsonPropertyName(PropertyNames.GooglePlaceId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? GooglePlaceId { get; set; }
		/// <summary>Optional. Google Places type of the venue. (See <a href="https://developers.google.com/places/web-service/supported_types">supported types</a>.)</summary>
		[JsonPropertyName(PropertyNames.GooglePlaceType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? GooglePlaceType { get; set; }
	}
}
