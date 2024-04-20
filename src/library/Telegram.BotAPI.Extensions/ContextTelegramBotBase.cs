// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Represents a Telegram Bot.
/// </summary>
public abstract class ContextTelegramBotBase : ContextTelegramBotBase<IDictionary<string, object>>
{
    /// <summary>
    /// Creates a new context for the current update.
    /// </summary>
    /// <param name="update">The current update.</param>
    /// <returns>A new context instance.</returns>
    protected override IDictionary<string, object> CreateContext(Update update) =>
        this.CreateContextAsync(update).GetAwaiter().GetResult();

    /// <summary>
    /// Creates a new context for the current update.
    /// </summary>
    /// <param name="update">The current update.</param>
    /// <returns>A new context instance.</returns>
    protected override Task<IDictionary<string, object>> CreateContextAsync(Update update) =>
        Task.FromResult<IDictionary<string, object>>(new Dictionary<string, object>());
}

/// <summary>
/// Represents a Telegram Bot.
/// </summary>
/// <typeparam name="TBotContext">The type of the bot context.</typeparam>
public abstract class ContextTelegramBotBase<TBotContext>
    : TelegramBotSharedMethodsBase,
        ITelegramBot
    where TBotContext : class
{
    /// <summary>
    /// Creates a new context for the current update.
    /// </summary>
    /// <param name="update">The current update.</param>
    /// <returns>A new context instance.</returns>
    protected virtual TBotContext CreateContext(Update update) =>
        this.CreateContextAsync(update).GetAwaiter().GetResult();

    /// <summary>
    /// Creates a new context for the current update.
    /// </summary>
    /// <param name="update">The current update.</param>
    /// <returns>A new context instance.</returns>
    protected virtual Task<TBotContext> CreateContextAsync(Update update)
    {
        throw new NotImplementedException(
            "The method 'CreateContextAsync' must be implemented in a derived class. If you are not using asynchronous methods, you can override the 'CreateContext' method instead."
        );
    }

    #region Handlers
    /// <inheritdoc/>
    public virtual void OnUpdate(Update update)
    {
        TBotContext? context = null;
        try
        {
            context = this.CreateContext(update);
            if (update.Message != null)
            {
                this.OnMessage(context, update.Message);
            }
            else if (update.EditedMessage != null)
            {
                this.OnEditedMessage(context, update.EditedMessage);
            }
            else if (update.ChannelPost != null)
            {
                this.OnChannelPost(context, update.ChannelPost);
            }
            else if (update.EditedChannelPost != null)
            {
                this.OnEditedChannelPost(context, update.EditedChannelPost);
            }
            else if (update.BusinessConnection != null)
            {
                this.OnBusinessConnection(context, update.BusinessConnection);
            }
            else if (update.BusinessMessage != null)
            {
                this.OnBusinessMessage(context, update.BusinessMessage);
            }
            else if (update.EditedBusinessMessage != null)
            {
                this.OnEditedBusinessMessage(context, update.EditedBusinessMessage);
            }
            else if (update.DeletedBusinessMessages != null)
            {
                this.OnDeletedBusinessMessages(context, update.DeletedBusinessMessages);
            }
            else if (update.MessageReaction != null)
            {
                this.OnMessageReaction(context, update.MessageReaction);
            }
            else if (update.MessageReactionCount != null)
            {
                this.OnMessageReactionCount(context, update.MessageReactionCount);
            }
            else if (update.InlineQuery != null)
            {
                this.OnInlineQuery(context, update.InlineQuery);
            }
            else if (update.ChosenInlineResult != null)
            {
                this.OnChosenInlineResult(context, update.ChosenInlineResult);
            }
            else if (update.CallbackQuery != null)
            {
                this.OnCallbackQuery(context, update.CallbackQuery);
            }
            else if (update.ShippingQuery != null)
            {
                this.OnShippingQuery(context, update.ShippingQuery);
            }
            else if (update.PreCheckoutQuery != null)
            {
                this.OnPreCheckoutQuery(context, update.PreCheckoutQuery);
            }
            else if (update.Poll != null)
            {
                this.OnPoll(context, update.Poll);
            }
            else if (update.PollAnswer != null)
            {
                this.OnPollAnswer(context, update.PollAnswer);
            }
            else if (update.MyChatMember != null)
            {
                this.OnMyChatMember(context, update.MyChatMember);
            }
            else if (update.ChatMember != null)
            {
                this.OnChatMember(context, update.ChatMember);
            }
            else if (update.ChatJoinRequest != null)
            {
                this.OnChatJoinRequest(context, update.ChatJoinRequest);
            }
            else if (update.ChatBoost != null)
            {
                this.OnChatBoost(context, update.ChatBoost);
            }
            else if (update.RemovedChatBoost != null)
            {
                this.OnRemovedChatBoost(context, update.RemovedChatBoost);
            }
        }
        catch (BotRequestException exp)
        {
            this.OnBotException(context, exp);
        }
        catch (Exception exp)
        {
            this.OnException(context, exp);
        }
    }

    /// <inheritdoc/>
    public virtual async Task OnUpdateAsync(
        Update update,
        CancellationToken cancellationToken = default
    )
    {
        TBotContext? context = null;
        try
        {
            context = await this.CreateContextAsync(update).ConfigureAwait(false);
            if (update.Message != null)
            {
                await this.OnMessageAsync(context, update.Message, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.EditedMessage != null)
            {
                await this.OnEditedMessageAsync(context, update.EditedMessage, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ChannelPost != null)
            {
                await this.OnChannelPostAsync(context, update.ChannelPost, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.EditedChannelPost != null)
            {
                await this.OnEditedChannelPostAsync(
                        context,
                        update.EditedChannelPost,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.BusinessConnection != null)
            {
                await this.OnBusinessConnectionAsync(
                        context,
                        update.BusinessConnection,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.BusinessMessage != null)
            {
                await this.OnBusinessMessageAsync(
                        context,
                        update.BusinessMessage,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.EditedBusinessMessage != null)
            {
                await this.OnEditedBusinessMessageAsync(
                        context,
                        update.EditedBusinessMessage,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.DeletedBusinessMessages != null)
            {
                await this.OnDeletedBusinessMessagesAsync(
                        context,
                        update.DeletedBusinessMessages,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.MessageReaction != null)
            {
                await this.OnMessageReactionAsync(
                        context,
                        update.MessageReaction,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.MessageReactionCount != null)
            {
                await this.OnMessageReactionCountAsync(
                        context,
                        update.MessageReactionCount,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.InlineQuery != null)
            {
                await this.OnInlineQueryAsync(context, update.InlineQuery, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ChosenInlineResult != null)
            {
                await this.OnChosenInlineResultAsync(
                        context,
                        update.ChosenInlineResult,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.CallbackQuery != null)
            {
                await this.OnCallbackQueryAsync(context, update.CallbackQuery, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ShippingQuery != null)
            {
                await this.OnShippingQueryAsync(context, update.ShippingQuery, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.PreCheckoutQuery != null)
            {
                await this.OnPreCheckoutQueryAsync(
                        context,
                        update.PreCheckoutQuery,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.Poll != null)
            {
                await this.OnPollAsync(context, update.Poll, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.PollAnswer != null)
            {
                await this.OnPollAnswerAsync(context, update.PollAnswer, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.MyChatMember != null)
            {
                await this.OnMyChatMemberAsync(context, update.MyChatMember, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ChatMember != null)
            {
                await this.OnChatMemberAsync(context, update.ChatMember, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.ChatJoinRequest != null)
            {
                await this.OnChatJoinRequestAsync(
                        context,
                        update.ChatJoinRequest,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            else if (update.ChatBoost != null)
            {
                await this.OnChatBoostAsync(context, update.ChatBoost, cancellationToken)
                    .ConfigureAwait(false);
            }
            else if (update.RemovedChatBoost != null)
            {
                await this.OnRemovedChatBoostAsync(
                        context,
                        update.RemovedChatBoost,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
        }
        catch (BotRequestException exp)
        {
            await this.OnBotExceptionAsync(context, exp, cancellationToken).ConfigureAwait(false);
        }
        catch (Exception exp)
        {
            await this.OnExceptionAsync(context, exp, cancellationToken).ConfigureAwait(false);
        }
    }

    /// <summary>
    /// Handles a message update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="message">Message.</param>
    protected virtual void OnMessage(TBotContext context, Message message)
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
                this.OnCommand(context, message, commandName, args);
            }
        }
        else
        {
            if (this.CommandExtractor.HasCommand(message))
            {
                var (commandName, args) = this.CommandExtractor.ExtractCommand(message);
                this.OnCommand(context, message, commandName, args);
            }
        }
    }

    /// <summary>
    /// Handles a message update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="message">Message.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    protected virtual Task OnMessageAsync(
        TBotContext context,
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
                return this.OnCommandAsync(context, message, commandName, args, cancellationToken);
            }
        }
        else
        {
            if (this.CommandExtractor.HasCommand(message))
            {
                var (commandName, args) = this.CommandExtractor.ExtractCommand(message);
                return this.OnCommandAsync(context, message, commandName, args, cancellationToken);
            }
        }

        return Task.CompletedTask;
    }

    /// <summary>
    /// Handles an edited message update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="message">The edited message.</param>
    protected virtual void OnEditedMessage(TBotContext context, Message message) =>
        this.OnEditedMessageAsync(context, message).Wait();

    /// <summary>
    /// Handles an edited message update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="message">The edited message.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnEditedMessageAsync(
        TBotContext context,
        Message message,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a channel post update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="message">The channel post.</param>
    protected virtual void OnChannelPost(TBotContext context, Message message) =>
        this.OnChannelPostAsync(context, message).Wait();

    /// <summary>
    /// Handles a channel post update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="message">The channel post.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChannelPostAsync(
        TBotContext context,
        Message message,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an edited channel post update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="message">The edited channel post.</param>
    protected virtual void OnEditedChannelPost(TBotContext context, Message message) =>
        this.OnEditedChannelPostAsync(context, message).Wait();

    /// <summary>
    /// Handles an edited channel post update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="message">The edited channel post.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnEditedChannelPostAsync(
        TBotContext context,
        Message message,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a business connection update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="businessConnection">The business connection.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnBusinessConnectionAsync(
        TBotContext context,
        BusinessConnection businessConnection,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a business connection update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="businessConnection">The business connection.</param>
    protected virtual void OnBusinessConnection(
        TBotContext context,
        BusinessConnection businessConnection
    ) => this.OnBusinessConnectionAsync(context, businessConnection).Wait();

    /// <summary>
    /// Handles a business message update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="businessMessage">The business message.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnBusinessMessageAsync(
        TBotContext context,
        Message businessMessage,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a business message update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="businessMessage">The business message.</param>
    protected virtual void OnBusinessMessage(TBotContext context, Message businessMessage) =>
        this.OnBusinessMessageAsync(context, businessMessage).Wait();

    /// <summary>
    /// Handles an edited business message update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="editedBusinessMessage">The edited business message.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnEditedBusinessMessageAsync(
        TBotContext context,
        Message editedBusinessMessage,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an edited business message update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="editedBusinessMessage">The edited business message.</param>
    protected virtual void OnEditedBusinessMessage(
        TBotContext context,
        Message editedBusinessMessage
    ) => this.OnEditedBusinessMessageAsync(context, editedBusinessMessage).Wait();

    /// <summary>
    /// Handles a deleted business messages update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="deletedBusinessMessages">The deleted business messages.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnDeletedBusinessMessagesAsync(
        TBotContext context,
        BusinessMessagesDeleted deletedBusinessMessages,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a deleted business messages update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="deletedBusinessMessages">The deleted business messages.</param>
    protected virtual void OnDeletedBusinessMessages(
        TBotContext context,
        BusinessMessagesDeleted deletedBusinessMessages
    ) => this.OnDeletedBusinessMessagesAsync(context, deletedBusinessMessages).Wait();

    /// <summary>
    /// Handles a message reaction update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="messageReaction">The message reaction.</param>
    protected virtual void OnMessageReaction(
        TBotContext context,
        MessageReactionUpdated messageReaction
    ) => this.OnMessageReactionAsync(context, messageReaction).Wait();

    /// <summary>
    /// Handles a message reaction update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="messageReaction">The message reaction.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnMessageReactionAsync(
        TBotContext context,
        MessageReactionUpdated messageReaction,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a message reaction count update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="messageReactionCount">The message reaction count.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual void OnMessageReactionCount(
        TBotContext context,
        MessageReactionCountUpdated messageReactionCount
    ) => this.OnMessageReactionCountAsync(context, messageReactionCount).Wait();

    /// <summary>
    /// Handles a message reaction count update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="messageReactionCount">The message reaction count.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnMessageReactionCountAsync(
        TBotContext context,
        MessageReactionCountUpdated messageReactionCount,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an inline query update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="inlineQuery">The inline query.</param>
    protected virtual void OnInlineQuery(TBotContext context, InlineQuery inlineQuery) =>
        this.OnInlineQueryAsync(context, inlineQuery).Wait();

    /// <summary>
    /// Handles an inline query update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="inlineQuery">The inline query.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnInlineQueryAsync(
        TBotContext context,
        InlineQuery inlineQuery,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a chosen inline result update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="chosenInlineResult">The chosen inline result.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual void OnChosenInlineResult(
        TBotContext context,
        ChosenInlineResult chosenInlineResult
    ) => this.OnChosenInlineResultAsync(context, chosenInlineResult).Wait();

    /// <summary>
    /// Handles a chosen inline result update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="chosenInlineResult">The chosen inline result.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChosenInlineResultAsync(
        TBotContext context,
        ChosenInlineResult chosenInlineResult,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a callback query update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="callbackQuery">The callback query.</param>
    protected virtual void OnCallbackQuery(TBotContext context, CallbackQuery callbackQuery) =>
        this.OnCallbackQueryAsync(context, callbackQuery).Wait();

    /// <summary>
    /// Handles a callback query update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="callbackQuery">The callback query.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnCallbackQueryAsync(
        TBotContext context,
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a shipping query update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="shippingQuery">The shipping query.</param>
    protected virtual void OnShippingQuery(TBotContext context, ShippingQuery shippingQuery) =>
        this.OnShippingQueryAsync(context, shippingQuery).Wait();

    /// <summary>
    /// Handles a shipping query update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="shippingQuery">The shipping query.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnShippingQueryAsync(
        TBotContext context,
        ShippingQuery shippingQuery,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a pre-checkout query update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="preCheckoutQuery">The pre-checkout query.</param>
    protected virtual void OnPreCheckoutQuery(
        TBotContext context,
        PreCheckoutQuery preCheckoutQuery
    ) => this.OnPreCheckoutQueryAsync(context, preCheckoutQuery).Wait();

    /// <summary>
    /// Handles a pre-checkout query update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="preCheckoutQuery">The pre-checkout query.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnPreCheckoutQueryAsync(
        TBotContext context,
        PreCheckoutQuery preCheckoutQuery,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a poll update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="poll">The poll.</param>
    protected virtual void OnPoll(TBotContext context, Poll poll) =>
        this.OnPollAsync(context, poll).Wait();

    /// <summary>
    /// Handles a poll update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="poll">The poll.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnPollAsync(
        TBotContext context,
        Poll poll,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a poll answer update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="pollAnswer">The poll answer.</param>
    protected virtual void OnPollAnswer(TBotContext context, PollAnswer pollAnswer) =>
        this.OnPollAnswerAsync(context, pollAnswer).Wait();

    /// <summary>
    /// Handles a poll answer update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="pollAnswer">The poll answer.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnPollAnswerAsync(
        TBotContext context,
        PollAnswer pollAnswer,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a my chat member update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="myChatMember">The my chat member.</param>
    protected virtual void OnMyChatMember(TBotContext context, ChatMemberUpdated myChatMember) =>
        this.OnMyChatMemberAsync(context, myChatMember).Wait();

    /// <summary>
    /// Handles a my chat member update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="myChatMember">The my chat member.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnMyChatMemberAsync(
        TBotContext context,
        ChatMemberUpdated myChatMember,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a chat member update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="chatMember">The chat member.</param>
    protected virtual void OnChatMember(TBotContext context, ChatMemberUpdated chatMember) =>
        this.OnChatMemberAsync(context, chatMember).Wait();

    /// <summary>
    /// Handles a chat member update.
    /// </summary>
    /// <param name="chatMember">The chat member.</param>
    /// <param name="chatMember">The chat member.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChatMemberAsync(
        TBotContext context,
        ChatMemberUpdated chatMember,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a chat join request update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="chatJoinRequest">The chat join request.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual void OnChatJoinRequest(
        TBotContext context,
        ChatJoinRequest chatJoinRequest
    ) => this.OnChatJoinRequestAsync(context, chatJoinRequest).Wait();

    /// <summary>
    /// Handles a chat join request update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="chatJoinRequest">The chat join request.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChatJoinRequestAsync(
        TBotContext context,
        ChatJoinRequest chatJoinRequest,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a chat boost update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="chatBoost">The chat boost.</param>
    protected virtual void OnChatBoost(TBotContext context, ChatBoostUpdated chatBoost) =>
        this.OnChatBoostAsync(context, chatBoost).Wait();

    /// <summary>
    /// Handles a chat boost update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="chatBoost">The chat boost.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnChatBoostAsync(
        TBotContext context,
        ChatBoostUpdated chatBoost,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles a removed chat boost update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="removedChatBoost">The removed chat boost.</param>
    protected virtual void OnRemovedChatBoost(
        TBotContext context,
        ChatBoostRemoved removedChatBoost
    ) => this.OnRemovedChatBoostAsync(context, removedChatBoost).Wait();

    /// <summary>
    /// Handles a removed chat boost update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="removedChatBoost">The removed chat boost.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    protected virtual Task OnRemovedChatBoostAsync(
        TBotContext context,
        ChatBoostRemoved removedChatBoost,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;
    #endregion

    #region Extra Handlers
    /// <summary>
    /// Handles an incoming command extracted from the current message update.
    /// </summary>
    /// <param name="context">Bot context.</param>
    /// <param name="message">Message.</param>
    /// <param name="commandName">Command name.</param>
    /// <param name="args">A string containing all the arguments of the command. It could be empty if the command has no arguments.</param>
    protected virtual void OnCommand(
        TBotContext context,
        Message message,
        string commandName,
        string args
    ) => this.OnCommandAsync(context, message, commandName, args).Wait();

    /// <summary>
    /// Handles an incoming command extracted from the current message update.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="commandName">Command name.</param>
    /// <param name="args">A string containing all the arguments of the command. It could be empty if the command has no arguments.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    protected virtual Task OnCommandAsync(
        TBotContext context,
        Message message,
        string commandName,
        string args,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an exception thrown by a bot request.
    /// </summary>
    /// <param name="context">Bot context. Null if the exception was thrown while the context was being created.</param>
    /// <param name="exp">Bot exception</param>
    protected virtual void OnBotException(TBotContext? context, BotRequestException exp) =>
        this.OnBotExceptionAsync(context, exp).Wait();

    /// <summary>
    /// Handles an exception thrown by a bot request.
    /// </summary>
    /// <param name="context">Bot context. Null if the exception was thrown while the context was being created.</param>
    /// <param name="exp">Bot exception</param>
    /// <param name="cancellationToken">Cancellation token</param>
    protected virtual Task OnBotExceptionAsync(
        TBotContext? context,
        BotRequestException exp,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;

    /// <summary>
    /// Handles an exception thrown by the application.
    /// </summary>
    /// <param name="context">Bot context. Null if the exception was thrown while the context was being created.</param>
    /// <param name="exp">Exception</param>
    protected virtual void OnException(TBotContext? context, Exception exp) =>
        this.OnExceptionAsync(context, exp).Wait();

    /// <summary>
    /// Handles an exception thrown by the application.
    /// </summary>
    /// <param name="context">Bot context. Null if the exception was thrown while the context was being created.</param>
    /// <param name="exp">Exception</param>
    /// <param name="cancellationToken">Cancellation token</param>
    protected virtual Task OnExceptionAsync(
        TBotContext? context,
        Exception exp,
        CancellationToken cancellationToken = default
    ) => Task.CompletedTask;
    #endregion
}
