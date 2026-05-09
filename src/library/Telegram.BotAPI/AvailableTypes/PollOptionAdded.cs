// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about an option added to a poll.
/// </summary>
public class PollOptionAdded
{
    /// <summary>
    /// Optional. Message containing the poll to which the option was added, if known. Note that the <see cref="Message"/> object in this field will not contain the <em>reply_to_message</em> field even if it itself is a reply.
    /// </summary>
    [JsonPropertyName(PropertyNames.PollMessage)]
    public MaybeInaccessibleMessage? PollMessage { get; set; }

    /// <summary>
    /// Unique identifier of the added option
    /// </summary>
    [JsonPropertyName(PropertyNames.OptionPersistentId)]
    public string OptionPersistentId { get; set; } = null!;

    /// <summary>
    /// Option text
    /// </summary>
    [JsonPropertyName(PropertyNames.OptionText)]
    public string OptionText { get; set; } = null!;

    /// <summary>
    /// Optional. Special entities that appear in the <em>option_text</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.OptionTextEntities)]
    public IEnumerable<MessageEntity>? OptionTextEntities { get; set; }
}
