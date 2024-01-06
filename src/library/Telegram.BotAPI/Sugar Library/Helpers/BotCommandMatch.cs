// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>This object represents the result of a bot command match.</summary>
[Obsolete]
public class BotCommandMatch
{
	/// <summary>Initialize a new instance of <see cref="BotCommandMatch"/>.</summary>
	public BotCommandMatch()
	{
		this.Name = string.Empty;
		this.Params = string.Empty;
	}
	/// <summary>Initialize a new instance of <see cref="BotCommandMatch"/>.</summary>
	/// <param name="name">Command name.</param>
	/// <param name="params">Command parameters.</param>
	public BotCommandMatch(string name, string @params)
	{
		this.Success = true;
		this.Name = name;
		this.Params = @params;
	}

	/// <summary>Gets a value indicating whether the match is successful.</summary>
	/// <returns>true if the match is successful; otherwise, false.</returns>
	public bool Success { get; }
	/// <summary>Command name.</summary>
	public string Name { get; }
	/// <summary>Command parameters.</summary>
	public string Params { get; }
}
