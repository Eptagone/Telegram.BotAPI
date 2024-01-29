// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "DeleteMyCommands" method.
/// </summary>
public class DeleteMyCommandsArgs
{
    /// <summary>
    /// A JSON-serialized object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Scope)]
    public BotCommandScope? Scope { get; set; }

    /// <summary>
    /// A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands
    /// </summary>
    [JsonPropertyName(PropertyNames.LanguageCode)]
    public string? LanguageCode { get; set; }
}
