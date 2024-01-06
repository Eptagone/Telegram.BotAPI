// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SendLocation method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendLocationArgs
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendLocationArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="longitude">Longitude as defined by sender.</param>
	/// <param name="latitude">Latitude as defined by sender.</param>
	public SendLocationArgs(long chatId, float longitude, float latitude)
	{
		this.ChatId = chatId;
		this.Longitude = longitude;
		this.Latitude = latitude;
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendLocationArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="longitude">Longitude as defined by sender.</param>
	/// <param name="latitude">Latitude as defined by sender.</param>
	public SendLocationArgs(string chatId, float longitude, float latitude)
	{
		this.ChatId = chatId;
		this.Longitude = longitude;
		this.Latitude = latitude;
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// Latitude of the location
	/// </summary>
	[JsonPropertyName(PropertyNames.Latitude)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Latitude { get; set; }
	/// <summary>
	/// Longitude of the location
	/// </summary>
	[JsonPropertyName(PropertyNames.Longitude)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Longitude { get; set; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// The radius of uncertainty for the location, measured in meters; 0-1500
	/// </summary>
	[JsonPropertyName(PropertyNames.HorizontalAccuracy)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float? HorizontalAccuracy { get; set; }
	/// <summary>
	/// Period in seconds for which the location will be updated (see Live Locations, should be between 60 and 86400.
	/// </summary>
	[JsonPropertyName(PropertyNames.LivePeriod)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? LivePeriod { get; set; }
	/// <summary>
	/// For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.
	/// </summary>
	[JsonPropertyName(PropertyNames.Heading)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ushort? Heading { get; set; }
	/// <summary>
	/// For live locations, a maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.
	/// </summary>
	[JsonPropertyName(PropertyNames.ProximityAlertRadius)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? ProximityAlertRadius { get; set; }
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
