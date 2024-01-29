// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an inline button that switches the current user to inline mode in a chosen chat, with an optional default inline query.
/// </summary>
public class SwitchInlineQueryChosenChat
{
    /// <summary>
    /// <em>Optional</em>. The default inline query to be inserted in the input field. If left empty, only the bot's username will be inserted
    /// </summary>
    [JsonPropertyName(PropertyNames.Query)]
    public string? Query { get; set; }

    /// <summary>
    /// <em>Optional</em>. True, if private chats with users can be chosen
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowUserChats)]
    public bool? AllowUserChats { get; set; }

    /// <summary>
    /// <em>Optional</em>. True, if private chats with bots can be chosen
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowBotChats)]
    public bool? AllowBotChats { get; set; }

    /// <summary>
    /// <em>Optional</em>. True, if group and supergroup chats can be chosen
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowGroupChats)]
    public bool? AllowGroupChats { get; set; }

    /// <summary>
    /// <em>Optional</em>. True, if channel chats can be chosen
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowChannelChats)]
    public bool? AllowChannelChats { get; set; }
}
