// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a message that was deleted or is otherwise inaccessible to the bot.
/// </summary>
public class InaccessibleMessage : MaybeInaccessibleMessage
{
    /// <summary>
    /// Chat the message belonged to
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public override Chat Chat { get; set; } = null!;

    /// <summary>
    /// Unique message identifier inside the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public override int MessageId { get; set; }

    /// <summary>
    /// Always 0. The field can be used to differentiate regular and inaccessible messages.
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public override int Date { get; set; }
}
