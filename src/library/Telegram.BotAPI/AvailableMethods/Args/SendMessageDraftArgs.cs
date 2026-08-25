// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SendMessageDraft" method.
/// </summary>
public class SendMessageDraftArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendMessageDraftArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target private chat</param>
    /// <param name="draftId">Unique identifier of the message draft; must be non-zero. Changes to drafts with the same identifier are animated. Otherwise, the draft is replaced without animation.</param>
    public SendMessageDraftArgs(long chatId, int draftId)
    {
        this.ChatId = chatId;
        this.DraftId = draftId;
    }

    /// <summary>
    /// Unique identifier for the target private chat
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public long ChatId { get; set; }

    /// <summary>
    /// Unique identifier for the target message thread
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageThreadId)]
    public int? MessageThreadId { get; set; }

    /// <summary>
    /// Unique identifier of the message draft; must be non-zero. Changes to drafts with the same identifier are animated. Otherwise, the draft is replaced without animation.
    /// </summary>
    [JsonPropertyName(PropertyNames.DraftId)]
    public int DraftId { get; set; }

    /// <summary>
    /// Text of the message to be sent, 0-4096 characters after entities parsing. Pass an empty text to show a “Thinking…” placeholder.
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string? Text { get; set; }

    /// <summary>
    /// Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Entities)]
    public IEnumerable<MessageEntity>? Entities { get; set; }

    /// <summary>
    /// Pass <em>True</em> to show the user a button to stop further drafts. The bot will receive an <see cref="Update"/> “stopped_message_generation” if the user presses the button.
    /// </summary>
    [JsonPropertyName(PropertyNames.CanStop)]
    public bool? CanStop { get; set; }

    /// <summary>
    /// Pass <em>True</em> to keep the draft in the chat when the button is pressed. The draft will still disappear after a short time or if the bot sends a message. To fully preserve the partial draft, the bot should send it as a new message.
    /// </summary>
    [JsonPropertyName(PropertyNames.KeepOnStop)]
    public bool? KeepOnStop { get; set; }
}
