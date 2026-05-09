// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;
using InputPollMedia = Telegram.BotAPI.AvailableTypes.InputMedia;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SendPoll" method.
/// </summary>
public class SendPollArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendPollArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot, supergroup or channel in the format <em>@username</em>. Polls can't be sent to channel direct messages chats.</param>
    /// <param name="question">Poll question, 1-300 characters</param>
    /// <param name="options">A JSON-serialized list of 1-12 answer options</param>
    public SendPollArgs(long chatId, string question, IEnumerable<InputPollOption> options)
    {
        this.ChatId = chatId;
        this.Question = question ?? throw new ArgumentNullException(nameof(question));
        this.Options = options ?? throw new ArgumentNullException(nameof(options));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendPollArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot, supergroup or channel in the format <em>@username</em>. Polls can't be sent to channel direct messages chats.</param>
    /// <param name="question">Poll question, 1-300 characters</param>
    /// <param name="options">A JSON-serialized list of 1-12 answer options</param>
    public SendPollArgs(string chatId, string question, IEnumerable<InputPollOption> options)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Question = question ?? throw new ArgumentNullException(nameof(question));
        this.Options = options ?? throw new ArgumentNullException(nameof(options));
    }

    /// <summary>
    /// Unique identifier of the business connection on behalf of which the message will be sent
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string? BusinessConnectionId { get; set; }

    /// <summary>
    /// Unique identifier for the target chat or username of the target bot, supergroup or channel in the format <em>@username</em>. Polls can't be sent to channel direct messages chats.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Unique identifier for the target message thread (topic) of a forum; for forum supergroups and private chats of bots with forum topic mode enabled only
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageThreadId)]
    public int? MessageThreadId { get; set; }

    /// <summary>
    /// Poll question, 1-300 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Question)]
    public string Question { get; set; }

    /// <summary>
    /// Mode for parsing entities in the question. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Currently, only custom emoji entities are allowed
    /// </summary>
    [JsonPropertyName(PropertyNames.QuestionParseMode)]
    public string? QuestionParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in the poll question. It can be specified instead of <em>question_parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.QuestionEntities)]
    public IEnumerable<MessageEntity>? QuestionEntities { get; set; }

    /// <summary>
    /// A JSON-serialized list of 1-12 answer options
    /// </summary>
    [JsonPropertyName(PropertyNames.Options)]
    public IEnumerable<InputPollOption> Options { get; set; }

    /// <summary>
    /// <em>True</em>, if the poll needs to be anonymous, defaults to <em>True</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAnonymous)]
    public bool? IsAnonymous { get; set; }

    /// <summary>
    /// Poll type, “quiz” or “regular”, defaults to “regular”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public string? Type { get; set; }

    /// <summary>
    /// Pass <em>True</em>, if the poll allows multiple answers, defaults to <em>False</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowsMultipleAnswers)]
    public bool? AllowsMultipleAnswers { get; set; }

    /// <summary>
    /// Pass <em>True</em>, if the poll allows to change chosen answer options, defaults to <em>False</em> for quizzes and to <em>True</em> for regular polls
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowsRevoting)]
    public bool? AllowsRevoting { get; set; }

    /// <summary>
    /// Pass <em>True</em>, if the poll options must be shown in random order
    /// </summary>
    [JsonPropertyName(PropertyNames.ShuffleOptions)]
    public bool? ShuffleOptions { get; set; }

    /// <summary>
    /// Pass <em>True</em>, if answer options can be added to the poll after creation; not supported for anonymous polls and quizzes
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowAddingOptions)]
    public bool? AllowAddingOptions { get; set; }

    /// <summary>
    /// Pass <em>True</em>, if poll results must be shown only after the poll closes
    /// </summary>
    [JsonPropertyName(PropertyNames.HideResultsUntilCloses)]
    public bool? HideResultsUntilCloses { get; set; }

    /// <summary>
    /// Pass <em>True</em>, if voting is limited to users who have been members of the chat where the poll is being sent for more than 24 hours; for channel chats only
    /// </summary>
    [JsonPropertyName(PropertyNames.MembersOnly)]
    public bool? MembersOnly { get; set; }

    /// <summary>
    /// A JSON-serialized list of 0-12 two-letter <a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a> country codes indicating the countries from which users can vote in the poll; for channel chats only. If omitted or empty, then users from any country can participate in the poll.
    /// </summary>
    [JsonPropertyName(PropertyNames.CountryCodes)]
    public IEnumerable<string>? CountryCodes { get; set; }

    /// <summary>
    /// A JSON-serialized list of monotonically increasing 0-based identifiers of the correct answer options, required for polls in quiz mode
    /// </summary>
    [JsonPropertyName(PropertyNames.CorrectOptionIds)]
    public IEnumerable<int>? CorrectOptionIds { get; set; }

    /// <summary>
    /// Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Explanation)]
    public string? Explanation { get; set; }

    /// <summary>
    /// Mode for parsing entities in the explanation. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ExplanationParseMode)]
    public string? ExplanationParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in the poll explanation. It can be specified instead of <em>explanation_parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.ExplanationEntities)]
    public IEnumerable<MessageEntity>? ExplanationEntities { get; set; }

    /// <summary>
    /// Media added to the quiz explanation
    /// </summary>
    [JsonPropertyName(PropertyNames.ExplanationMedia)]
    public InputPollMedia? ExplanationMedia { get; set; }

    /// <summary>
    /// Amount of time in seconds the poll will be active after creation, 5-2628000. Can't be used together with <em>close_date</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.OpenPeriod)]
    public int? OpenPeriod { get; set; }

    /// <summary>
    /// Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 2628000 seconds in the future. Can't be used together with <em>open_period</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.CloseDate)]
    public int? CloseDate { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the poll needs to be immediately closed. This can be useful for poll preview.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsClosed)]
    public bool? IsClosed { get; set; }

    /// <summary>
    /// Description of the poll to be sent, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string? Description { get; set; }

    /// <summary>
    /// Mode for parsing entities in the poll description. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.DescriptionParseMode)]
    public string? DescriptionParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in the poll description, which can be specified instead of <em>description_parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.DescriptionEntities)]
    public IEnumerable<MessageEntity>? DescriptionEntities { get; set; }

    /// <summary>
    /// Media added to the poll description
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public InputPollMedia? Media { get; set; }

    /// <summary>
    /// Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.
    /// </summary>
    [JsonPropertyName(PropertyNames.DisableNotification)]
    public bool? DisableNotification { get; set; }

    /// <summary>
    /// Protects the contents of the sent message from forwarding and saving
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance.
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowPaidBroadcast)]
    public bool? AllowPaidBroadcast { get; set; }

    /// <summary>
    /// Unique identifier of the message effect to be added to the message; for private chats only
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageEffectId)]
    public string? MessageEffectId { get; set; }

    /// <summary>
    /// Description of the message to reply to
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyParameters)]
    public ReplyParameters? ReplyParameters { get; set; }

    /// <summary>
    /// Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public object? ReplyMarkup { get; set; }
}
