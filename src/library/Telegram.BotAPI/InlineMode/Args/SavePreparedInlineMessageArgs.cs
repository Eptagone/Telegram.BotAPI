// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the arguments of the "SavePreparedInlineMessage" method.
/// </summary>
public class SavePreparedInlineMessageArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SavePreparedInlineMessageArgs"/> class.
    /// </summary>
    /// <param name="userId">Unique identifier of the target user that can use the prepared message</param>
    /// <param name="result">A JSON-serialized object describing the message to be sent</param>
    public SavePreparedInlineMessageArgs(long userId, InlineQueryResult result)
    {
        this.UserId = userId;
        this.Result = result ?? throw new ArgumentNullException(nameof(result));
    }

    /// <summary>
    /// Unique identifier of the target user that can use the prepared message
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// A JSON-serialized object describing the message to be sent
    /// </summary>
    [JsonPropertyName(PropertyNames.Result)]
    public InlineQueryResult Result { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the message can be sent to private chats with users
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowUserChats)]
    public bool? AllowUserChats { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the message can be sent to private chats with bots
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowBotChats)]
    public bool? AllowBotChats { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the message can be sent to group and supergroup chats
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowGroupChats)]
    public bool? AllowGroupChats { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the message can be sent to channel chats
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowChannelChats)]
    public bool? AllowChannelChats { get; set; }
}
