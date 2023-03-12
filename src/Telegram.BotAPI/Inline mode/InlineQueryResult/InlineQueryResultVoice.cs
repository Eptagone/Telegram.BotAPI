// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents a link to a voice recording in an .ogg container encoded with OPUS. By default, this voice recording will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the the voice message.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineQueryResultVoice : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultVoice>
	{
		/// <summary>Type of the result, must be voice.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InlineQueryResultType.Voice;
		/// <summary>A valid URL for the voice recording.</summary>
		[JsonPropertyName(PropertyNames.VoiceUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string VoiceUrl { get; set; }
		/// <summary>Optional. Caption, 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		/// <summary>Optional. Recording duration in seconds.</summary>
		[JsonPropertyName(PropertyNames.VoiceDuration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? VoiceDuration { get; set; }
		/// <summary>Optional. Content of the message to be sent instead of the voice message.</summary>
		[JsonPropertyName(PropertyNames.InputMessageContent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InputMessageContent? InputMessageContent { get; set; }

		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InlineQueryResultVoice);
		}
		/// <inheritdoc/>
		public bool Equals(InlineQueryResultVoice? other)
		{
			return other != null &&
				   this.Id == other.Id &&
				   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
				   this.ParseMode == other.ParseMode &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
				   this.Type == other.Type &&
				   this.VoiceUrl == other.VoiceUrl &&
				   this.Caption == other.Caption &&
				   this.VoiceDuration == other.VoiceDuration &&
				   EqualityComparer<InputMessageContent>.Default.Equals(this.InputMessageContent, other.InputMessageContent);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 973908680;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.VoiceUrl);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + this.VoiceDuration.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(this.InputMessageContent);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InlineQueryResultVoice? left, InlineQueryResultVoice? right)
		{
			return EqualityComparer<InlineQueryResultVoice>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InlineQueryResultVoice? left, InlineQueryResultVoice? right)
		{
			return !(left == right);
		}

	}
}
