// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.Games;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents one button of an inline keyboard. You must use exactly one of the optional fields.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineKeyboardButton : IEquatable<InlineKeyboardButton?>
{
	/// <summary>
	/// Initialize a new instance of <see cref="InlineKeyboardButton"/>.
	/// </summary>
	public InlineKeyboardButton()
	{
		this.Text = string.Empty;
	}

	/// <summary>
	/// Initialize a new instance of <see cref="InlineKeyboardButton"/>.
	/// </summary>
	/// <param name="text">Label text on the button.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public InlineKeyboardButton(string text)
	{
		this.Text = text ?? throw new ArgumentNullException(nameof(text));
	}

	/// <summary>
	/// Label text on the button
	/// </summary>
	[JsonPropertyName(PropertyNames.Text)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Text { get; set; }
	/// <summary>
	/// Optional. HTTP or tg:// URL to be opened when the button is pressed. Links tg://user?id=&lt;user_id&gt; can be used to mention a user by their ID without using a username, if this is allowed by their privacy settings.
	/// </summary>
	[JsonPropertyName(PropertyNames.Url)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Url { get; set; }
	/// <summary>
	/// Optional. Data to be sent in a callback query to the bot when button is pressed, 1-64 bytes
	/// </summary>
	[JsonPropertyName(PropertyNames.CallbackData)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? CallbackData { get; set; }
	/// <summary>
	/// Optional. Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method answerWebAppQuery. Available only in private chats between a user and the bot.
	/// </summary>
	[JsonPropertyName(PropertyNames.WebApp)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public WebAppInfo? WebApp { get; set; }
	/// <summary>
	/// Optional. An HTTPS URL used to automatically authorize the user. Can be used as a replacement for the Telegram Login Widget.
	/// </summary>
	[JsonPropertyName(PropertyNames.LoginUrl)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public LoginUrl? LoginUrl { get; set; }
	/// <summary>
	/// Optional. If set, pressing the button will prompt the user to select one of their chats, open that chat and insert the bot's username and the specified inline query in the input field. May be empty, in which case just the bot's username will be inserted.
	/// 
	/// Note: This offers an easy way for users to start using your bot in inline mode when they are currently in a private chat with it. Especially useful when combined with switch_pm… actions - in this case the user will be automatically returned to the chat they switched from, skipping the chat selection screen.
	/// </summary>
	[JsonPropertyName(PropertyNames.SwitchInlineQuery)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? SwitchInlineQuery { get; set; }
	/// <summary>
	/// Optional. If set, pressing the button will insert the bot's username and the specified inline query in the current chat's input field. May be empty, in which case only the bot's username will be inserted.
	/// 
	/// This offers a quick way for the user to open your bot in inline mode in the same chat - good for selecting something from multiple options.
	/// </summary>
	[JsonPropertyName(PropertyNames.SwitchInlineQueryCurrentChat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? SwitchInlineQueryCurrentChat { get; set; }
	/// <summary>
	/// Optional. If set, pressing the button will prompt the user to select one of their chats of the specified type, open that chat and insert the bot's username and the specified inline query in the input field
	/// </summary>
	[JsonPropertyName(PropertyNames.SwitchInlineQueryChosenChat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public SwitchInlineQueryChosenChat? SwitchInlineQueryChosenChat { get; set; }
	/// <summary>
	/// Optional. Description of the game that will be launched when the user presses the button.
	/// 
	/// NOTE: This type of button must always be the first button in the first row.
	/// </summary>
	[JsonPropertyName(PropertyNames.CallbackGame)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CallbackGame? CallbackGame { get; set; }
	/// <summary>
	/// Optional. Specify True, to send a Pay button.
	/// 
	/// NOTE: This type of button must always be the first button in the first row and can only be used in invoice messages.
	/// </summary>
	[JsonPropertyName(PropertyNames.Pay)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? Pay { get; set; }

	/// <inheritdoc />
	public override bool Equals(object? obj)
	{
		return this.Equals(obj as InlineKeyboardButton);
	}

	/// <inheritdoc />
	public bool Equals(InlineKeyboardButton? other)
	{
		return other is not null &&
			   this.Text == other.Text &&
			   this.Url == other.Url &&
			   this.CallbackData == other.CallbackData &&
			   EqualityComparer<WebAppInfo?>.Default.Equals(this.WebApp, other.WebApp) &&
			   EqualityComparer<LoginUrl?>.Default.Equals(this.LoginUrl, other.LoginUrl) &&
			   this.SwitchInlineQuery == other.SwitchInlineQuery &&
			   this.SwitchInlineQueryCurrentChat == other.SwitchInlineQueryCurrentChat &&
			   EqualityComparer<SwitchInlineQueryChosenChat?>.Default.Equals(this.SwitchInlineQueryChosenChat, other.SwitchInlineQueryChosenChat) &&
			   EqualityComparer<CallbackGame?>.Default.Equals(this.CallbackGame, other.CallbackGame) &&
			   this.Pay == other.Pay;
	}

	/// <inheritdoc />
	public override int GetHashCode()
	{
		int hashCode = -1921518019;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Text);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Url);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.CallbackData);
		hashCode = hashCode * -1521134295 + EqualityComparer<WebAppInfo?>.Default.GetHashCode(this.WebApp);
		hashCode = hashCode * -1521134295 + EqualityComparer<LoginUrl?>.Default.GetHashCode(this.LoginUrl);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.SwitchInlineQuery);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.SwitchInlineQueryCurrentChat);
		hashCode = hashCode * -1521134295 + EqualityComparer<SwitchInlineQueryChosenChat?>.Default.GetHashCode(this.SwitchInlineQueryChosenChat);
		hashCode = hashCode * -1521134295 + EqualityComparer<CallbackGame?>.Default.GetHashCode(this.CallbackGame);
		hashCode = hashCode * -1521134295 + this.Pay.GetHashCode();
		return hashCode;
	}

	/// <inheritdoc />
	public static bool operator ==(InlineKeyboardButton? left, InlineKeyboardButton? right)
	{
		return EqualityComparer<InlineKeyboardButton?>.Default.Equals(left, right);
	}

	/// <inheritdoc />
	public static bool operator !=(InlineKeyboardButton? left, InlineKeyboardButton? right)
	{
		return !(left == right);
	}
}
