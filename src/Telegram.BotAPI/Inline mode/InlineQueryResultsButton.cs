// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// This object represents a button to be shown above inline query results. You must use exactly one of the optional fields.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineQueryResultsButton
{
	/// <summary>
	/// Initialize a new instance of <see cref="InlineQueryResultsButton"/>.
	/// </summary>
	/// <param name="text">Label text on the button</param>
	public InlineQueryResultsButton(string text)
	{
		this.Text = text;
	}

	/// <summary>
	/// Label text on the button
	/// </summary>
	[JsonPropertyName(PropertyNames.Text)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Text { get; set; }
	/// <summary>
	/// Optional. Description of the Web App that will be launched when the user presses the button. The Web App will be able to switch back to the inline mode using the method web_app_switch_inline_query inside the Web App.
	/// </summary>
	[JsonPropertyName(PropertyNames.WebApp)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public WebAppInfo? WebApp { get; set; }
	/// <summary>
	/// Optional. Deep-linking parameter for the /start message sent to the bot when a user presses the button. 1-64 characters, only A-Z, a-z, 0-9, _ and - are allowed.
	/// 
	/// Example: An inline bot that sends YouTube videos can ask the user to connect the bot to their YouTube account to adapt search results accordingly. To do this, it displays a 'Connect your YouTube account' button above the results, or even before showing any. The user presses the button, switches to a private chat with the bot and, in doing so, passes a start parameter that instructs the bot to return an OAuth link. Once done, the bot can offer a switch_inline button so that the user can easily return to the chat where they wanted to use the bot's inline capabilities.
	/// </summary>
	[JsonPropertyName(PropertyNames.StartParameter)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? StartParameter { get; set; }
}
