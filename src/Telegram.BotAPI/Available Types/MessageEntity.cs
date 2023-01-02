// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents one special entity in a text message. For example, hashtags, usernames, URLs, etc.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class MessageEntity : IEquatable<MessageEntity>
	{
		/// <summary>
		/// Type of the entity. Currently, can be “mention” (@username), “hashtag” (#hashtag), “cashtag” ($USD), “bot_command” (/start@jobs_bot), “url” (https://telegram.org), “email” (do-not-reply@telegram.org), “phone_number” (+1-212-555-0123), “bold” (bold text), “italic” (italic text), “underline” (underlined text), “strikethrough” (strikethrough text), “spoiler” (spoiler message), “code” (monowidth string), “pre” (monowidth block), “text_link” (for clickable text URLs), “text_mention” (for users without usernames), “custom_emoji” (for inline custom emoji stickers)
		/// </summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Type { get; set; }
		/// <summary>Offset in UTF-16 code units to the start of the entity.</summary>
		[JsonPropertyName(PropertyNames.Offset)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int Offset { get; set; }
		/// <summary>Length of the entity in UTF-16 code units.</summary>
		[JsonPropertyName(PropertyNames.Length)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int Length { get; set; }
		/// <summary>Optional. For “text_link” only, url that will be opened after user taps on the text.</summary>
		[JsonPropertyName(PropertyNames.Url)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>Optional. For “text_mention” only, the mentioned user.</summary>
		[JsonPropertyName(PropertyNames.User)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User User { get; set; }
		/// <summary>Optional. For “pre” only, the programming language of the entity text.</summary>
		[JsonPropertyName(PropertyNames.Language)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Language { get; set; }
		/// <summary>Optional. For “custom_emoji” only, unique identifier of the custom emoji. Use getCustomEmojiStickers to get full information about the sticker.</summary>
		[JsonPropertyName(PropertyNames.CustomEmojiId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string CustomEmojiId { get; set; }
		/// <summary>Get the entity type as enum.</summary>
		/// <returns><see cref="MessageEntityType"/></returns>
		public MessageEntityType GetEntityType()
		{
			string type = this.Type.Replace("_", string.Empty);
			return (MessageEntityType)Enum.Parse(typeof(MessageEntityType), type, true);
		}
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as MessageEntity);
		}
		/// <inheritdoc/>
		public bool Equals(MessageEntity? other)
		{
			return other != null &&
				   this.Type == other.Type &&
				   this.Offset == other.Offset &&
				   this.Length == other.Length &&
				   this.Url == other.Url &&
				   EqualityComparer<User>.Default.Equals(this.User, other.User) &&
				   this.Language == other.Language &&
				   this.CustomEmojiId == other.CustomEmojiId;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -730586585;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + this.Offset.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Length.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Url);
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.User);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Language);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.CustomEmojiId);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(MessageEntity? left, MessageEntity? right)
		{
			return EqualityComparer<MessageEntity>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(MessageEntity? left, MessageEntity? right)
		{
			return !(left == right);
		}

	}
}
