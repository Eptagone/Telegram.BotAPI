// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object defines the criteria used to request suitable users. Information about the selected users will be shared with the bot when the corresponding button is pressed. <a href="https://core.telegram.org/bots/features#chat-and-user-selection">More about requesting users »</a>
/// </summary>
public class KeyboardButtonRequestUsers
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KeyboardButtonRequestUsers"/> class.
    /// </summary>
    /// <param name="requestId">Signed 32-bit identifier of the request that will be received back in the <see cref="UsersShared"/> object. Must be unique within the message</param>
    public KeyboardButtonRequestUsers(int requestId)
    {
        this.RequestId = requestId;
    }

    /// <summary>
    /// Signed 32-bit identifier of the request that will be received back in the <see cref="UsersShared"/> object. Must be unique within the message
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestId)]
    public int RequestId { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request bots, pass <em>False</em> to request regular users. If not specified, no additional restrictions are applied.
    /// </summary>
    [JsonPropertyName(PropertyNames.UserIsBot)]
    public bool? UserIsBot { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request premium users, pass <em>False</em> to request non-premium users. If not specified, no additional restrictions are applied.
    /// </summary>
    [JsonPropertyName(PropertyNames.UserIsPremium)]
    public bool? UserIsPremium { get; set; }

    /// <summary>
    /// Optional. The maximum number of users to be selected; 1-10. Defaults to 1.
    /// </summary>
    [JsonPropertyName(PropertyNames.MaxQuantity)]
    public int? MaxQuantity { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request the users' first and last names
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestName)]
    public bool? RequestName { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request the users' usernames
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestUsername)]
    public bool? RequestUsername { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request the users' photos
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestPhoto)]
    public bool? RequestPhoto { get; set; }
}
