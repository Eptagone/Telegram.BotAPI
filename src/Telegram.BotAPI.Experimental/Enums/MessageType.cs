// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes;


/// <summary>Message Type</summary>
public enum MessageType
{
	/// <summary>Message is a text message.</summary>
	Text,
	/// <summary>Message is an animation.</summary>
	Animation,
	/// <summary>Message is an audio file.</summary>
	Audio,
	/// <summary>Message is a general file.</summary>
	Document,
	/// <summary>Message is a photo.</summary>
	Photo,
	/// <summary>Message is a sticker.</summary>
	Sticker,
	/// <summary>Message is a video.</summary>
	Video,
	/// <summary>Message is a video note.</summary>
	VideoNote,
	/// <summary>Message is a voice message.</summary>
	Voice,
	/// <summary>Message is a shared contact.</summary>
	Contact,
	/// <summary>Message is a dice with random value.</summary>
	Dice,
	/// <summary>Message is a game.</summary>
	Game,
	/// <summary>Message is a native poll.</summary>
	Poll,
	/// <summary>Message is a venue.</summary>
	Venue,
	/// <summary>Message is a shared location.</summary>
	Location,
	/// <summary>Message is an invoice for a payment.</summary>
	Invoice,
	/// <summary>Message is a service message about a successful payment.</summary>
	SuccessfulPayment,
	/// <summary>Message type is unknown.</summary>
	Unknown
}
