// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>Represents a contact with a phone number. By default, this contact will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the contact.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineQueryResultContact : InlineQueryResult, IContact, IExternalThumbnail, IEquatable<InlineQueryResultContact>
{
	/// <summary>Type of the result, must be contact.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InlineQueryResultType.Contact;
	/// <summary>Contact's phone number.</summary>
	[JsonPropertyName(PropertyNames.PhoneNumber)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string PhoneNumber { get; set; }
	/// <summary>Contact's first name.</summary>
	[JsonPropertyName(PropertyNames.FirstName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string FirstName { get; set; }
	/// <summary>Optional. Contact's last name.</summary>
	[JsonPropertyName(PropertyNames.LastName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? LastName { get; set; }
	/// <summary>Optional. Additional data about the contact in the form of a vCard, 0-2048 bytes.</summary>
	[JsonPropertyName(PropertyNames.Vcard)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Vcard { get; set; }
	/// <summary>Optional. Content of the message to be sent instead of the contact.</summary>
	[JsonPropertyName(PropertyNames.InputMessageContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputMessageContent? InputMessageContent { get; set; }
	/// <summary>Optional. Url of the thumbnail for the result.</summary>
	[JsonPropertyName(PropertyNames.ThumbnailUrl)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? ThumbnailUrl { get; set; }
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
		return this.Equals(obj as InlineQueryResultContact);
	}
	/// <inheritdoc/>
	public bool Equals(InlineQueryResultContact? other)
	{
		return other != null &&
			   this.Id == other.Id &&
			   EqualityComparer<InlineKeyboardMarkup?>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
			   this.Type == other.Type &&
			   this.PhoneNumber == other.PhoneNumber &&
			   this.FirstName == other.FirstName &&
			   this.LastName == other.LastName &&
			   this.Vcard == other.Vcard &&
			   EqualityComparer<InputMessageContent?>.Default.Equals(this.InputMessageContent, other.InputMessageContent) &&
			   this.ThumbnailUrl == other.ThumbnailUrl &&
			   this.ThumbnailWidth == other.ThumbnailWidth &&
			   this.ThumbnailHeight == other.ThumbnailHeight;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -737408647;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup?>.Default.GetHashCode(this.ReplyMarkup);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.PhoneNumber);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FirstName);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.LastName);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Vcard);
		hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent?>.Default.GetHashCode(this.InputMessageContent);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ThumbnailUrl);
		hashCode = hashCode * -1521134295 + this.ThumbnailWidth.GetHashCode();
		hashCode = hashCode * -1521134295 + this.ThumbnailHeight.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InlineQueryResultContact? left, InlineQueryResultContact? right)
	{
		return EqualityComparer<InlineQueryResultContact>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InlineQueryResultContact? left, InlineQueryResultContact? right)
	{
		return !(left == right);
	}

}
