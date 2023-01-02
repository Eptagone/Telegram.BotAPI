// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableMethods
{
	/// <summary>SendLocation method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SendLocationArgs : SendMessageWithReplyMarkupBase, ILocation
	{
		/// <summary>
		/// Initialize a new instance of <see cref="SendLocationArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="longitude">Longitude as defined by sender.</param>
		/// <param name="latitude">Latitude as defined by sender.</param>
		public SendLocationArgs(long chatId, float longitude, float latitude) : base(chatId)
		{
			this.Longitude = longitude;
			this.Latitude = latitude;
		}
		/// <summary>
		/// Initialize a new instance of <see cref="SendLocationArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="longitude">Longitude as defined by sender.</param>
		/// <param name="latitude">Latitude as defined by sender.</param>
		public SendLocationArgs(string chatId, float longitude, float latitude) : base(chatId)
		{
			this.Longitude = longitude;
			this.Latitude = latitude;
		}

		///<summary>Longitude as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Longitude)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float Longitude { get; }
		///<summary>Latitude as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Latitude)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float Latitude { get; }
		///<summary>Optional. The radius of uncertainty for the location, measured in meters; 0-1500.</summary>
		[JsonPropertyName(PropertyNames.HorizontalAccuracy)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float? HorizontalAccuracy { get; set; }
		///<summary>Optional. Time relative to the message sending date, during which the location can be updated, in seconds. For active live locations only.</summary>
		[JsonPropertyName(PropertyNames.LivePeriod)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? LivePeriod { get; set; }
		///<summary>Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
		[JsonPropertyName(PropertyNames.Heading)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ushort? Heading { get; set; }
		///<summary>Optional. Maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
		[JsonPropertyName(PropertyNames.ProximityAlertRadius)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? ProximityAlertRadius { get; set; }
	}
}
