// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents a phone contact.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class Contact : IContact, IEquatable<Contact>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Contact"/> class.
	/// </summary>
	public Contact()
	{
		this.PhoneNumber = null!;
		this.FirstName = null!;
		this.LastName = null!;
		this.Vcard = null!;
	}

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
	/// <summary>Optional. Contact's user identifier in Telegram.</summary>
	[JsonPropertyName(PropertyNames.UserId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long? UserId { get; set; }
	/// <summary>Optional. Additional data about the contact in the form of a vCard.</summary>
	[JsonPropertyName(PropertyNames.Vcard)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Vcard { get; set; }

	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as Contact);
	}
	/// <inheritdoc/>
	public bool Equals(Contact? other)
	{
		return other != null &&
			   this.PhoneNumber == other.PhoneNumber &&
			   this.FirstName == other.FirstName &&
			   this.LastName == other.LastName &&
			   this.UserId == other.UserId &&
			   this.Vcard == other.Vcard;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 267866028;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.PhoneNumber);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FirstName);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.LastName);
		hashCode = hashCode * -1521134295 + this.UserId.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Vcard);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(Contact? left, Contact? right)
	{
#pragma warning disable CS8604 // Possible null reference argument.
		return EqualityComparer<Contact>.Default.Equals(left!, right!);
#pragma warning restore CS8604 // Possible null reference argument.
	}
	/// <inheritdoc/>
	public static bool operator !=(Contact? left, Contact? right)
	{
		return !(left == right);
	}

}
