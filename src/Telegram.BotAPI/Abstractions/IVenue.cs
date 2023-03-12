// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
	/// <summary>Represents a venue. Used by <see cref="Venue"/></summary>
	public interface IVenue
	{
		/// <summary>Name of the venue.</summary>
		public string Title { get; }
		/// <summary>Address of the venue.</summary>
		public string Address { get; }
		/// <summary>Optional. Foursquare identifier of the venue.</summary>
		public string FoursquareId { get; set; }
		/// <summary>Optional. Foursquare type of the venue. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
		public string FoursquareType { get; set; }
		/// <summary>Optional. Google Places identifier of the venue.</summary>
		public string GooglePlaceId { get; set; }
		/// <summary>Optional. Google Places type of the venue. (See <a href="https://developers.google.com/places/web-service/supported_types">supported types</a>.)</summary>
		public string GooglePlaceType { get; set; }
	}
}