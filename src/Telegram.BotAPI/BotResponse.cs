// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>Represents the bot's response to the request.</summary>
/// <typeparam name="T">Result type.</typeparam>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class BotResponse<T> : IEquatable<BotResponse<T>>
{
	/// <summary>True, if the request was successful, otherwise false.</summary>
	[JsonPropertyName("ok")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool Ok { get; set; }
	/// <summary>Result.</summary>
	[JsonPropertyName("result")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public T Result { get; set; }
	/// <summary>Error code.</summary>
	[JsonPropertyName("error_code")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int ErrorCode { get; set; }
	/// <summary>Error description.</summary>
	[JsonPropertyName("description")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Description { get; set; }
	/// <summary>Parameters.</summary>
	[JsonPropertyName("parameters")]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ResponseParameters Parameters { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as BotResponse<T>);
	}
	/// <inheritdoc/>
	public bool Equals(BotResponse<T>? other)
	{
		return other != null &&
			   this.Ok == other.Ok &&
			   EqualityComparer<T>.Default.Equals(this.Result, other.Result) &&
			   this.ErrorCode == other.ErrorCode &&
			   this.Description == other.Description &&
			   EqualityComparer<ResponseParameters>.Default.Equals(this.Parameters, other.Parameters);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 493339093;
		hashCode = hashCode * -1521134295 + this.Ok.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(this.Result);
		hashCode = hashCode * -1521134295 + this.ErrorCode.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Description);
		hashCode = hashCode * -1521134295 + EqualityComparer<ResponseParameters>.Default.GetHashCode(this.Parameters);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(BotResponse<T>? left, BotResponse<T>? right)
	{
		return EqualityComparer<BotResponse<T>>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(BotResponse<T>? left, BotResponse<T>? right)
	{
		return !(left == right);
	}

}
