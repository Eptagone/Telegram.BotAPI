// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.RichMessages;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#inputmessagecontent">content</a> of a rich message to be sent as the result of an inline query.
/// </summary>
public class InputRichMessageContent : InputMessageContent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputRichMessageContent"/> class.
    /// </summary>
    /// <param name="richMessage">The message to be sent. Only previously uploaded files may be used in the message.</param>
    public InputRichMessageContent(InputRichMessage richMessage)
    {
        this.RichMessage = richMessage ?? throw new ArgumentNullException(nameof(richMessage));
    }

    /// <summary>
    /// The message to be sent. Only previously uploaded files may be used in the message.
    /// </summary>
    [JsonPropertyName(PropertyNames.RichMessage)]
    public InputRichMessage RichMessage { get; set; }
}
