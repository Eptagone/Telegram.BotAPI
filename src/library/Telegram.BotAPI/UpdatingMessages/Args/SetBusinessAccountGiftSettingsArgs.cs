// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "SetBusinessAccountGiftSettings" method.
/// </summary>
public class SetBusinessAccountGiftSettingsArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetBusinessAccountGiftSettingsArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="showGiftButton">Pass True, if a button for sending a gift to the user or by the business account must always be shown in the input field</param>
    /// <param name="acceptedGiftTypes">Types of gifts accepted by the business account</param>
    public SetBusinessAccountGiftSettingsArgs(string businessConnectionId, bool showGiftButton, AcceptedGiftTypes acceptedGiftTypes)
    {
        this.BusinessConnectionId = businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
        this.ShowGiftButton = showGiftButton;
        this.AcceptedGiftTypes = acceptedGiftTypes ?? throw new ArgumentNullException(nameof(acceptedGiftTypes));
    }

    /// <summary>
    /// Unique identifier of the business connection
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; }

    /// <summary>
    /// Pass True, if a button for sending a gift to the user or by the business account must always be shown in the input field
    /// </summary>
    [JsonPropertyName(PropertyNames.ShowGiftButton)]
    public bool ShowGiftButton { get; set; }

    /// <summary>
    /// Types of gifts accepted by the business account
    /// </summary>
    [JsonPropertyName(PropertyNames.AcceptedGiftTypes)]
    public AcceptedGiftTypes AcceptedGiftTypes { get; set; }
}
