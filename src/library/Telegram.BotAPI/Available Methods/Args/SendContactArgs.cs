// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SendContact method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendContactArgs
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendContactArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendContactArgs(long chatId, string phoneNumber, string firstName)
	{
		this.ChatId = chatId;
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
	public SendContactArgs(string chatId, string phoneNumber, string firstName)
	{
		this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
		this.PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// Contact's phone number
	/// </summary>
	[JsonPropertyName(PropertyNames.PhoneNumber)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string PhoneNumber { get; set; }
	/// <summary>
	/// Contact's first name
	/// </summary>
	[JsonPropertyName(PropertyNames.FirstName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string FirstName { get; set; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// Contact's last name
	/// </summary>
	[JsonPropertyName(PropertyNames.LastName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? LastName { get; set; }
	/// <summary>
	/// Additional data about the contact in the form of a vCard, 0-2048 bytes
	/// </summary>
	[JsonPropertyName(PropertyNames.Vcard)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Vcard { get; set; }
	/// <summary>
	/// Sends the message silently. Users will receive a notification with no sound.
	/// </summary>
	[JsonPropertyName(PropertyNames.DisableNotification)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DisableNotification { get; set; }
	/// <summary>
	/// Protects the contents of the sent message from forwarding and saving
	/// </summary>
	[JsonPropertyName(PropertyNames.ProtectContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ProtectContent { get; set; }
	/// <summary>
	/// Description of the message to reply to
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyParameters)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyParameters? ReplyParameters { get; set; }
	/// <summary>
	/// Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyMarkup)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyMarkup? ReplyMarkup { get; set; }
}
