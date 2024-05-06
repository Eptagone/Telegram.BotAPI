// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object defines the criteria used to request a suitable chat. Information about the selected chat will be shared with the bot when the corresponding button is pressed. The bot will be granted requested rights in the chat if appropriate. <a href="https://core.telegram.org/bots/features#chat-and-user-selection">More about requesting chats »</a>.
/// </summary>
public class KeyboardButtonRequestChat
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KeyboardButtonRequestChat"/> class.
    /// </summary>
    /// <param name="requestId">Signed 32-bit identifier of the request, which will be received back in the <see cref="ChatShared"/> object. Must be unique within the message</param>
    /// <param name="chatIsChannel">Pass <em>True</em> to request a channel chat, pass <em>False</em> to request a group or a supergroup chat.</param>
    public KeyboardButtonRequestChat(int requestId, bool chatIsChannel)
    {
        this.RequestId = requestId;
        this.ChatIsChannel = chatIsChannel;
    }

    /// <summary>
    /// Signed 32-bit identifier of the request, which will be received back in the <see cref="ChatShared"/> object. Must be unique within the message
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestId)]
    public int RequestId { get; set; }

    /// <summary>
    /// Pass <em>True</em> to request a channel chat, pass <em>False</em> to request a group or a supergroup chat.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatIsChannel)]
    public bool ChatIsChannel { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request a forum supergroup, pass <em>False</em> to request a non-forum chat. If not specified, no additional restrictions are applied.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatIsForum)]
    public bool? ChatIsForum { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request a supergroup or a channel with a username, pass <em>False</em> to request a chat without a username. If not specified, no additional restrictions are applied.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatHasUsername)]
    public bool? ChatHasUsername { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request a chat owned by the user. Otherwise, no additional restrictions are applied.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatIsCreated)]
    public bool? ChatIsCreated { get; set; }

    /// <summary>
    /// Optional. A JSON-serialized object listing the required administrator rights of the user in the chat. The rights must be a superset of <em>bot_administrator_rights</em>. If not specified, no additional restrictions are applied.
    /// </summary>
    [JsonPropertyName(PropertyNames.UserAdministratorRights)]
    public ChatAdministratorRights? UserAdministratorRights { get; set; }

    /// <summary>
    /// Optional. A JSON-serialized object listing the required administrator rights of the bot in the chat. The rights must be a subset of <em>user_administrator_rights</em>. If not specified, no additional restrictions are applied.
    /// </summary>
    [JsonPropertyName(PropertyNames.BotAdministratorRights)]
    public ChatAdministratorRights? BotAdministratorRights { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request a chat with the bot as a member. Otherwise, no additional restrictions are applied.
    /// </summary>
    [JsonPropertyName(PropertyNames.BotIsMember)]
    public bool? BotIsMember { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request the chat's title
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestTitle)]
    public bool? RequestTitle { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request the chat's username
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestUsername)]
    public bool? RequestUsername { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request the chat's photo
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestPhoto)]
    public bool? RequestPhoto { get; set; }
}
