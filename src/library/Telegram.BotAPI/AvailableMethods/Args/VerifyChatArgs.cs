// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "VerifyChat" method.
/// </summary>
public class VerifyChatArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VerifyChatArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot, supergroup, or channel in the format <em>@username</em>. Channel direct messages chats can't be verified.</param>
    public VerifyChatArgs(long chatId)
    {
        this.ChatId = chatId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VerifyChatArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target bot, supergroup, or channel in the format <em>@username</em>. Channel direct messages chats can't be verified.</param>
    public VerifyChatArgs(string chatId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target bot, supergroup, or channel in the format <em>@username</em>. Channel direct messages chats can't be verified.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Custom description for the verification; 0-70 characters. Must be empty if the organization isn't allowed to provide a custom verification description.
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomDescription)]
    public string? CustomDescription { get; set; }

    /// <summary>
    /// Mode for parsing entities in the custom description. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Only “text_link” entities are supported.
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomDescriptionParseMode)]
    public string? CustomDescriptionParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in the custom description, which can be specified instead of <em>custom_description_parse_mode</em>. Only “text_link” entities are supported.
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomDescriptionEntities)]
    public IEnumerable<MessageEntity>? CustomDescriptionEntities { get; set; }
}
