// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>Represents a photo to be sent.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InputMediaPhoto : InputMedia, IEquatable<InputMediaPhoto?>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InputMediaPhoto"/> class.
		/// </summary>
		/// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</param>
		public InputMediaPhoto(string media) : base(media)
		{
		}

		/// <summary>Type of the result, must be photo.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InputMediaType.Photo;
		/// <summary>Optional. Caption of the photo to be sent, 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string? Caption { get; set; }
		/// <summary>Optional. Pass True if the photo needs to be covered with a spoiler animation.</summary>
		[JsonPropertyName(PropertyNames.HasSpoiler)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? HasSpoiler { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as InputMediaPhoto);
		}
		/// <inheritdoc/>
		public bool Equals(InputMediaPhoto? other)
		{
			return other is not null &&
				   this.Type == other.Type &&
				   this.Media == other.Media &&
				   this.Caption == other.Caption &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
				   this.ParseMode == other.ParseMode &&
				   this.Type == other.Type &&
				   this.Caption == other.Caption &&
				   this.HasSpoiler == other.HasSpoiler;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 397299575;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Media);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + this.HasSpoiler.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InputMediaPhoto? left, InputMediaPhoto? right)
		{
			return EqualityComparer<InputMediaPhoto>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InputMediaPhoto? left, InputMediaPhoto? right)
		{
			return !(left == right);
		}
	}
}
