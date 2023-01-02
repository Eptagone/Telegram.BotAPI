// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
	/// <summary>
	/// This object represents a sticker.
	/// </summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class Sticker : IEquatable<Sticker>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Sticker"/> class.
		/// </summary>
		public Sticker()
		{
			this.FileId = null!;
			this.FileUniqueId = null!;
			this.Type = null!;
			this.Thumb = null!;
			this.Emoji = null!;
			this.SetName = null!;
			this.PremiumAnimation = null!;
			this.MaskPosition = null!;
			this.CustomEmojiId = null!;
		}

		/// <summary>
		/// Identifier for this file, which can be used to download or reuse the file.
		/// </summary>
		[JsonPropertyName(PropertyNames.FileId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FileId { get; set; }
		/// <summary>
		/// Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.
		/// </summary>
		[JsonPropertyName(PropertyNames.FileUniqueId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FileUniqueId { get; set; }
		/// <summary>
		/// Type of the sticker, currently one of �regular�, �mask�, �custom_emoji�. The type of the sticker is independent from its format, which is determined by the fields is_animated and is_video.
		/// </summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Type { get; set; }
		/// <summary>
		/// Sticker width.
		/// </summary>
		[JsonPropertyName(PropertyNames.Width)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Width { get; set; }
		/// <summary>
		/// Sticker height.
		/// </summary>
		[JsonPropertyName(PropertyNames.Height)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Height { get; set; }
		/// <summary>
		/// True, if the sticker is animated.
		/// </summary>
		[JsonPropertyName(PropertyNames.IsAnimated)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool IsAnimated { get; set; }
		/// <summary>
		/// True, if the sticker is a video sticker.
		/// </summary>
		[JsonPropertyName(PropertyNames.IsVideo)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool IsVideo { get; set; }
		/// <summary>
		/// Optional. Sticker thumbnail in the .webp or .jpg format.
		/// </summary>
		[JsonPropertyName(PropertyNames.Thumb)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PhotoSize Thumb { get; set; }
		/// <summary>
		/// Optional. Emoji associated with the sticker.
		/// </summary>
		[JsonPropertyName(PropertyNames.Emoji)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Emoji { get; set; }
		/// <summary>
		/// Optional. Name of the sticker set to which the sticker belongs.
		/// </summary>
		[JsonPropertyName(PropertyNames.SetName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string SetName { get; set; }
		/// <summary>
		/// Optional. Premium animation for the sticker, if the sticker is premium
		/// </summary>
		[JsonPropertyName(PropertyNames.PremiumAnimation)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public File PremiumAnimation { get; set; }
		/// <summary>
		/// Optional. For mask stickers, the position where the mask should be placed.
		/// </summary>
		[JsonPropertyName(PropertyNames.MaskPosition)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public MaskPosition MaskPosition { get; set; }
		/// <summary>
		/// Optional. For custom emoji stickers, unique identifier of the custom emoji.
		/// </summary>
		[JsonPropertyName(PropertyNames.CustomEmojiId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string CustomEmojiId { get; set; }
		/// <summary>
		/// Optional. File size.
		/// </summary>
		[JsonPropertyName(PropertyNames.FileSize)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint FileSize { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Sticker);
		}
		/// <inheritdoc/>
		public bool Equals(Sticker? other)
		{
			return other != null &&
				   this.FileId == other.FileId &&
				   this.FileUniqueId == other.FileUniqueId &&
				   this.Type == other.Type &&
				   this.Width == other.Width &&
				   this.Height == other.Height &&
				   this.IsAnimated == other.IsAnimated &&
				   this.IsVideo == other.IsVideo &&
				   EqualityComparer<PhotoSize>.Default.Equals(this.Thumb, other.Thumb) &&
				   this.Emoji == other.Emoji &&
				   this.SetName == other.SetName &&
				   EqualityComparer<MaskPosition>.Default.Equals(this.MaskPosition, other.MaskPosition) &&
				   this.CustomEmojiId == other.CustomEmojiId &&
				   this.FileSize == other.FileSize;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1863026592;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileUniqueId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + this.Width.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Height.GetHashCode();
			hashCode = hashCode * -1521134295 + this.IsAnimated.GetHashCode();
			hashCode = hashCode * -1521134295 + this.IsVideo.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize>.Default.GetHashCode(this.Thumb);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Emoji);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.SetName);
			hashCode = hashCode * -1521134295 + EqualityComparer<MaskPosition>.Default.GetHashCode(this.MaskPosition);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.CustomEmojiId);
			hashCode = hashCode * -1521134295 + this.FileSize.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(Sticker? left, Sticker? right)
		{
#pragma warning disable CS8604 // Possible null reference argument.
			return EqualityComparer<Sticker>.Default.Equals(left!, right!);
#pragma warning restore CS8604 // Possible null reference argument.
		}
		/// <inheritdoc/>
		public static bool operator !=(Sticker? left, Sticker? right)
		{
			return !(left == right);
		}

	}

	/// <summary>
	/// Type of the sticker, currently one of �regular�, �mask�, �custom_emoji�. The type of the sticker is independent from its format, which is determined by the fields is_animated and is_video.
	/// </summary>
	public static class StickerType
	{
		/// <summary>
		/// Regular sticker.
		/// </summary>
		public const string Regular = "regular";
	}
}
