// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Represents a base class to create a Telegram Bot.
/// </summary>
/// <remarks>
/// If you want to manage a context object for each update, use <see cref="ComplexTelegramBotBase{TBotContext}"/> instead.
/// </remarks>
public abstract class SimpleTelegramBotBase : TelegramBotSharedMethodsBase, ITelegramBot
{
    #region Handlers
    /// <inheritdoc/>
    public virtual void OnUpdate(Update update)
    {
        try
        {
            if (update.Message != null)
            {
                this.OnMessage(update.Message);
            }
            else if (update.EditedMessage != null)
            {
                this.OnEditedMessage(update.EditedMessage);
            }
            else if (update.ChannelPost != null)
            {
                this.OnChannelPost(update.ChannelPost);
            }
            else if (update.EditedChannelPost != null)
            {
                this.OnEditedChannelPost(update.EditedChannelPost);
            }
            else if (update.BusinessConnection != null)
            {
                this.OnBusinessConnection(update.BusinessConnection);
            }
            else if (update.BusinessMessage != null)
            {
                this.OnBusinessMessage(update.BusinessMessage);
            }
            else if (update.EditedBusinessMessage != null)
            {
                this.OnEditedBusinessMessage(update.EditedBusinessMessage);
            }
            else if (update.DeletedBusinessMessages != null)
            {
                this.OnDeletedBusinessMessages(update.DeletedBusinessMessages);
            }
            else if (update.MessageReaction != null)
            {
                this.OnMessageReaction(update.MessageReaction);
            }
            else if (update.MessageReactionCount != null)
            {
                this.OnMessageReactionCount(update.MessageReactionCount);
            }
            else if (update.InlineQuery != null)
            {
                this.OnInlineQuery(update.InlineQuery);
            }
            else if (update.ChosenInlineResult != null)
            {
                this.OnChosenInlineResult(update.ChosenInlineResult);
            }
            else if (update.CallbackQuery != null)
            {
                this.OnCallbackQuery(update.CallbackQuery);
            }
            else if (update.ShippingQuery != null)
            {
                this.OnShippingQuery(update.ShippingQuery);
            }
            else if (update.PreCheckoutQuery != null)
            {
                this.OnPreCheckoutQuery(update.PreCheckoutQuery);
            }
            else if (update.Poll != null)
            {
                this.OnPoll(update.Poll);
            }
            else if (update.PollAnswer != null)
            {
                this.OnPollAnswer(update.PollAnswer);
            }
            else if (update.MyChatMember != null)
            {
                this.OnMyChatMember(update.MyChatMember);
            }
            else if (update.ChatMember != null)
            {
                this.OnChatMember(update.ChatMember);
            }
            else if (update.ChatJoinRequest != null)
            {
                this.OnChatJoinRequest(update.ChatJoinRequest);
            }
            else if (update.ChatBoost != null)
            {
                this.OnChatBoost(update.ChatBoost);
            }
            else if (update.RemovedChatBoost != null)
            {
                this.OnRemovedChatBoost(update.RemovedChatBoost);
            }
        }
        catch (BotRequestException exp)
        {
            this.OnBotException(exp);
        }
        catch (Exception exp)
        {
            this.OnException(exp);
        }
    }

    /// <inheritdoc/>
    public virtual async Task OnUpdateAsync(
        Update update,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            if (update.Message != null)
            {
                await this.OnMessageAsync(update.Message, cancellationToken).ConfigureAwait(false);
            }
            else if (update.EditedMessage != null)
            {
                await this.OnEditedMessageAsync(update.EditedMessage, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ChannelPost != null)
            {
                await this.OnChannelPostAsync(update.ChannelPost, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.EditedChannelPost != null)
            {
                await this.OnEditedChannelPostAsync(update.EditedChannelPost, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.BusinessConnection != null)
            {
                await this.OnBusinessConnectionAsync(update.BusinessConnection, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.BusinessMessage != null)
            {
                await this.OnBusinessMessageAsync(update.BusinessMessage, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.EditedBusinessMessage != null)
            {
                await this.OnEditedBusinessMessageAsync(
                        update.EditedBusinessMessage,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.DeletedBusinessMessages != null)
            {
                await this.OnDeletedBusinessMessagesAsync(
                        update.DeletedBusinessMessages,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.MessageReaction != null)
            {
                await this.OnMessageReactionAsync(update.MessageReaction, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.MessageReactionCount != null)
            {
                await this.OnMessageReactionCountAsync(
                        update.MessageReactionCount,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.InlineQuery != null)
            {
                await this.OnInlineQueryAsync(update.InlineQuery, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ChosenInlineResult != null)
            {
                await this.OnChosenInlineResultAsync(update.ChosenInlineResult, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.CallbackQuery != null)
            {
                await this.OnCallbackQueryAsync(update.CallbackQuery, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ShippingQuery != null)
            {
                await this.OnShippingQueryAsync(update.ShippingQuery, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.PreCheckoutQuery != null)
            {
                await this.OnPreCheckoutQueryAsync(update.PreCheckoutQuery, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.Poll != null)
            {
                await this.OnPollAsync(update.Poll, cancellationToken).ConfigureAwait(false);
            }
            else if (update.PollAnswer != null)
            {
                await this.OnPollAnswerAsync(update.PollAnswer, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.MyChatMember != null)
            {
                await this.OnMyChatMemberAsync(update.MyChatMember, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ChatMember != null)
            {
                await this.OnChatMemberAsync(update.ChatMember, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ChatJoinRequest != null)
            {
                await this.OnChatJoinRequestAsync(update.ChatJoinRequest, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ChatBoost != null)
            {
                await this.OnChatBoostAsync(update.ChatBoost, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.RemovedChatBoost != null)
            {
                await this.OnRemovedChatBoostAsync(update.RemovedChatBoost, cancellationToken)
                    .ConfigureAwait(false);
            }
        }
        catch (BotRequestException exp)
        {
            await this.OnBotExceptionAsync(exp, cancellationToken).ConfigureAwait(false);
        }
        catch (Exception exp)
        {
            await this.OnExceptionAsync(exp, cancellationToken).ConfigureAwait(false);
        }
    }

    /// <summary>
    /// Handles a message update.
    /// </summary>
    /// <param name="message">Message.</param>
    protected virtual void OnMessage(Message message)
    {
        if (this.CommandExtractor is null)
        {
            if (
                message.Entities?.Any(e => e.Type == "bot_command")
                ?? message.CaptionEntities?.Any(e => e.Type == "bot_command")
                ?? false
            )
            {
                var textParts = (message.Text ?? message.Caption)!.Split(
                    [' '],
                    StringSplitOptions.RemoveEmptyEntries
                );
                var commandName = textParts.First().TrimStart('/').Split('@').First();
                var args = string.Join(" ", textParts.Skip(1));
                this.OnCommand(message, commandName, args);
            }
        }
        else
        {
            if (this.CommandExtractor.HasCommand(message))
            {
                var (commandName, args) = this.CommandExtractor.ExtractCommand(message);
                this.OnCommand(message, commandName, args);
            }
        }
    }

    /// <summary>
    /// Handles a message update.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    protected virtual Task OnMessageAsync(
        Message message,
        CancellationToken cancellationToken = default
    )
    {
        if (this.CommandExtractor is null)
        {
            if (
                message.Entities?.Any(e => e.Type == "bot_command")
                ?? message.CaptionEntities?.Any(e => e.Type == "bot_command")
                ?? false
            )
            {
                var textParts = (message.Text ?? message.Caption)!.Split(
                    [' '],
                    StringSplitOptions.RemoveEmptyEntries
                );
                var commandName = textParts.First().TrimStart('/').Split('@').First();
                var args = string.Join(" ", textParts.Skip(1));
                return this.OnCommandAsync(message, commandName, args, cancellationToken);
            }
        }
        else
        {
            if (this.CommandExtractor.HasCommand(message))
            {
                var (commandName, args) = this.CommandExtractor.ExtractCommand(message);
                return this.OnCommandAsync(message, commandName, args, cancellationToken);
            }
        }

        return Task.CompletedTask;
    }

    /// <summary>
    /// Handles an edited message update.
    /// </summary>
    /// <param name="message">The edited message.</param>
    protected virtual void OnEditedMessage(Message message) =>
        this.OnEditedMessageAsync(message).Wait();

    /// <summary>
    /// Handles an edited message update.
    /// </summary>
    /// <param name="message">The edited message.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnEditedMessageAsync(
        Message message,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a channel post update.
    /// </summary>
    /// <param name="message">The channel post.</param>
    protected virtual void OnChannelPost(Message message) =>
        this.OnChannelPostAsync(message).Wait();

    /// <summary>
    /// Handles a channel post update.
    /// </summary>
    /// <param name="message">The channel post.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChannelPostAsync(
        Message message,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an edited channel post update.
    /// </summary>
    /// <param name="message">The edited channel post.</param>
    protected virtual void OnEditedChannelPost(Message message) =>
        this.OnEditedChannelPostAsync(message).Wait();

    /// <summary>
    /// Handles an edited channel post update.
    /// </summary>
    /// <param name="message">The edited channel post.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnEditedChannelPostAsync(
        Message message,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a business connection update.
    /// </summary>
    /// <param name="businessConnection">The business connection.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnBusinessConnectionAsync(
        BusinessConnection businessConnection,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a business connection update.
    /// </summary>
    /// <param name="businessConnection">The business connection.</param>
    protected virtual void OnBusinessConnection(BusinessConnection businessConnection) =>
        this.OnBusinessConnectionAsync(businessConnection).Wait();

    /// <summary>
    /// Handles a business message update.
    /// </summary>
    /// <param name="businessMessage">The business message.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnBusinessMessageAsync(
        Message businessMessage,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a business message update.
    /// </summary>
    /// <param name="businessMessage">The business message.</param>
    protected virtual void OnBusinessMessage(Message businessMessage) =>
        this.OnBusinessMessageAsync(businessMessage).Wait();

    /// <summary>
    /// Handles an edited business message update.
    /// </summary>
    /// <param name="editedBusinessMessage">The edited business message.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnEditedBusinessMessageAsync(
        Message editedBusinessMessage,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an edited business message update.
    /// </summary>
    /// <param name="editedBusinessMessage">The edited business message.</param>
    protected virtual void OnEditedBusinessMessage(Message editedBusinessMessage) =>
        this.OnEditedBusinessMessageAsync(editedBusinessMessage).Wait();

    /// <summary>
    /// Handles a deleted business messages update.
    /// </summary>
    /// <param name="deletedBusinessMessages">The deleted business messages.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnDeletedBusinessMessagesAsync(
        BusinessMessagesDeleted deletedBusinessMessages,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a deleted business messages update.
    /// </summary>
    /// <param name="deletedBusinessMessages">The deleted business messages.</param>
    protected virtual void OnDeletedBusinessMessages(
        BusinessMessagesDeleted deletedBusinessMessages
    ) => this.OnDeletedBusinessMessagesAsync(deletedBusinessMessages).Wait();

    /// <summary>
    /// Handles a message reaction update.
    /// </summary>
    /// <param name="messageReaction">The message reaction.</param>
    protected virtual void OnMessageReaction(MessageReactionUpdated messageReaction) =>
        this.OnMessageReactionAsync(messageReaction).Wait();

    /// <summary>
    /// Handles a message reaction update.
    /// </summary>
    /// <param name="messageReaction">The message reaction.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnMessageReactionAsync(
        MessageReactionUpdated messageReaction,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a message reaction count update.
    /// </summary>
    /// <param name="messageReactionCount">The message reaction count.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual void OnMessageReactionCount(
        MessageReactionCountUpdated messageReactionCount
    ) => this.OnMessageReactionCountAsync(messageReactionCount).Wait();

    /// <summary>
    /// Handles a message reaction count update.
    /// </summary>
    /// <param name="messageReactionCount">The message reaction count.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnMessageReactionCountAsync(
        MessageReactionCountUpdated messageReactionCount,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an inline query update.
    /// </summary>
    /// <param name="inlineQuery">The inline query.</param>
    protected virtual void OnInlineQuery(InlineQuery inlineQuery) =>
        this.OnInlineQueryAsync(inlineQuery).Wait();

    /// <summary>
    /// Handles an inline query update.
    /// </summary>
    /// <param name="inlineQuery">The inline query.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnInlineQueryAsync(
        InlineQuery inlineQuery,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a chosen inline result update.
    /// </summary>
    /// <param name="chosenInlineResult">The chosen inline result.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual void OnChosenInlineResult(ChosenInlineResult chosenInlineResult) =>
        this.OnChosenInlineResultAsync(chosenInlineResult).Wait();

    /// <summary>
    /// Handles a chosen inline result update.
    /// </summary>
    /// <param name="chosenInlineResult">The chosen inline result.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChosenInlineResultAsync(
        ChosenInlineResult chosenInlineResult,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a callback query update.
    /// </summary>
    /// <param name="callbackQuery">The callback query.</param>
    protected virtual void OnCallbackQuery(CallbackQuery callbackQuery) =>
        this.OnCallbackQueryAsync(callbackQuery).Wait();

    /// <summary>
    /// Handles a callback query update.
    /// </summary>
    /// <param name="callbackQuery">The callback query.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnCallbackQueryAsync(
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a shipping query update.
    /// </summary>
    /// <param name="shippingQuery">The shipping query.</param>
    protected virtual void OnShippingQuery(ShippingQuery shippingQuery) =>
        this.OnShippingQueryAsync(shippingQuery).Wait();

    /// <summary>
    /// Handles a shipping query update.
    /// </summary>
    /// <param name="shippingQuery">The shipping query.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnShippingQueryAsync(
        ShippingQuery shippingQuery,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a pre-checkout query update.
    /// </summary>
    /// <param name="preCheckoutQuery">The pre-checkout query.</param>
    protected virtual void OnPreCheckoutQuery(PreCheckoutQuery preCheckoutQuery) =>
        this.OnPreCheckoutQueryAsync(preCheckoutQuery).Wait();

    /// <summary>
    /// Handles a pre-checkout query update.
    /// </summary>
    /// <param name="preCheckoutQuery">The pre-checkout query.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnPreCheckoutQueryAsync(
        PreCheckoutQuery preCheckoutQuery,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a poll update.
    /// </summary>
    /// <param name="poll">The poll.</param>
    protected virtual void OnPoll(Poll poll) => this.OnPollAsync(poll).Wait();

    /// <summary>
    /// Handles a poll update.
    /// </summary>
    /// <param name="poll">The poll.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnPollAsync(Poll poll, CancellationToken cancellationToken = default) =>
        Task.CompletedTask;

    /// <summary>
    /// Handles a poll answer update.
    /// </summary>
    /// <param name="pollAnswer">The poll answer.</param>
    protected virtual void OnPollAnswer(PollAnswer pollAnswer) =>
        this.OnPollAnswerAsync(pollAnswer).Wait();

    /// <summary>
    /// Handles a poll answer update.
    /// </summary>
    /// <param name="pollAnswer">The poll answer.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnPollAnswerAsync(
        PollAnswer pollAnswer,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a my chat member update.
    /// </summary>
    /// <param name="myChatMember">The my chat member.</param>
    protected virtual void OnMyChatMember(ChatMemberUpdated myChatMember) =>
        this.OnMyChatMemberAsync(myChatMember).Wait();

    /// <summary>
    /// Handles a my chat member update.
    /// </summary>
    /// <param name="myChatMember">The my chat member.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnMyChatMemberAsync(
        ChatMemberUpdated myChatMember,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a chat member update.
    /// </summary>
    /// <param name="chatMember">The chat member.</param>
    protected virtual void OnChatMember(ChatMemberUpdated chatMember) =>
        this.OnChatMemberAsync(chatMember).Wait();

    /// <summary>
    /// Handles a chat member update.
    /// </summary>
    /// <param name="chatMember">The chat member.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChatMemberAsync(
        ChatMemberUpdated chatMember,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a chat join request update.
    /// </summary>
    /// <param name="chatJoinRequest">The chat join request.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual void OnChatJoinRequest(ChatJoinRequest chatJoinRequest) =>
        this.OnChatJoinRequestAsync(chatJoinRequest).Wait();

    /// <summary>
    /// Handles a chat join request update.
    /// </summary>
    /// <param name="chatJoinRequest">The chat join request.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChatJoinRequestAsync(
        ChatJoinRequest chatJoinRequest,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a chat boost update.
    /// </summary>
    /// <param name="chatBoost">The chat boost.</param>
    protected virtual void OnChatBoost(ChatBoostUpdated chatBoost) =>
        this.OnChatBoostAsync(chatBoost).Wait();

    /// <summary>
    /// Handles a chat boost update.
    /// </summary>
    /// <param name="chatBoost">The chat boost.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChatBoostAsync(
        ChatBoostUpdated chatBoost,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a removed chat boost update.
    /// </summary>
    /// <param name="removedChatBoost">The removed chat boost.</param>
    protected virtual void OnRemovedChatBoost(ChatBoostRemoved removedChatBoost) =>
        this.OnRemovedChatBoostAsync(removedChatBoost).Wait();

    /// <summary>
    /// Handles a removed chat boost update.
    /// </summary>
    /// <param name="removedChatBoost">The removed chat boost.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnRemovedChatBoostAsync(
        ChatBoostRemoved removedChatBoost,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;
    #endregion

    #region Extra Handlers
    /// <summary>
    /// Handles an incoming command extracted from the current message update.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="commandName">Command name.</param>
    /// <param name="args">A string containing all the arguments of the command. It could be empty if the command has no arguments.</param>
    protected virtual void OnCommand(Message message, string commandName, string args) =>
        this.OnCommandAsync(message, commandName, args).Wait();

    /// <summary>
    /// Handles an incoming command extracted from the current message update.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="commandName">Command name.</param>
    /// <param name="args">A string containing all the arguments of the command. It could be empty if the command has no arguments.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    protected virtual Task OnCommandAsync(
        Message message,
        string commandName,
        string args,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an exception thrown by a bot request.
    /// </summary>
    /// <param name="exp">Bot exception</param>
    protected virtual void OnBotException(BotRequestException exp) =>
        this.OnBotExceptionAsync(exp).Wait();

    /// <summary>
    /// Handles an exception thrown by a bot request.
    /// </summary>
    /// <param name="exp">Bot exception</param>
    /// <param name="cancellationToken">Cancellation token</param>
    protected virtual Task OnBotExceptionAsync(
        BotRequestException exp,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an exception thrown by the application.
    /// </summary>
    /// <param name="exp">Exception</param>
    protected virtual void OnException(Exception exp) => this.OnExceptionAsync(exp).Wait();

    /// <summary>
    /// Handles an exception thrown by the application.
    /// </summary>
    /// <param name="exp">Exception</param>
    /// <param name="cancellationToken">Cancellation token</param>
    protected virtual Task OnExceptionAsync(
        Exception exp,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;
    #endregion
}
