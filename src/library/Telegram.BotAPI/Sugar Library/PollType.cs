// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>Poll type, “quiz” or “regular”, defaults to “regular”</summary>
[Obsolete("Use Telegram.BotAPI.PollTypes instead.")]
public static class PollType
{
	/// <summary>Quiz poll</summary>
	public const string Quiz = PollTypes.Quiz;

	/// <summary>Regular poll</summary>
	public const string Regular = PollTypes.Regular;
}
