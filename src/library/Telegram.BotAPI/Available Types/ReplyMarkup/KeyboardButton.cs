// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents one button of the reply keyboard. For simple text buttons, String can be used instead of this object to specify the button text. The optional fields web_app, request_user, request_chat, request_contact, request_location, and request_poll are mutually exclusive.
/// </summary>
/// <param name="text">Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed.</param>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class KeyboardButton(string text)
{
	/// <summary>
	/// Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed
	/// </summary>
	[JsonPropertyName(PropertyNames.Text)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Text { get; set; } = text;
	/// <summary>
	/// Optional. If specified, pressing the button will open a list of suitable users. Identifiers of selected users will be sent to the bot in a “users_shared” service message. Available in private chats only.
	/// </summary>
	[JsonPropertyName(PropertyNames.RequestUsers)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public KeyboardButtonRequestUsers? RequestUsers { get; set; }
	/// <summary>
	/// Optional. If specified, pressing the button will open a list of suitable chats. Tapping on a chat will send its identifier to the bot in a “chat_shared” service message. Available in private chats only.
	/// </summary>
	[JsonPropertyName(PropertyNames.RequestChat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public KeyboardButtonRequestChat? RequestChat { get; set; }
	/// <summary>
	/// Optional. If True, the user's phone number will be sent as a contact when the button is pressed. Available in private chats only.
	/// </summary>
	[JsonPropertyName(PropertyNames.RequestContact)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? RequestContact { get; set; }
	/// <summary>
	/// Optional. If True, the user's current location will be sent when the button is pressed. Available in private chats only.
	/// </summary>
	[JsonPropertyName(PropertyNames.RequestLocation)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? RequestLocation { get; set; }
	/// <summary>
	/// Optional. If specified, the user will be asked to create a poll and send it to the bot when the button is pressed. Available in private chats only.
	/// </summary>
	[JsonPropertyName(PropertyNames.RequestPoll)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public KeyboardButtonPollType? RequestPoll { get; set; }
	/// <summary>
	/// Optional. If specified, the described Web App will be launched when the button is pressed. The Web App will be able to send a “web_app_data” service message. Available in private chats only.
	/// </summary>
	[JsonPropertyName(PropertyNames.WebApp)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public WebAppInfo? WebApp { get; set; }

	/// <summary>
	/// Optional. If specified, pressing the button will open a list of suitable users. Tapping on any user will send their identifier to the bot in a “user_shared” service message. Available in private chats only.
	/// </summary>
	/// <remarks>
	/// This property is only here for backward compatibility. Use RequestUsers instead.
	/// </remarks>
	[JsonPropertyName(PropertyNames.RequestUser)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	[Obsolete("Use RequestUsers instead")]
	public KeyboardButtonRequestUser? RequestUser { get; set; }
}
