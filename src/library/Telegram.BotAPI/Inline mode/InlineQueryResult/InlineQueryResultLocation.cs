// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>Represents a location on a map. By default, the location will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the location.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineQueryResultLocation : InlineQueryResultWithEntities, ILocation, IExternalThumbnail, IEquatable<InlineQueryResultLocation>
{
	/// <summary>Type of the result, must be location.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InlineQueryResultType.Location;
	/// <summary>Longitude as defined by sender.</summary>
	[JsonPropertyName(PropertyNames.Longitude)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Longitude { get; set; }
	/// <summary>Latitude as defined by sender.</summary>
	[JsonPropertyName(PropertyNames.Latitude)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Latitude { get; set; }
	/// <summary>Title of the result.</summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Title { get; set; }
	/// <summary>Optional. The radius of uncertainty for the location, measured in meters; 0-1500.</summary>
	[JsonPropertyName(PropertyNames.HorizontalAccuracy)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float? HorizontalAccuracy { get; set; }
	/// <summary>Optional. Time relative to the message sending date, during which the location can be updated, in seconds. For active live locations only.</summary>
	[JsonPropertyName(PropertyNames.LivePeriod)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? LivePeriod { get; set; }
	/// <summary>Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
	[JsonPropertyName(PropertyNames.Heading)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ushort? Heading { get; set; }
	/// <summary>Optional. Maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
	[JsonPropertyName(PropertyNames.ProximityAlertRadius)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? ProximityAlertRadius { get; set; }
	/// <summary>Optional. Content of the message to be sent instead of the location.</summary>
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
		return this.Equals(obj as InlineQueryResultLocation);
	}
	/// <inheritdoc/>
	public bool Equals(InlineQueryResultLocation? other)
	{
		return other != null &&
			   this.Id == other.Id &&
			   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
			   this.ParseMode == other.ParseMode &&
			   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
			   this.Type == other.Type &&
			   this.Longitude == other.Longitude &&
			   this.Latitude == other.Latitude &&
			   this.Title == other.Title &&
			   this.HorizontalAccuracy == other.HorizontalAccuracy &&
			   this.LivePeriod == other.LivePeriod &&
			   this.Heading == other.Heading &&
			   this.ProximityAlertRadius == other.ProximityAlertRadius &&
			   EqualityComparer<InputMessageContent>.Default.Equals(this.InputMessageContent, other.InputMessageContent) &&
			   this.ThumbnailUrl == other.ThumbnailUrl &&
			   this.ThumbnailWidth == other.ThumbnailWidth &&
			   this.ThumbnailHeight == other.ThumbnailHeight;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -1945719542;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + this.Longitude.GetHashCode();
		hashCode = hashCode * -1521134295 + this.Latitude.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Title);
		hashCode = hashCode * -1521134295 + this.HorizontalAccuracy.GetHashCode();
		hashCode = hashCode * -1521134295 + this.LivePeriod.GetHashCode();
		hashCode = hashCode * -1521134295 + this.Heading.GetHashCode();
		hashCode = hashCode * -1521134295 + this.ProximityAlertRadius.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(this.InputMessageContent);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ThumbnailUrl);
		hashCode = hashCode * -1521134295 + this.ThumbnailWidth.GetHashCode();
		hashCode = hashCode * -1521134295 + this.ThumbnailHeight.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InlineQueryResultLocation? left, InlineQueryResultLocation? right)
	{
		return EqualityComparer<InlineQueryResultLocation>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InlineQueryResultLocation? left, InlineQueryResultLocation? right)
	{
		return !(left == right);
	}

}
