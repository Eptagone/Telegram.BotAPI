// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Describes an inline message sent by a <a href="https://core.telegram.org/bots/webapps">Web App</a> on behalf of a user.
/// </summary>
public class SentWebAppMessage
{
    /// <summary>
    /// Optional. Identifier of the sent inline message. Available only if there is an <a href="https://core.telegram.org/bots/api#inlinekeyboardmarkup">inline keyboard</a> attached to the message.
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    public string? InlineMessageId { get; set; }
}
