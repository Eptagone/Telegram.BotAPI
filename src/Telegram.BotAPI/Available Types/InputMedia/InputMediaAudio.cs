// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	///<summary>Represents an audio file to be treated as music to be sent.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InputMediaAudio : InputMedia, IThumbnail<string>, IEquatable<InputMediaAudio>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InputMediaAudio"/> class.
		/// </summary>
		/// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</param>
		public InputMediaAudio(string media) : base(media)
		{
		}

		///<summary>Type of the result, must be audio.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InputMediaType.Audio;
		///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
		[JsonPropertyName(PropertyNames.Thumb)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Thumb { get; set; }
		///<summary>Optional. Caption of the audio to be sent, 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string? Caption { get; set; }
		///<summary>Optional. Duration of the audio in seconds.</summary>
		[JsonPropertyName(PropertyNames.Duration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? Duration { get; set; }
		///<summary>Optional. Performer of the audio.</summary>
		[JsonPropertyName(PropertyNames.Performer)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Performer { get; set; }
		///<summary>Optional. Title of the audio.</summary>
		[JsonPropertyName(PropertyNames.Title)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Title { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InputMediaAudio);
		}
		/// <inheritdoc/>
		public bool Equals(InputMediaAudio? other)
		{
			return other != null &&
				   this.Media == other.Media &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
				   this.Type == other.Type &&
				   this.Thumb == other.Thumb &&
				   this.Caption == other.Caption &&
				   this.ParseMode == other.ParseMode &&
				   this.Duration == other.Duration &&
				   this.Performer == other.Performer &&
				   this.Title == other.Title;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1375899436;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Media);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Thumb);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
			hashCode = hashCode * -1521134295 + this.Duration.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Performer);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Title);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InputMediaAudio? left, InputMediaAudio? right)
		{
			return EqualityComparer<InputMediaAudio>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InputMediaAudio? left, InputMediaAudio? right)
		{
			return !(left == right);
		}

	}
}
