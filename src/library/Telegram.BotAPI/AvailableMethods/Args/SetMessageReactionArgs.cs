// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SetMessageReaction" method.
/// </summary>
public class SetMessageReactionArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetMessageReactionArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Identifier of the target message. If the message belongs to a media group, the reaction is set to the first non-deleted message in the group instead.</param>
    public SetMessageReactionArgs(long chatId, int messageId)
    {
        this.ChatId = chatId;
        this.MessageId = messageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SetMessageReactionArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Identifier of the target message. If the message belongs to a media group, the reaction is set to the first non-deleted message in the group instead.</param>
    public SetMessageReactionArgs(string chatId, int messageId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.MessageId = messageId;
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Identifier of the target message. If the message belongs to a media group, the reaction is set to the first non-deleted message in the group instead.
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int MessageId { get; set; }

    /// <summary>
    /// A JSON-serialized list of reaction types to set on the message. Currently, as non-premium users, bots can set up to one reaction per message. A custom emoji reaction can be used if it is either already present on the message or explicitly allowed by chat administrators. Paid reactions can't be used by bots.
    /// </summary>
    [JsonPropertyName(PropertyNames.Reaction)]
    public IEnumerable<ReactionType>? Reaction { get; set; }

    /// <summary>
    /// Pass <em>True</em> to set the reaction with a big animation
    /// </summary>
    [JsonPropertyName(PropertyNames.IsBig)]
    public bool? IsBig { get; set; }
}
