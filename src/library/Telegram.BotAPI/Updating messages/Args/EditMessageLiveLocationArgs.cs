// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>EditMessageLiveLocation method arguments.</summary>}
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class EditMessageLiveLocationArgs
{
	/// <summary>
	/// Initializes a new instance of the <see cref="EditMessageLiveLocationArgs"/> class.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the sent message</param>
	/// <param name="longitude">Longitude as defined by sender</param>
	/// <param name="latitude">Latitude as defined by sender</param>
	public EditMessageLiveLocationArgs(long chatId, int messageId, float longitude, float latitude)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
		this.Longitude = longitude;
		this.Latitude = latitude;
	}
	
	/// <summary>
	/// Initializes a new instance of the <see cref="EditMessageLiveLocationArgs"/> class.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the sent message</param>
	/// <param name="longitude">Longitude as defined by sender</param>
	/// <param name="latitude">Latitude as defined by sender</param>
	public EditMessageLiveLocationArgs(string chatId, int messageId, float longitude, float latitude)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
		this.Longitude = longitude;
		this.Latitude = latitude;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="EditMessageLiveLocationArgs"/> class.
	/// </summary>
	/// <param name="inlineMessageId">Identifier of the inline message</param>
	/// <param name="longitude">Longitude as defined by sender</param>
	/// <param name="latitude">Latitude as defined by sender</param>
	public EditMessageLiveLocationArgs(string inlineMessageId, float longitude, float latitude)
	{
		this.InlineMessageId = inlineMessageId;
		this.Longitude = longitude;
		this.Latitude = latitude;
	}

	/// <summary>
	/// Latitude of new location
	/// </summary>
    [JsonPropertyName(PropertyNames.Latitude)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Latitude { get; set; }
	/// <summary>
	/// Longitude of new location
	/// </summary>
    [JsonPropertyName(PropertyNames.Longitude)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Longitude { get; set; }
	/// <summary>
	/// Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object? ChatId { get; }
	/// <summary>
	/// Required if inline_message_id is not specified. Identifier of the message to edit
	/// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageId { get; }
	/// <summary>
	/// Required if chat_id and message_id are not specified. Identifier of the inline message
	/// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? InlineMessageId { get; }
	/// <summary>
	/// The radius of uncertainty for the location, measured in meters; 0-1500
	/// </summary>
    [JsonPropertyName(PropertyNames.HorizontalAccuracy)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float? HorizontalAccuracy { get; set; }
	/// <summary>
	/// Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.
	/// </summary>
    [JsonPropertyName(PropertyNames.Heading)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ushort? Heading { get; set; }
	/// <summary>
	/// The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.
	/// </summary>
    [JsonPropertyName(PropertyNames.ProximityAlertRadius)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? ProximityAlertRadius { get; set; }
	/// <summary>
	/// A JSON-serialized object for a new inline keyboard.
	/// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
