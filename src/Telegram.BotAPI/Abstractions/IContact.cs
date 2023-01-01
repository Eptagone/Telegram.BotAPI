// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a phone contact. Used by <see cref="Contact"/></summary>
	public interface IContact
	{
		/// <summary>Contact's phone number.</summary>
		public string PhoneNumber { get; }
		/// <summary>Contact's first name.</summary>
		public string FirstName { get; }
		/// <summary>Optional. Contact's last name.</summary>
		public string LastName { get; set; }
		/// <summary>Optional. Additional data about the contact in the form of a vCard.</summary>
		public string Vcard { get; set; }
	}
}
