// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI;

/// <summary>Base class for Telegram Bots.</summary>
[Obsolete("Use Telegram.BotAPI.Extensions.SimpleTelegramBotBase instead.")]
public abstract class AsyncTelegramBotBase<TBotProperties> : AsyncTelegramBotBase
	where TBotProperties : IBotProperties
{
	/// <summary>The telegram bot properties.</summary>
	protected TBotProperties Properties => this._properties;
	private readonly TBotProperties _properties;

	/// <summary>Bot client instance to interact with the Telegram Bot API.</summary>
	protected ITelegramBotClient Api => this._properties.Api;

	/// <summary>The basic information about the bot.</summary>
	protected User Me => this._properties.User;

	/// <summary>Current update instance.</summary>
	protected Update? Update { get; private set; }

	/// <summary>
	/// Initialize a new instance of <see cref="AsyncTelegramBotBase"/>.
	/// </summary>
	/// <param name="botProperties">Bot properties.</param>
	public AsyncTelegramBotBase(TBotProperties botProperties)
	{
		this._properties = botProperties;
	}

	/// <inheritdoc/>
	public override async Task OnUpdateAsync(
		Update update,
		CancellationToken cancellationToken = default
	)
	{
		this.Update = update;
		await base.OnUpdateAsync(update, cancellationToken);
	}

	/// <summary>
	/// Process received messages. If a bot command is detected, then the <see cref="OnCommandAsync(Message, string, string, CancellationToken)"/> method is called.
	/// </summary>
	/// <param name="message">Message</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	/// <exception cref="ArgumentNullException"></exception>
	protected override async Task OnMessageAsync(
		Message message,
		CancellationToken cancellationToken = default
	)
	{
		if (!string.IsNullOrEmpty(message.Text))
		{
			var cmdMatch = this._properties.CommandHelper.Match(message.Text!);
			if (cmdMatch.Success)
			{
				await this.OnCommandAsync(
					message,
					cmdMatch.Name,
					cmdMatch.Params,
					cancellationToken
				);
			}
		}
	}

	/// <summary>
	/// Read and process a received bot command.<br/>Example: <code>/&lt;command name&gt; &lt;command parameters&gt;</code>
	/// </summary>
	/// <param name="message">Message.</param>
	/// <param name="commandName">Command name.<br/>Example: <code>/<b>&lt;command name&gt;</b> &lt;command parameters&gt;</code></param>
	/// <param name="commandParameters">Command parameters.<br/>Example: <code>/&lt;command name&gt; <b>&lt;command parameters&gt;</b></code></param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected abstract Task OnCommandAsync(
		Message message,
		string commandName,
		string commandParameters,
		CancellationToken cancellationToken = default
	);
}

/// <summary>Base class for Telegram Bots.</summary>
[Obsolete("Use Telegram.BotAPI.Extensions.SimpleTelegramBotBase instead.")]
public abstract class AsyncTelegramBotBase : ITelegramBot
{
	void ITelegramBot.OnUpdate(Update update)
	{
		this.OnUpdateAsync(update).Wait();
	}

	/// <summary>Call the corresponding method according to the type of update provided.</summary>
	/// <param name="update">Update</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	public virtual async Task OnUpdateAsync(
		Update update,
		CancellationToken cancellationToken = default
	)
	{
		if (update == default)
		{
			throw new ArgumentNullException(nameof(update));
		}
		try
		{
			if (update.Message is not null)
			{
				await this.OnMessageAsync(update.Message, cancellationToken).ConfigureAwait(false);
			}
			else if (update.EditedMessage is not null)
			{
				await this.OnEditedMessageAsync(update.EditedMessage, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.ChannelPost is not null)
			{
				await this.OnChannelPostAsync(update.ChannelPost, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.EditedChannelPost is not null)
			{
				await this.OnEditedChannelPostAsync(update.EditedChannelPost, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.InlineQuery is not null)
			{
				await this.OnInlineQueryAsync(update.InlineQuery, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.ChosenInlineResult is not null)
			{
				await this.OnChosenInlineResultAsync(update.ChosenInlineResult, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.CallbackQuery is not null)
			{
				await this.OnCallbackQueryAsync(update.CallbackQuery, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.ShippingQuery is not null)
			{
				await this.OnShippingQueryAsync(update.ShippingQuery, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.PreCheckoutQuery is not null)
			{
				await this.OnPreCheckoutQueryAsync(update.PreCheckoutQuery, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.Poll is not null)
			{
				await this.OnPollAsync(update.Poll, cancellationToken).ConfigureAwait(false);
			}
			else if (update.PollAnswer is not null)
			{
				await this.OnPollAnswerAsync(update.PollAnswer, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.MyChatMember is not null)
			{
				await this.OnMyChatMemberAsync(update.MyChatMember, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.ChatMember is not null)
			{
				await this.OnChatMemberAsync(update.ChatMember, cancellationToken)
					.ConfigureAwait(false);
			}
			else if (update.ChatJoinRequest is not null)
			{
				await this.OnChatJoinRequestAsync(update.ChatJoinRequest, cancellationToken)
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

	/// <summary>Instructions for a message update.</summary>
	/// <param name="message">Message.</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected abstract Task OnMessageAsync(
		Message message,
		CancellationToken cancellationToken = default
	);

	/// <summary>Instructions for an edited message.</summary>
	/// <param name="message">Message</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnEditedMessageAsync(
		Message message,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for a channel post.</summary>
	/// <param name="message">Message</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnChannelPostAsync(
		Message message,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for an edited channel post update.</summary>
	/// <param name="message">Message</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnEditedChannelPostAsync(
		Message message,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for an inline query update.</summary>
	/// <param name="inlineQuery">Inline query.</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnInlineQueryAsync(
		InlineQuery inlineQuery,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for a chosen inline result update.</summary>
	/// <param name="chosenInlineResult">Chosen Inline Result.</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnChosenInlineResultAsync(
		ChosenInlineResult chosenInlineResult,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for a callback query update.</summary>
	/// <param name="callbackQuery">Callback query</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnCallbackQueryAsync(
		CallbackQuery callbackQuery,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for a shipping query update.</summary>
	/// <param name="shippingQuery">Shipping query</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnShippingQueryAsync(
		ShippingQuery shippingQuery,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for a pre-checkout query update.</summary>
	/// <param name="preCheckoutQuery">Pre-checkout query.</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnPreCheckoutQueryAsync(
		PreCheckoutQuery preCheckoutQuery,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for a poll update.</summary>
	/// <param name="poll">Poll.</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnPollAsync(Poll poll, CancellationToken cancellationToken = default) =>
		Task.CompletedTask;

	/// <summary>Instructions for a poll answer update.</summary>
	/// <param name="pollAnswer">Poll answer.</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnPollAnswerAsync(
		PollAnswer pollAnswer,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for my chat member update.</summary>
	/// <param name="myChatMemberUpdated">My chat member updated.</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnMyChatMemberAsync(
		ChatMemberUpdated myChatMemberUpdated,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for chat member update.</summary>
	/// <param name="chatMemberUpdated">Chat member updated.</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnChatMemberAsync(
		ChatMemberUpdated chatMemberUpdated,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for chat join request update.</summary>
	/// <param name="chatJoinRequest">Chat join request.</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected virtual Task OnChatJoinRequestAsync(
		ChatJoinRequest chatJoinRequest,
		CancellationToken cancellationToken = default
	) => Task.CompletedTask;

	/// <summary>Instructions for a bot exception.</summary>
	/// <param name="exp">Bot exception</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected abstract Task OnBotExceptionAsync(
		BotRequestException exp,
		CancellationToken cancellationToken = default
	);

	/// <summary>Instructions for a general exception.</summary>
	/// <param name="exp">Exception</param>
	/// <param name="cancellationToken">Optional. The cancelation token.</param>
	/// <returns><see cref="Task"/></returns>
	protected abstract Task OnExceptionAsync(
		Exception exp,
		CancellationToken cancellationToken = default
	);
}
