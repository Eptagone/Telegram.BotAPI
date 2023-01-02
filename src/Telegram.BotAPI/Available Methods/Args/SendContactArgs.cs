// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Telegram.BotAPI.AvailableMethods
{
	/// <summary>SendContact method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SendContactArgs : SendMessageWithReplyMarkupBase
	{
		/// <summary>
		/// Initialize a new instance of <see cref="SendContactArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="phoneNumber">Contact's phone number.</param>
		/// <param name="firstName">Contact's first name.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendContactArgs(long chatId, string phoneNumber, string firstName) : base(chatId)
		{
			this.PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
			this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
		}
		/// <summary>
		/// Initialize a new instance of <see cref="SendContactArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="phoneNumber">Contact's phone number.</param>
		/// <param name="firstName">Contact's first name.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendContactArgs(string chatId, string phoneNumber, string firstName) : base(chatId)
		{
			this.PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
			this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
		}

		///<summary>Contact's phone number.</summary>
		[JsonPropertyName(PropertyNames.PhoneNumber)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string PhoneNumber { get; }
		/// <summary>Contact's first name.</summary>
		[JsonPropertyName(PropertyNames.FirstName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FirstName { get; }
		/// <summary>Optional. Contact's last name.</summary>
		[JsonPropertyName(PropertyNames.LastName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? LastName { get; set; }
		/// <summary>Optional. Additional data about the contact in the form of a vCard, 0-2048 bytes.</summary>
		[JsonPropertyName(PropertyNames.Vcard)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Vcard { get; set; }
	}
}
