// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "EditMessageChecklist" method.
/// </summary>
public class EditMessageChecklistArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditMessageChecklistArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="chatId">Unique identifier for the target chat</param>
    /// <param name="messageId">Unique identifier for the target message</param>
    /// <param name="checklist">A JSON-serialized object for the new checklist</param>
    public EditMessageChecklistArgs(string businessConnectionId, long chatId, int messageId, InputChecklist checklist)
    {
        this.BusinessConnectionId = businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
        this.ChatId = chatId;
        this.MessageId = messageId;
        this.Checklist = checklist ?? throw new ArgumentNullException(nameof(checklist));
    }

    /// <summary>
    /// Unique identifier of the business connection on behalf of which the message will be sent
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; }

    /// <summary>
    /// Unique identifier for the target chat
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public long ChatId { get; set; }

    /// <summary>
    /// Unique identifier for the target message
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int MessageId { get; set; }

    /// <summary>
    /// A JSON-serialized object for the new checklist
    /// </summary>
    [JsonPropertyName(PropertyNames.Checklist)]
    public InputChecklist Checklist { get; set; }

    /// <summary>
    /// A JSON-serialized object for the new inline keyboard for the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
