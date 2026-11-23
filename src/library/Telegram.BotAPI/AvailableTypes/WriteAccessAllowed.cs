// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about a user allowing a bot to write messages after adding it to the attachment menu, launching a Web App from a link, or accepting an explicit request from a Web App sent by the method <a href="https://core.telegram.org/bots/webapps#initializing-mini-apps">requestWriteAccess</a>, or about a user being invited to the private chat with the bot by the owner of the bot.
/// </summary>
public class WriteAccessAllowed
{
    /// <summary>
    /// Optional. <em>True</em>, if the access was granted after the user accepted an explicit request from a Web App sent by the method <a href="https://core.telegram.org/bots/webapps#initializing-mini-apps">requestWriteAccess</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.FromRequest)]
    public bool? FromRequest { get; set; }

    /// <summary>
    /// Optional. Name of the Web App, if the access was granted when the Web App was launched from a link
    /// </summary>
    [JsonPropertyName(PropertyNames.WebAppName)]
    public string? WebAppName { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the access was granted when the bot was added to the attachment or side menu
    /// </summary>
    [JsonPropertyName(PropertyNames.FromAttachmentMenu)]
    public bool? FromAttachmentMenu { get; set; }

    /// <summary>
    /// Optional. The owner of the bot, if the access was granted when the owner invited the user to the private chat with the bot. Bot owners can invite up to 10 users at once by pressing the link <em>https://t.me/botinvite/&lt;bot_username&gt;</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Inviter)]
    public User? Inviter { get; set; }
}
