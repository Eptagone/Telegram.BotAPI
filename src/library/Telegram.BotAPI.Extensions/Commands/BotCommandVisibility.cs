namespace Telegram.BotAPI.Extensions.Commands;

/// <summary>
/// Defines the visibility of a Telegram bot command.
/// </summary>
[Flags]
public enum BotCommandVisibility
{
    /// <summary>
    /// Unspecified.
    /// </summary>
    Unspecified = 0,

    /// <summary>
    /// All users can see the command.
    /// </summary>
    Default = 1,

    /// <summary>
    /// Hide the command from the menu.
    /// </summary>
    Hidden = 2,

    /// <summary>
    /// All users can see the command but only in private chats.
    /// </summary>
    PrivateChats = 3,

    /// <summary>
    /// The command is visible for group members only.
    /// </summary>
    Members = 4,

    /// <summary>
    /// The command is available for administrators only in groups and supergroups.
    /// </summary>
    Administrators = 5,
}
