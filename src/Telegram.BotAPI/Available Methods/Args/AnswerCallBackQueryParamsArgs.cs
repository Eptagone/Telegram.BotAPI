// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>AnswerCallbackQuery method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class AnswerCallbackQueryArgs
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AnswerCallbackQueryArgs"/> class.
	/// </summary>
	/// <param name="callbackQueryId">Unique identifier for the query to be answered.</param>
	/// <exception cref="ArgumentNullException">Throws if <paramref name="callbackQueryId"/> is null.</exception>
	public AnswerCallbackQueryArgs(string callbackQueryId)
	{
		this.CallbackQueryId = callbackQueryId ?? throw new ArgumentNullException(nameof(callbackQueryId));
	}

	/// <summary>Unique identifier for the query to be answered.</summary>
	[JsonPropertyName(PropertyNames.CallbackQueryId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string CallbackQueryId { get; set; }
	/// <summary>Optional. Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters.</summary>
	[JsonPropertyName(PropertyNames.Text)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Text { get; set; }
	/// <summary>Optional. If true, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to false.</summary>
	[JsonPropertyName(PropertyNames.ShowAlert)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ShowAlert { get; set; }
	/// <summary>Optional. URL that will be opened by the user's client. If you have created a Game and accepted the conditions via @Botfather, specify the URL that opens your game – note that this will only work if the query comes from a callback_game button.<br/> Otherwise, you may use links like t.me/your_bot?start=XXXX that open your bot with a parameter.</summary>
	[JsonPropertyName(PropertyNames.Url)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Url { get; set; }
	/// <summary>Optional. The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.</summary>
	[JsonPropertyName(PropertyNames.CacheTime)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? CacheTime { get; set; }
}
