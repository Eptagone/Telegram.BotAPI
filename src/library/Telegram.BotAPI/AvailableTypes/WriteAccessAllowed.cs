// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about a user allowing a bot to write messages after adding it to the attachment menu, launching a Web App from a link, or accepting an explicit request from a Web App sent by the method <a href="https://core.telegram.org/bots/webapps#initializing-mini-apps">requestWriteAccess</a>.
/// </summary>
public class WriteAccessAllowed
{
    /// <summary>
    /// Optional. True, if the access was granted after the user accepted an explicit request from a Web App sent by the method <a href="https://core.telegram.org/bots/webapps#initializing-mini-apps">requestWriteAccess</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.FromRequest)]
    public bool? FromRequest { get; set; }

    /// <summary>
    /// Optional. Name of the Web App, if the access was granted when the Web App was launched from a link
    /// </summary>
    [JsonPropertyName(PropertyNames.WebAppName)]
    public string? WebAppName { get; set; }

    /// <summary>
    /// Optional. True, if the access was granted when the bot was added to the attachment or side menu
    /// </summary>
    [JsonPropertyName(PropertyNames.FromAttachmentMenu)]
    public bool? FromAttachmentMenu { get; set; }
}
