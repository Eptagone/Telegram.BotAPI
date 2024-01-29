// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The message was originally sent by a known user.
/// </summary>
public class MessageOriginUser : MessageOrigin
{
    /// <summary>
    /// Type of the message origin, always “user”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "user";

    /// <summary>
    /// User that sent the message originally
    /// </summary>
    [JsonPropertyName(PropertyNames.SenderUser)]
    public User SenderUser { get; set; } = null!;
}
