// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods
{
	/// <summary>SendPoll method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SendPollArgs : SendMessageWithReplyMarkupBase
	{
		/// <summary>
		/// Initialize a new instance of <see cref="SendPollArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="question">Poll question, 1-300 characters.</param>
		/// <param name="options">List of answer options, 2-10 strings 1-100 characters each.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendPollArgs(long chatId, string question, IEnumerable<string> options) : base(chatId)
		{
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
		public SendPollArgs(string chatId, string question, IEnumerable<string> options) : base(chatId)
		{
			this.Question = question ?? throw new ArgumentNullException(nameof(question));
			this.Options = options ?? throw new ArgumentNullException(nameof(options));
		}

		///<summary>Poll question, 1-300 characters.</summary>
		[JsonPropertyName(PropertyNames.Question)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Question { get; }
		///<summary>List of answer options, 2-10 strings 1-100 characters each.</summary>
		[JsonPropertyName(PropertyNames.Options)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<string> Options { get; }
		///<summary>Optional. True, if the poll needs to be anonymous, defaults to True.</summary>
		[JsonPropertyName(PropertyNames.IsAnonymous)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
		public bool? IsAnonymous { get; set; } = true;
		///<summary>Optional. Poll type, “quiz” or “regular”, defaults to “regular”.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Type { get; set; }
		///<summary>Optional. True, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to False.</summary>
		[JsonPropertyName(PropertyNames.AllowsMultipleAnswers)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? AllowsMultipleAnswers { get; set; }
		///<summary>Optional. 0-based identifier of the correct answer option, required for polls in quiz mode.</summary>
		[JsonPropertyName(PropertyNames.CorrectOptionId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? CorrectOptionId { get; set; }
		///<summary>Optional. Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing.</summary>
		[JsonPropertyName(PropertyNames.Explanation)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Explanation { get; set; }
		///<summary>Optional. Mode for parsing entities in the explanation. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</summary>
		[JsonPropertyName(PropertyNames.ExplanationParseMode)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ExplanationParseMode { get; set; }
		///<summary>Optional. List of special entities that appear in the poll explanation, which can be specified instead of parse_mode.</summary>
		[JsonPropertyName(PropertyNames.ExplanationEntities)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<MessageEntity>? ExplanationEntities { get; set; }
		///<summary>Optional. Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with close_date.</summary>
		[JsonPropertyName(PropertyNames.OpenPeriod)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ushort? OpenPeriod { get; set; }
		///<summary>Optional. Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with open_period.</summary>
		[JsonPropertyName(PropertyNames.CloseDate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? CloseDate { get; set; }
		///<summary>Optional. Pass True, if the poll needs to be immediately closed.</summary>
		[JsonPropertyName(PropertyNames.IsClosed)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? IsClosed { get; set; }
	}
	/// <summary>Poll type, “quiz” or “regular”, defaults to “regular”</summary>
	public static class PollType
	{
		/// <summary>Quiz poll</summary>
		public const string Quiz = "quiz";
		/// <summary>Regular poll</summary>
		public const string Regular = "regular";
	}
}
