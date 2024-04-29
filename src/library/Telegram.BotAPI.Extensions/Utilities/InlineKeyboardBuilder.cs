// Copyright (c) 2024 Quetzal Rivera.
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
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendUrl(string text, string url) =>
        this.Append(new InlineKeyboardButton(text) { Url = url });

    /// <summary>
    /// Appends a new callback data button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="callbackData">The callback data to send when the button is pressed.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendCallbackData(string text, string callbackData) =>
        this.Append(new InlineKeyboardButton(text) { CallbackData = callbackData });

    /// <summary>
    /// Appends a new Web App button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="webApp">Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method answerWebAppQuery. Available only in private chats between a user and the bot.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendWebApp(string text, WebAppInfo webApp) =>
        this.Append(new InlineKeyboardButton(text) { WebApp = webApp });

    /// <summary>
    /// Appends a new Web App button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="url">The URL to open when the button is pressed.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendWebApp(string text, string url) =>
        this.AppendWebApp(text, new WebAppInfo(url));

    /// <summary>
    /// Appends a new login URL button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="loginUrl">The login URL to open when the button is pressed.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendLoginUrl(string text, LoginUrl loginUrl) =>
        this.Append(new InlineKeyboardButton(text) { LoginUrl = loginUrl });

    /// <summary>
    /// Appends a new login URL button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="url">The URL to open when the button is pressed.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendLoginUrl(string text, string url) =>
        this.AppendLoginUrl(text, new LoginUrl(url));

    /// <summary>
    /// Appends a new switch inline query button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="switchInlineQuery">The query to send when the button is pressed.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendSwitchInlineQuery(string text, string switchInlineQuery) =>
        this.Append(new InlineKeyboardButton(text) { SwitchInlineQuery = switchInlineQuery });

    /// <summary>
    /// Appends a new switch inline query current chat button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="switchInlineQueryCurrentChat">The query to send when the button is pressed.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendSwitchInlineQueryCurrentChat(
        string text,
        string switchInlineQueryCurrentChat
    ) =>
        this.Append(
            new InlineKeyboardButton(text)
            {
                SwitchInlineQueryCurrentChat = switchInlineQueryCurrentChat
            }
        );

    /// <summary>
    /// Appends a new <see cref="SwitchInlineQueryChosenChat" /> button to the keyboard.
    /// </summary>
    /// <remarks>
    /// Pressing the button will prompt the user to select one of their chats of the specified type, open that chat and insert the bot's username and the specified inline query in the input field.
    /// </remarks>
    /// <param name="text">The text of the button.</param>
    /// <param name="switchInlineQueryChosenChat">The query to send when the button is pressed.</param>
    public InlineKeyboardBuilder AppendSwitchInlineQueryChosenChat(
        string text,
        SwitchInlineQueryChosenChat switchInlineQueryChosenChat
    ) =>
        this.Append(
            new InlineKeyboardButton(text)
            {
                SwitchInlineQueryChosenChat = switchInlineQueryChosenChat
            }
        );

    /// <summary>
    /// Appends a new <see cref="CallbackGame" /> button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendCallbackGame(string text) =>
        this.Append(new InlineKeyboardButton(text) { CallbackGame = new CallbackGame() });

    /// <summary>
    /// Appends a new pay button to the keyboard.
    /// </summary>
    /// <remarks>
    /// <b>NOTE:</b> This type of button <b>must</b> always be the first button in the first row and can only be used in invoice messages.
    /// </remarks>
    /// <param name="text">The text of the button.</param>
    /// <returns>The current instance of <see cref="InlineKeyboardBuilder"/>.</returns>
    public InlineKeyboardBuilder AppendPay(string text) =>
        this.Append(new InlineKeyboardButton(text) { Pay = true });

    public static implicit operator InlineKeyboardButton[][](InlineKeyboardBuilder builder) =>
        builder.Select(row => row.ToArray()).ToArray();

    public static implicit operator InlineKeyboardBuilder(InlineKeyboardButton[][] keyboard) =>
        new(keyboard);
}
