// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The message was originally sent by an unknown user.
/// </summary>
public class MessageOriginHiddenUser : MessageOrigin
{
    /// <summary>
    /// Type of the message origin, always “hidden_user”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "hidden_user";

    /// <summary>
    /// Name of the user that sent the message originally
    /// </summary>
    [JsonPropertyName(PropertyNames.SenderUserName)]
    public string SenderUserName { get; set; } = null!;
}
