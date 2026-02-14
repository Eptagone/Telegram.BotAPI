namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Represents the options for appending a button to a keyboard.
/// </summary>
/// <param name="IconCustomEmojiId">Optional. Unique identifier of the custom emoji shown before the text of the button. Can only be used by bots that purchased additional usernames on <a href="https://fragment.com/">Fragment</a> or in the messages directly sent by the bot to private, group and supergroup chats if the owner of the bot has a Telegram Premium subscription.</param>
/// <param name="Style">Optional. Style of the button. Must be one of “danger” (red), “success” (green) or “primary” (blue). If omitted, then an app-specific style is used.</param>
public record AppendButtonOptions(string? IconCustomEmojiId = null, string? Style = null)
{
    /// <summary>
    /// Optional. Unique identifier of the custom emoji shown before the text of the button. Can only be used by bots that purchased additional usernames on <a href="https://fragment.com/">Fragment</a> or in the messages directly sent by the bot to private, group and supergroup chats if the owner of the bot has a Telegram Premium subscription.
    /// </summary>
    public string? IconCustomEmojiId { get; } = IconCustomEmojiId;

    /// <summary>
    /// Optional. Style of the button. Must be one of “danger” (red), “success” (green) or “primary” (blue). If omitted, then an app-specific style is used.
    /// </summary>
    public string? Style { get; } = Style;
}
