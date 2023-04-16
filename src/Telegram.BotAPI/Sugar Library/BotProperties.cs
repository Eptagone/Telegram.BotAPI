// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Net.Http;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>Represents a set of basic bot configuration properties.</summary>
public class BotProperties : IBotProperties
{
	/// <summary>Initialize a new instance of <see cref="BotProperties"/>.</summary>
	/// <param name="bot">The Telegram Bot Client</param>
	public BotProperties(BotClient bot)
	{
		this.Api = bot;
		this.User = bot.GetMe();
		this.CommandHelper = new BotCommandHelper(this);
	}
	/// <summary>Initialize a new instance of <see cref="BotProperties"/>.</summary>
	/// <param name="botToken">Token granted by BotFather. Required to access the Telegram bot API.</param>
	/// <param name="httpClient">Provide a specific HttpClient for this instance of BotClient.</param>
	public BotProperties(string botToken, [Optional] HttpClient httpClient) : this(new BotClient(botToken, httpClient))
	{
	}
	/// <inheritdoc/>
	public BotClient Api { get; }
	/// <inheritdoc/>
	public User User { get; }
	IBotCommandHelper IBotProperties.CommandHelper => this.CommandHelper;



	/// <summary>
	/// The bot command helper.
	/// </summary>
	public BotCommandHelper CommandHelper { get; }
}
