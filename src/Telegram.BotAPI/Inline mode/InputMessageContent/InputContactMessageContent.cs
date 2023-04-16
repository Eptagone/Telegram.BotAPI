// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>Represents the content of a contact message to be sent as the result of an inline query.</summary>
public sealed class InputContactMessageContent : InputMessageContent, IContact, IEquatable<InputContactMessageContent>
{
	/// <summary>
	/// Initialize a new instance of <see cref="InputContactMessageContent"/>.
	/// </summary>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <param name="lastName">Contact's last name.</param>
	/// <param name="vcard">Additional data about the contact in the form of a vCard.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public InputContactMessageContent(string phoneNumber, string firstName, [Optional] string? lastName, [Optional] string? vcard)
	{
		this.PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
		this.LastName = lastName;
		this.Vcard = vcard;
	}

	/// <summary>
	/// Initialize a new instance of <see cref="InputContactMessageContent"/>.
	/// </summary>
	/// <param name="contact">Contact.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public InputContactMessageContent(IContact contact) : this(contact.PhoneNumber, contact.FirstName, contact.LastName, contact.Vcard)
	{
	}

	/// <summary>Contact's phone number.</summary>
	public string PhoneNumber { get; }
	/// <summary>Contact's first name.</summary>
	public string FirstName { get; }
	/// <summary>Optional. Contact's last name.</summary>
	public string? LastName { get; set; }
	/// <summary>Optional. Additional data about the contact in the form of a vCard.</summary>
	public string? Vcard { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as InputContactMessageContent);
	}
	/// <inheritdoc/>
	public bool Equals(InputContactMessageContent? other)
	{
		return other != null &&
			   this.PhoneNumber == other.PhoneNumber &&
			   this.FirstName == other.FirstName &&
			   this.LastName == other.LastName &&
			   this.Vcard == other.Vcard;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -229410427;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.PhoneNumber);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FirstName);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.LastName);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Vcard);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InputContactMessageContent? left, InputContactMessageContent? right)
	{
		return EqualityComparer<InputContactMessageContent>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InputContactMessageContent? left, InputContactMessageContent? right)
	{
		return !(left == right);
	}

}
