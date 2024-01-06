// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SendPoll method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendPollArgs
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendPollArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="question">Poll question, 1-300 characters.</param>
	/// <param name="options">List of answer options, 2-10 strings 1-100 characters each.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendPollArgs(long chatId, string question, IEnumerable<string> options)
	{
		this.ChatId = chatId;
		this.Question = question ?? throw new ArgumentNullException(nameof(question));
		this.Options = options ?? throw new ArgumentNullException(nameof(options));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendPollArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="question">Poll question, 1-300 characters.</param>
	/// <param name="options">List of answer options, 2-10 strings 1-100 characters each.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendPollArgs(string chatId, string question, IEnumerable<string> options)
	{
		this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
		this.Question = question ?? throw new ArgumentNullException(nameof(question));
		this.Options = options ?? throw new ArgumentNullException(nameof(options));
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// Poll question, 1-300 characters
	/// </summary>
	[JsonPropertyName(PropertyNames.Question)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Question { get; set; }
	/// <summary>
	/// A JSON-serialized list of answer options, 2-10 strings 1-100 characters each
	/// </summary>
	[JsonPropertyName(PropertyNames.Options)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<string> Options { get; set; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// True, if the poll needs to be anonymous, defaults to True
	/// </summary>
	[JsonPropertyName(PropertyNames.IsAnonymous)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? IsAnonymous { get; set; }
	/// <summary>
	/// Poll type, “quiz” or “regular”, defaults to “regular”
	/// </summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Type { get; set; }
	/// <summary>
	/// True, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to False
	/// </summary>
	[JsonPropertyName(PropertyNames.AllowsMultipleAnswers)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? AllowsMultipleAnswers { get; set; }
	/// <summary>
	/// 0-based identifier of the correct answer option, required for polls in quiz mode
	/// </summary>
	[JsonPropertyName(PropertyNames.CorrectOptionId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? CorrectOptionId { get; set; }
	/// <summary>
	/// Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing
	/// </summary>
	[JsonPropertyName(PropertyNames.Explanation)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Explanation { get; set; }
	/// <summary>
	/// Mode for parsing entities in the explanation. See formatting options for more details.
	/// </summary>
	[JsonPropertyName(PropertyNames.ExplanationParseMode)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? ExplanationParseMode { get; set; }
	/// <summary>
	/// A JSON-serialized list of special entities that appear in the poll explanation, which can be specified instead of parse_mode
	/// </summary>
	[JsonPropertyName(PropertyNames.ExplanationEntities)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<MessageEntity>? ExplanationEntities { get; set; }
	/// <summary>
	/// Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with close_date.
	/// </summary>
	[JsonPropertyName(PropertyNames.OpenPeriod)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? OpenPeriod { get; set; }
	/// <summary>
	/// Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with open_period.
	/// </summary>
	[JsonPropertyName(PropertyNames.CloseDate)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? CloseDate { get; set; }
	/// <summary>
	/// Pass True if the poll needs to be immediately closed. This can be useful for poll preview.
	/// </summary>
	[JsonPropertyName(PropertyNames.IsClosed)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? IsClosed { get; set; }
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
