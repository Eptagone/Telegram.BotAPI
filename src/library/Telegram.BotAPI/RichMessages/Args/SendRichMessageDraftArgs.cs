// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Represents the arguments of the "SendRichMessageDraft" method.
/// </summary>
public class SendRichMessageDraftArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendRichMessageDraftArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target private chat</param>
    /// <param name="draftId">Unique identifier of the message draft; must be non-zero. Changes to drafts with the same identifier are animated.</param>
    /// <param name="richMessage">The partial message to be streamed. Direct upload of new files isn't supported.</param>
    public SendRichMessageDraftArgs(long chatId, int draftId, InputRichMessage richMessage)
    {
        this.ChatId = chatId;
        this.DraftId = draftId;
        this.RichMessage = richMessage ?? throw new ArgumentNullException(nameof(richMessage));
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
    /// Unique identifier of the message draft; must be non-zero. Changes to drafts with the same identifier are animated.
    /// </summary>
    [JsonPropertyName(PropertyNames.DraftId)]
    public int DraftId { get; set; }

    /// <summary>
    /// The partial message to be streamed. Direct upload of new files isn't supported.
    /// </summary>
    [JsonPropertyName(PropertyNames.RichMessage)]
    public InputRichMessage RichMessage { get; set; }
}
