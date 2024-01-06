// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>Represents a link to an mp3 audio file. By default, this audio file will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the audio.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineQueryResultAudio : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultAudio?>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InlineQueryResultAudio"/> class.
	/// </summary>
	public InlineQueryResultAudio()
	{
		this.AudioUrl = null!;
	}

	/// <summary>Type of the result, must be audio.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InlineQueryResultType.Audio;
	/// <summary>A valid URL for the audio file.</summary>
	[JsonPropertyName(PropertyNames.AudioUrl)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string AudioUrl { get; set; }
	/// <summary>Optional. Caption, 0-1024 characters.</summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Caption { get; set; }
	/// <summary>Optional. Performer.</summary>
	[JsonPropertyName(PropertyNames.Performer)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Performer { get; set; }
	/// <summary>Optional. Audio duration in seconds.</summary>
	[JsonPropertyName(PropertyNames.AudioDuration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? AudioDuration { get; set; }
	/// <summary>Optional. Content of the message to be sent instead of the audio.</summary>
	[JsonPropertyName(PropertyNames.InputMessageContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputMessageContent? InputMessageContent { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object? obj)
	{
		return this.Equals(obj as InlineQueryResultAudio);
	}
	/// <inheritdoc/>
	public bool Equals(InlineQueryResultAudio? other)
	{
		return other is not null &&
			   this.Type == other.Type &&
			   this.Id == other.Id &&
			   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
			   this.ParseMode == other.ParseMode &&
			   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
			   this.Type == other.Type &&
			   this.AudioUrl == other.AudioUrl &&
			   this.Caption == other.Caption &&
			   this.Performer == other.Performer &&
			   this.AudioDuration == other.AudioDuration &&
			   EqualityComparer<InputMessageContent?>.Default.Equals(this.InputMessageContent, other.InputMessageContent);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1042699274;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.AudioUrl);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Performer);
		hashCode = hashCode * -1521134295 + this.AudioDuration.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent?>.Default.GetHashCode(this.InputMessageContent);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InlineQueryResultAudio? left, InlineQueryResultAudio? right)
	{
		return EqualityComparer<InlineQueryResultAudio>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InlineQueryResultAudio? left, InlineQueryResultAudio? right)
	{
		return !(left == right);
	}

}
