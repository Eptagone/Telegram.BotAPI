// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Represents a mutable collection of reply keyboard buttons.
/// </summary>
public sealed class ReplyKeyboardBuilder(IEnumerable<IEnumerable<KeyboardButton>>? keyboard = null)
    : KeyboardBuilderBase<ReplyKeyboardBuilder, KeyboardButton>(keyboard)
{
    /// <summary>
    /// Appends a new text button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendText(string text) => this.Append(new KeyboardButton(text));

    /// <summary>
    /// Appends a new request users button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="requestUsers">The criteria used to request a suitable user.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestUsers(
        string text,
        KeyboardButtonRequestUsers requestUsers
    ) => this.Append(new KeyboardButton(text) { RequestUsers = requestUsers });

    /// <summary>
    /// Appends a new request users button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="requestId">Signed 32-bit identifier of the request that will be received back in the <see cref="UsersShared"/> object. Must be unique within the message</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestUsers(string text, int requestId) =>
        this.AppendRequestUsers(text, new KeyboardButtonRequestUsers(requestId));

    /// <summary>
    /// Appends a new request chat button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="requestChat">The criteria used to request a suitable chat.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestChat(
        string text,
        KeyboardButtonRequestChat requestChat
    ) => this.Append(new KeyboardButton(text) { RequestChat = requestChat });

    /// <summary>
    /// Appends a new request chat button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="requestId">Signed 32-bit identifier of the request that will be received back in the <see cref="ChatShared"/> object. Must be unique within the message</param>
    /// <param name="chatIsChannel">True if the chat is a channel, false otherwise.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestChat(string text, int requestId, bool chatIsChannel) =>
        this.AppendRequestChat(text, new KeyboardButtonRequestChat(requestId, chatIsChannel));

    /// <summary>
    /// Appends a new request contact button to the keyboard.
    /// The button will request the user's contact information when pressed.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestContact(string text) =>
        this.Append(new KeyboardButton(text) { RequestContact = true });

    /// <summary>
    /// Appends a new request location button to the keyboard.
    /// The button will request the user's location when pressed.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestLocation(string text) =>
        this.Append(new KeyboardButton(text) { RequestLocation = true });

    /// <summary>
    /// Appends a new request poll button to the keyboard.
    /// The button will request the user to create a poll when pressed.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="pollType">The type of poll to be created.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    /// <remarks>
    public ReplyKeyboardBuilder AppendRequestPoll(
        string text,
        KeyboardButtonPollType? pollType = null
    ) => this.Append(new KeyboardButton(text) { RequestPoll = pollType ?? new() });

    /// <summary>
    /// Appends a new request poll button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="pollType">The type of poll to be created.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestPoll(string text, string pollType) =>
        this.AppendRequestPoll(text, new KeyboardButtonPollType { Type = pollType });

    /// <summary>
    /// Appends a new web app button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="webApp">The web app to be launched when the button is pressed.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendWebApp(string text, WebAppInfo webApp) =>
        this.Append(new KeyboardButton(text) { WebApp = webApp });

    /// <summary>
    /// Appends a new web app button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="url">The URL of the web app to be launched when the button is pressed.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendWebApp(string text, string url) =>
        this.AppendWebApp(text, new WebAppInfo(url));

    public static implicit operator KeyboardButton[][](ReplyKeyboardBuilder? builder) =>
        builder.Select(i => i.ToArray()).ToArray();

    public static implicit operator ReplyKeyboardBuilder(KeyboardButton[][]? keyboard) =>
        new(keyboard);
}
