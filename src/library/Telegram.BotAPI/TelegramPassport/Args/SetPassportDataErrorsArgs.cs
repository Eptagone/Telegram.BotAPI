// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Represents the arguments of the "SetPassportDataErrors" method.
/// </summary>
public class SetPassportDataErrorsArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetPassportDataErrorsArgs"/> class.
    /// </summary>
    /// <param name="userId">User identifier</param>
    /// <param name="errors">A JSON-serialized array describing the errors</param>
    public SetPassportDataErrorsArgs(long userId, IEnumerable<PassportElementError> errors)
    {
        this.UserId = userId;
        this.Errors = errors ?? throw new ArgumentNullException(nameof(errors));
    }

    /// <summary>
    /// User identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// A JSON-serialized array describing the errors
    /// </summary>
    [JsonPropertyName(PropertyNames.Errors)]
    public IEnumerable<PassportElementError> Errors { get; set; }
}
