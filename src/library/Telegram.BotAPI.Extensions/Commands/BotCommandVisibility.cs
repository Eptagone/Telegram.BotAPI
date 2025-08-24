namespace Telegram.BotAPI.Extensions.Commands;

/// <summary>
/// Defines the visibility of a Telegram bot command.
/// </summary>
public enum BotCommandVisibility
{
    /// <summary>
    /// All users can see the command.
    /// </summary>
    Default,

    /// <summary>
    /// Hide the command from the menu.
    /// </summary>
    Hidden,

    /// <summary>
    /// All users can see the command but only in private chats.
    /// </summary>
    PrivateChats,

    /// <summary>
    /// The command is visible for group members only.
    /// </summary>
    Members,

    /// <summary>
    /// The command is available for administrators only in groups and supergroups.
    /// </summary>
    Administrators,
}
