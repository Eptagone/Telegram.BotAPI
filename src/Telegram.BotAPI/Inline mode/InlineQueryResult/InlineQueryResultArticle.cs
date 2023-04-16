// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>Represents a link to an article or web page.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineQueryResultArticle : InlineQueryResult, IExternalThumbnail, IEquatable<InlineQueryResultArticle>
{
	/// <summary>Type of the result, must be article.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InlineQueryResultType.Article;
	/// <summary>Title of the result.</summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Title { get; set; }
	/// <summary>Content of the message to be sent.</summary>
	[JsonPropertyName(PropertyNames.InputMessageContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputMessageContent InputMessageContent { get; set; }
	/// <summary>Optional. URL of the result.</summary>
	[JsonPropertyName(PropertyNames.Url)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Url { get; set; }
	/// <summary>Optional. Pass True, if you don't want the URL to be shown in the message.</summary>
	[JsonPropertyName(PropertyNames.HideUrl)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HideUrl { get; set; }
	/// <summary>Optional. Short description of the result.</summary>
	[JsonPropertyName(PropertyNames.Description)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Description { get; set; }
	/// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
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
		return this.Equals(obj as InlineQueryResultArticle);
	}
	/// <inheritdoc/>
	public bool Equals(InlineQueryResultArticle? other)
	{
		return other != null &&
			   this.Id == other.Id &&
			   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
			   this.Type == other.Type &&
			   this.Title == other.Title &&
			   EqualityComparer<InputMessageContent>.Default.Equals(this.InputMessageContent, other.InputMessageContent) &&
			   this.Url == other.Url &&
			   this.HideUrl == other.HideUrl &&
			   this.Description == other.Description &&
			   this.ThumbnailUrl == other.ThumbnailUrl &&
			   this.ThumbnailWidth == other.ThumbnailWidth &&
			   this.ThumbnailHeight == other.ThumbnailHeight;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1439155506;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Title);
		hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(this.InputMessageContent);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Url);
		hashCode = hashCode * -1521134295 + this.HideUrl.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Description);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ThumbnailUrl);
		hashCode = hashCode * -1521134295 + this.ThumbnailWidth.GetHashCode();
		hashCode = hashCode * -1521134295 + this.ThumbnailHeight.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InlineQueryResultArticle? left, InlineQueryResultArticle? right)
	{
		return EqualityComparer<InlineQueryResultArticle>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InlineQueryResultArticle? left, InlineQueryResultArticle? right)
	{
		return !(left == right);
	}

}
