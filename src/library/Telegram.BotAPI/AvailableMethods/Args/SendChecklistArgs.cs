// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SendChecklist" method.
/// </summary>
public class SendChecklistArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendChecklistArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot in the format <em>@username</em></param>
    /// <param name="checklist">A JSON-serialized object for the checklist to send</param>
    public SendChecklistArgs(string businessConnectionId, long chatId, InputChecklist checklist)
    {
        this.BusinessConnectionId =
            businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
        this.ChatId = chatId;
        this.Checklist = checklist ?? throw new ArgumentNullException(nameof(checklist));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendChecklistArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot in the format <em>@username</em></param>
    /// <param name="checklist">A JSON-serialized object for the checklist to send</param>
    public SendChecklistArgs(string businessConnectionId, string chatId, InputChecklist checklist)
    {
        this.BusinessConnectionId =
            businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Checklist = checklist ?? throw new ArgumentNullException(nameof(checklist));
    }

    /// <summary>
    /// Unique identifier of the business connection on behalf of which the message will be sent
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; }

    /// <summary>
    /// Unique identifier for the target chat or username of the target bot in the format <em>@username</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// A JSON-serialized object for the checklist to send
    /// </summary>
    [JsonPropertyName(PropertyNames.Checklist)]
    public InputChecklist Checklist { get; set; }

    /// <summary>
    /// Sends the message silently. Users will receive a notification with no sound.
    /// </summary>
    [JsonPropertyName(PropertyNames.DisableNotification)]
    public bool? DisableNotification { get; set; }

    /// <summary>
    /// Protects the contents of the sent message from forwarding and saving
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }

    /// <summary>
    /// Unique identifier of the message effect to be added to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageEffectId)]
    public string? MessageEffectId { get; set; }

    /// <summary>
    /// A JSON-serialized object for description of the message to reply to
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyParameters)]
    public ReplyParameters? ReplyParameters { get; set; }

    /// <summary>
    /// A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
