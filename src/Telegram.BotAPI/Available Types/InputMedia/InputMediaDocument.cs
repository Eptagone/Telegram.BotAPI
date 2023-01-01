// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>Represents a general file to be sent.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InputMediaDocument : InputMedia, IThumbnail<string>, IEquatable<InputMediaDocument>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InputMediaDocument"/> class.
		/// </summary>
		/// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</param>
		public InputMediaDocument(string media) : base(media)
		{
		}

		///<summary>Type of the result, must be document.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InputMediaType.Document;
		///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
		[JsonPropertyName(PropertyNames.Thumb)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Thumb { get; set; }
		///<summary>Optional. Caption of the document to be sent, 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string? Caption { get; set; }
		///<summary>Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</summary>
		[JsonPropertyName(PropertyNames.DisableContentTypeDetection)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? DisableContentTypeDetection { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InputMediaDocument);
		}
		/// <inheritdoc/>
		public bool Equals(InputMediaDocument? other)
		{
			return other != null &&
				   this.Media == other.Media &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
				   this.Type == other.Type &&
				   this.Thumb == other.Thumb &&
				   this.Caption == other.Caption &&
				   this.ParseMode == other.ParseMode &&
				   this.DisableContentTypeDetection == other.DisableContentTypeDetection;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 363848984;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Media);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Thumb);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
			hashCode = hashCode * -1521134295 + this.DisableContentTypeDetection.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InputMediaDocument? left, InputMediaDocument? right)
		{
			return EqualityComparer<InputMediaDocument>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InputMediaDocument? left, InputMediaDocument? right)
		{
			return !(left == right);
		}

	}
}
