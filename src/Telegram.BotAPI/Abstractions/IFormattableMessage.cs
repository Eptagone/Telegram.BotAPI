// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
	/// <summary>Defines a property that implements a class or value type to add basic formatting for messages.</summary>
	public interface IFormattableMessage
	{
		///<summary>Optional. Mode for parsing. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</summary>
		public string? ParseMode { get; set; }
	}
}
