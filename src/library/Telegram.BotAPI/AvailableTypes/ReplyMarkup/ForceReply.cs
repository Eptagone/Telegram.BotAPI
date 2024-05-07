// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Upon receiving a message with this object, Telegram clients will display a reply interface to the user (act as if the user has selected the bot's message and tapped 'Reply'). This can be extremely useful if you want to create user-friendly step-by-step interfaces without having to sacrifice <a href="https://core.telegram.org/bots/features#privacy-mode">privacy mode</a>. Not supported in channels and for messages sent on behalf of a Telegram Business account.
/// </summary>
public class ForceReply : ReplyMarkup
{
    /// <summary>
    /// Shows reply interface to the user, as if they manually selected the bot's message and tapped 'Reply'
    /// </summary>
    [JsonPropertyName(PropertyNames.ForceReply)]
    public bool ForceReplyFlag => true;

    /// <summary>
    /// Optional. The placeholder to be shown in the input field when the reply is active; 1-64 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.InputFieldPlaceholder)]
    public string? InputFieldPlaceholder { get; set; }

    /// <summary>
    /// Optional. Use this parameter if you want to force reply from specific users only. Targets: 1) users that are @mentioned in the <em>text</em> of the <see cref="Message"/> object; 2) if the bot's message is a reply to a message in the same chat and forum topic, sender of the original message.
    /// </summary>
    [JsonPropertyName(PropertyNames.Selective)]
    public bool? Selective { get; set; }
}
