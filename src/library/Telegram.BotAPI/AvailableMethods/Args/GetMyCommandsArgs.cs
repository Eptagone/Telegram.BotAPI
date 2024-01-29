// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "GetMyCommands" method.
/// </summary>
public class GetMyCommandsArgs
{
    /// <summary>
    /// A JSON-serialized object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Scope)]
    public BotCommandScope? Scope { get; set; }

    /// <summary>
    /// A two-letter ISO 639-1 language code or an empty string
    /// </summary>
    [JsonPropertyName(PropertyNames.LanguageCode)]
    public string? LanguageCode { get; set; }
}
