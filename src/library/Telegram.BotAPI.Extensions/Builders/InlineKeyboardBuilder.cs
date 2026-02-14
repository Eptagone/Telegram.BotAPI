// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.Games;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Represents a mutable collection of inline keyboard buttons.
/// </summary>
public sealed class InlineKeyboardBuilder(
    IEnumerable<IEnumerable<InlineKeyboardButton>>? keyboard = null
) : KeyboardBuilderBase<InlineKeyboardBuilder, InlineKeyboardButton>(keyboard)
{
    /// <summary>
    /// Appends a new URL button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="url">The URL to open when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendUrl(
        string text,
        string url,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { Url = url }, options);

    /// <summary>
    /// Appends a new callback data button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="callbackData">The callback data to send when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendCallbackData(
        string text,
        string callbackData,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { CallbackData = callbackData }, options);

    /// <summary>
    /// Appends a new Web App button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="webApp">Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method answerWebAppQuery. Available only in private chats between a user and the bot.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendWebApp(
        string text,
        WebAppInfo webApp,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { WebApp = webApp }, options);

    /// <summary>
    /// Appends a new Web App button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="url">The URL to open when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendWebApp(
        string text,
        string url,
        AppendButtonOptions? options = null
    ) => this.AppendWebApp(text, new WebAppInfo(url), options);

    /// <summary>
    /// Appends a new login URL button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="loginUrl">The login URL to open when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendLoginUrl(
        string text,
        LoginUrl loginUrl,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { LoginUrl = loginUrl }, options);

    /// <summary>
    /// Appends a new login URL button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="url">The URL to open when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendLoginUrl(
        string text,
        string url,
        AppendButtonOptions? options = null
    ) => this.AppendLoginUrl(text, new LoginUrl(url), options);

    /// <summary>
    /// Appends a new switch inline query button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="switchInlineQuery">The query to send when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendSwitchInlineQuery(
        string text,
        string switchInlineQuery,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { SwitchInlineQuery = switchInlineQuery });

    /// <summary>
    /// Appends a new switch inline query current chat button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="switchInlineQueryCurrentChat">The query to send when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendSwitchInlineQueryCurrentChat(
        string text,
        string switchInlineQueryCurrentChat,
        AppendButtonOptions? options = null
    ) =>
        this.Append(
            new(text) { SwitchInlineQueryCurrentChat = switchInlineQueryCurrentChat },
            options
        );

    /// <summary>
    /// Appends a new <see cref="SwitchInlineQueryChosenChat" /> button to the keyboard.
    /// </summary>
    /// <remarks>
    /// Pressing the button will prompt the user to select one of their chats of the specified type, open that chat and insert the bot's username and the specified inline query in the input field.
    /// </remarks>
    /// <param name="text">The text of the button.</param>
    /// <param name="switchInlineQueryChosenChat">The query to send when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendSwitchInlineQueryChosenChat(
        string text,
        SwitchInlineQueryChosenChat switchInlineQueryChosenChat,
        AppendButtonOptions? options = null
    ) =>
        this.Append(
            new(text) { SwitchInlineQueryChosenChat = switchInlineQueryChosenChat },
            options
        );

    /// <summary>
    /// Appends a new <see cref="CopyTextButton" /> button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="button">The <see cref="CopyTextButton" /> instance with the text to be copied when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendCopyText(
        string text,
        CopyTextButton button,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { CopyText = button }, options);

    /// <summary>
    /// Appends a new <see cref="CallbackGame" /> button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendCallbackGame(
        string text,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { CallbackGame = new CallbackGame() }, options);

    /// <summary>
    /// Appends a new pay button to the keyboard.
    /// </summary>
    /// <remarks>
    /// <b>NOTE:</b> This type of button <b>must</b> always be the first button in the first row and can only be used in invoice messages.
    /// </remarks>
    /// <param name="text">The text of the button.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendPay(string text, AppendButtonOptions? options = null) =>
        this.Append(new(text) { Pay = true }, options);

    private InlineKeyboardBuilder Append(InlineKeyboardButton button, AppendButtonOptions? options)
    {
        button.IconCustomEmojiId = options?.IconCustomEmojiId;
        button.Style = options?.Style;
        return this.Append(button);
    }

    public static implicit operator InlineKeyboardButton[][](InlineKeyboardBuilder builder) =>
        [.. builder.Select(row => row.ToArray())];

    public static implicit operator InlineKeyboardBuilder(InlineKeyboardButton[][] keyboard) =>
        new(keyboard);
}
