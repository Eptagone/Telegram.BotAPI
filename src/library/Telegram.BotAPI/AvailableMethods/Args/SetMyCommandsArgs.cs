// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SetMyCommands" method.
/// </summary>
public class SetMyCommandsArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetMyCommandsArgs"/> class.
    /// </summary>
    /// <param name="commands">A JSON-serialized list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
    public SetMyCommandsArgs(IEnumerable<BotCommand> commands)
    {
        this.Commands = commands ?? throw new ArgumentNullException(nameof(commands));
    }

    /// <summary>
    /// A JSON-serialized list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.
    /// </summary>
    [JsonPropertyName(PropertyNames.Commands)]
    public IEnumerable<BotCommand> Commands { get; set; }

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
