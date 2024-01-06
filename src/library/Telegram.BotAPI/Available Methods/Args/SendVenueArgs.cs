// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

/// <summary>Send Venue.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendVenueArgs
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
	public SendVenueArgs(long chatId, float latitude, float longitude, string title, string address)
	{
		this.ChatId = chatId;
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
	public SendVenueArgs(string chatId, float latitude, float longitude, string title, string address)
	{
		this.ChatId = chatId;
		this.Latitude = latitude;
		this.Longitude = longitude;
		this.Title = title ?? throw new ArgumentNullException(nameof(title));
		this.Address = address ?? throw new ArgumentNullException(nameof(address));
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// Latitude of the venue
	/// </summary>
	[JsonPropertyName(PropertyNames.Latitude)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Latitude { get; set; }
	/// <summary>
	/// Longitude of the venue
	/// </summary>
	[JsonPropertyName(PropertyNames.Longitude)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Longitude { get; set; }
	/// <summary>
	/// Name of the venue
	/// </summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Title { get; set; }
	/// <summary>
	/// Address of the venue
	/// </summary>
	[JsonPropertyName(PropertyNames.Address)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Address { get; set; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// Foursquare identifier of the venue
	/// </summary>
	[JsonPropertyName(PropertyNames.FoursquareId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? FoursquareId { get; set; }
	/// <summary>
	/// Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)
	/// </summary>
	[JsonPropertyName(PropertyNames.FoursquareType)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? FoursquareType { get; set; }
	/// <summary>
	/// Google Places identifier of the venue
	/// </summary>
	[JsonPropertyName(PropertyNames.GooglePlaceId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? GooglePlaceId { get; set; }
	/// <summary>
	/// Google Places type of the venue. (See supported types.)
	/// </summary>
	[JsonPropertyName(PropertyNames.GooglePlaceType)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? GooglePlaceType { get; set; }
	/// <summary>
	/// Sends the message silently. Users will receive a notification with no sound.
	/// </summary>
	[JsonPropertyName(PropertyNames.DisableNotification)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DisableNotification { get; set; }
	/// <summary>
	/// Protects the contents of the sent message from forwarding and saving
	/// </summary>
	[JsonPropertyName(PropertyNames.ProtectContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ProtectContent { get; set; }
	/// <summary>
	/// Description of the message to reply to
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyParameters)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyParameters? ReplyParameters { get; set; }
	/// <summary>
	/// Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyMarkup)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyMarkup? ReplyMarkup { get; set; }
}
