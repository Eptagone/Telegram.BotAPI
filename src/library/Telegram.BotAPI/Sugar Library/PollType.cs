// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>Poll type, “quiz” or “regular”, defaults to “regular”</summary>
[Obsolete]
public static class PollType
{
	/// <summary>Quiz poll</summary>
	public const string Quiz = "quiz";
	/// <summary>Regular poll</summary>
	public const string Regular = "regular";
}