using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Extensions.Commands;

/// <summary>
/// This attribute helps to define the scope to which the command is applied.
/// </summary>
/// <param name="scope">The scope to which the command is applied.</param>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class BotCommandScopeAttribute(BotCommandScope scope) : Attribute
{
    /// <summary>
    /// The scope to which the command is applied.
    /// </summary>
    public BotCommandScope Scope => scope;
}
