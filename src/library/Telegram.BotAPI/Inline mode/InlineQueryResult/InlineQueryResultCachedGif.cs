// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>Represents a link to an animated GIF file stored on the Telegram servers. By default, this animated GIF file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with specified content instead of the animation.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineQueryResultCachedGif : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultCachedGif>
{
	/// <summary>Type of the result, must be gif.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InlineQueryResultType.Gif;
	/// <summary>A valid file identifier for the GIF file..</summary>
	[JsonPropertyName(PropertyNames.GifFileId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string GifFileId { get; set; }
	/// <summary>Optional. Title of the result.</summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Title { get; set; }
	/// <summary>Optional. Caption of the GIF file to be sent, 0-1024 characters.</summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Caption { get; set; }
	/// <summary>Optional. Content of the message to be sent instead of the GIF animation.</summary>
	[JsonPropertyName(PropertyNames.InputMessageContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputMessageContent? InputMessageContent { get; set; }

	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as InlineQueryResultCachedGif);
	}
	/// <inheritdoc/>
	public bool Equals(InlineQueryResultCachedGif? other)
	{
		return other != null &&
			   this.Id == other.Id &&
			   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
			   this.ParseMode == other.ParseMode &&
			   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
			   this.Type == other.Type &&
			   this.GifFileId == other.GifFileId &&
			   this.Title == other.Title &&
			   this.Caption == other.Caption &&
			   EqualityComparer<InputMessageContent?>.Default.Equals(this.InputMessageContent, other.InputMessageContent);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1392083928;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.GifFileId);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Title);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
		hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent?>.Default.GetHashCode(this.InputMessageContent);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InlineQueryResultCachedGif? left, InlineQueryResultCachedGif? right)
	{
		return EqualityComparer<InlineQueryResultCachedGif>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InlineQueryResultCachedGif? left, InlineQueryResultCachedGif? right)
	{
		return !(left == right);
	}

}
