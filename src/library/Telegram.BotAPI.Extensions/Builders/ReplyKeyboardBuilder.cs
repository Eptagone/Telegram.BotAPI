// Copyright (c) 2025 Quetzal Rivera.
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
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendText(string text, AppendButtonOptions? options = null) =>
        this.Append(new(text), options);

    /// <summary>
    /// Appends a new request users button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="requestUsers">The criteria used to request a suitable user.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestUsers(
        string text,
        KeyboardButtonRequestUsers requestUsers,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { RequestUsers = requestUsers }, options);

    /// <summary>
    /// Appends a new request users button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="requestId">Signed 32-bit identifier of the request that will be received back in the <see cref="UsersShared"/> object. Must be unique within the message</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestUsers(
        string text,
        int requestId,
        AppendButtonOptions? options = null
    ) => this.AppendRequestUsers(text, new KeyboardButtonRequestUsers(requestId), options);

    /// <summary>
    /// Appends a new request chat button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="requestChat">The criteria used to request a suitable chat.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestChat(
        string text,
        KeyboardButtonRequestChat requestChat,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { RequestChat = requestChat }, options);

    /// <summary>
    /// Appends a new request chat button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="requestId">Signed 32-bit identifier of the request that will be received back in the <see cref="ChatShared"/> object. Must be unique within the message</param>
    /// <param name="chatIsChannel">True if the chat is a channel, false otherwise.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestChat(
        string text,
        int requestId,
        bool chatIsChannel,
        AppendButtonOptions? options = null
    ) =>
        this.AppendRequestChat(
            text,
            new KeyboardButtonRequestChat(requestId, chatIsChannel),
            options
        );

    /// <summary>
    /// Appends a new request contact button to the keyboard.
    /// The button will request the user's contact information when pressed.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestContact(
        string text,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { RequestContact = true }, options);

    /// <summary>
    /// Appends a new request location button to the keyboard.
    /// The button will request the user's location when pressed.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestLocation(
        string text,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { RequestLocation = true }, options);

    /// <summary>
    /// Appends a new request poll button to the keyboard.
    /// The button will request the user to create a poll when pressed.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="pollType">The type of poll to be created.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    /// <remarks>
    public ReplyKeyboardBuilder AppendRequestPoll(
        string text,
        KeyboardButtonPollType? pollType = null,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { RequestPoll = pollType ?? new() }, options);

    /// <summary>
    /// Appends a new request poll button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="pollType">The type of poll to be created.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendRequestPoll(
        string text,
        string pollType,
        AppendButtonOptions? options = null
    ) => this.AppendRequestPoll(text, new KeyboardButtonPollType { Type = pollType }, options);

    /// <summary>
    /// Appends a new web app button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="webApp">The web app to be launched when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendWebApp(
        string text,
        WebAppInfo webApp,
        AppendButtonOptions? options = null
    ) => this.Append(new(text) { WebApp = webApp }, options);

    /// <summary>
    /// Appends a new web app button to the keyboard.
    /// </summary>
    /// <param name="text">The text of the button.</param>
    /// <param name="url">The URL of the web app to be launched when the button is pressed.</param>
    /// <param name="options">Additional options for the button.</param>
    /// <returns>The current instance of <see cref="ReplyKeyboardBuilder"/>.</returns>
    public ReplyKeyboardBuilder AppendWebApp(
        string text,
        string url,
        AppendButtonOptions? options = null
    ) => this.AppendWebApp(text, new WebAppInfo(url), options);

    private ReplyKeyboardBuilder Append(KeyboardButton button, AppendButtonOptions? options)
    {
        button.IconCustomEmojiId = options?.IconCustomEmojiId;
        button.Style = options?.Style;
        return this.Append(button);
    }

    public static implicit operator KeyboardButton[][](ReplyKeyboardBuilder? builder) =>
        [.. builder.Select(i => i.ToArray())];

    public static implicit operator ReplyKeyboardBuilder(KeyboardButton[][]? keyboard) =>
        new(keyboard);
}
