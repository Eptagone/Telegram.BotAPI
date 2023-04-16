// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Stickers;

/// <summary>This object describes the position on faces where a mask should be placed by default.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class MaskPosition : IEquatable<MaskPosition>
{
	/// <summary>The part of the face relative to which the mask should be placed. One of “forehead”, “eyes”, “mouth”, or “chin”.</summary>
	[JsonPropertyName(PropertyNames.Point)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Point { get; set; }
	/// <summary>Shift by X-axis measured in widths of the mask scaled to the face size, from left to right. For example, choosing -1.0 will place mask just to the left of the default mask position.</summary>
	[JsonPropertyName(PropertyNames.XShift)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float XShift { get; set; }
	/// <summary>Shift by Y-axis measured in heights of the mask scaled to the face size, from top to bottom. For example, 1.0 will place the mask just below the default mask position.</summary>
	[JsonPropertyName(PropertyNames.YShift)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float YShift { get; set; }
	/// <summary>Mask scaling coefficient. For example, 2.0 means double size.</summary>
	[JsonPropertyName(PropertyNames.Scale)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Scale { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as MaskPosition);
	}
	/// <inheritdoc/>
	public bool Equals(MaskPosition? other)
	{
		return other != null &&
			   this.Point == other.Point &&
			   this.XShift == other.XShift &&
			   this.YShift == other.YShift &&
			   this.Scale == other.Scale;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 808330583;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Point);
		hashCode = hashCode * -1521134295 + this.XShift.GetHashCode();
		hashCode = hashCode * -1521134295 + this.YShift.GetHashCode();
		hashCode = hashCode * -1521134295 + this.Scale.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(MaskPosition? left, MaskPosition? right)
	{
		return EqualityComparer<MaskPosition>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(MaskPosition? left, MaskPosition? right)
	{
		return !(left == right);
	}

}
