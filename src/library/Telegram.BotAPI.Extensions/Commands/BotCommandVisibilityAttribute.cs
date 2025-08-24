namespace Telegram.BotAPI.Extensions.Commands;

/// <summary>
/// This attribute helps to specify who can see or use the command.
/// </summary>
/// <param name="visibility">The visibility.</param>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class BotCommandVisibilityAttribute(BotCommandVisibility visibility) : Attribute
{
    /// <summary>
    /// Specifies who can see or use the command.
    /// </summary>
    public BotCommandVisibility Visibility => visibility;
}
