// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.


using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ReplyKeyboardMarkup : ReplyMarkup, IEquatable<ReplyKeyboardMarkup>
	{
		/// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
		public ReplyKeyboardMarkup() { }
		/// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
		/// <param name="keyboard">Array of button rows, each represented by an Array of KeyboardButton objects.</param>
		public ReplyKeyboardMarkup(params IEnumerable<KeyboardButton>[] keyboard)
		{
			this.Keyboard = keyboard;
		}
		/// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
		/// <param name="keyboard">Array of button rows, each represented by an Array of KeyboardButton objects.</param>
		public ReplyKeyboardMarkup(params KeyboardButton[][] keyboard)
		{
			this.Keyboard = keyboard;
		}

		/// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
		/// <param name="keyboard">Array of button rows, each represented by an Array of KeyboardButton objects.</param>
		/// <param name="isPersistent">Optional. Requests clients to always show the keyboard when the regular keyboard is hidden. Defaults to false, in which case the custom keyboard can be hidden and opened with a keyboard icon.</param>
		/// <param name="resizeKeyboard">Optional. Requests clients to resize the keyboard vertically for optimal fit (e.g., make the keyboard smaller if there are just two rows of buttons). Defaults to false, in which case the custom keyboard is always of the same height as the app's standard keyboards.</param>
		/// <param name="oneTimeKeyboard">Optional. Requests clients to hide the keyboard as soon as it's been used. The keyboard will still be available, but clients will automatically display the usual letter-keyboard in the chat – the user can press a special button in the input field to see the custom keyboard again. Defaults to false.</param>
		/// <param name="inputFieldPlaceholder">Optional. The placeholder to be shown in the input field when the keyboard is active; 1-64 characters</param>
		/// <param name="selective">Optional. Use this parameter if you want to show the keyboard to specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.<para>Example: A user requests to change the bot‘s language, bot replies to the request with a keyboard to select the new language. Other users in the group don’t see the keyboard.</para></param>
		public ReplyKeyboardMarkup(
			IEnumerable<IEnumerable<KeyboardButton>> keyboard,
			[Optional] bool? isPersistent,
			[Optional] bool? resizeKeyboard,
			[Optional] bool? oneTimeKeyboard,
			[Optional] string inputFieldPlaceholder,
			[Optional] bool? selective)
		{
			this.Keyboard = keyboard;
			this.IsPersistent = isPersistent;
			this.ResizeKeyboard = resizeKeyboard;
			this.OneTimeKeyboard = oneTimeKeyboard;
			this.InputFieldPlaceholder = inputFieldPlaceholder;
			this.Selective = selective;
		}

		/// <summary>Array of button rows, each represented by an Array of KeyboardButton objects.</summary>
		[JsonPropertyName(PropertyNames.Keyboard)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<IEnumerable<KeyboardButton>> Keyboard { get; set; }
		/// <summary>Optional. Requests clients to always show the keyboard when the regular keyboard is hidden. Defaults to false, in which case the custom keyboard can be hidden and opened with a keyboard icon.</summary>
		[JsonPropertyName(PropertyNames.IsPersistent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? IsPersistent { get; set; }
		/// <summary>Optional. Requests clients to resize the keyboard vertically for optimal fit (e.g., make the keyboard smaller if there are just two rows of buttons). Defaults to false, in which case the custom keyboard is always of the same height as the app's standard keyboards.</summary>
		[JsonPropertyName(PropertyNames.ResizeKeyboard)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? ResizeKeyboard { get; set; }
		/// <summary>Optional. Requests clients to hide the keyboard as soon as it's been used. The keyboard will still be available, but clients will automatically display the usual letter-keyboard in the chat – the user can press a special button in the input field to see the custom keyboard again. Defaults to false.</summary>
		[JsonPropertyName(PropertyNames.OneTimeKeyboard)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? OneTimeKeyboard { get; set; }
		/// <summary>Optional. The placeholder to be shown in the input field when the keyboard is active; 1-64 characters.</summary>
		[JsonPropertyName(PropertyNames.InputFieldPlaceholder)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string InputFieldPlaceholder { get; set; }
		/// <summary>
		///Optional. Use this parameter if you want to show the keyboard to specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.
		///<para>Example: A user requests to change the bot‘s language, bot replies to the request with a keyboard to select the new language. Other users in the group don’t see the keyboard.</para>
		///</summary>
		[JsonPropertyName(PropertyNames.Selective)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? Selective { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ReplyKeyboardMarkup);
		}
		/// <inheritdoc/>
		public bool Equals(ReplyKeyboardMarkup? other)
		{
			return other != null &&
				   EqualityComparer<IEnumerable<IEnumerable<KeyboardButton>>>.Default.Equals(this.Keyboard, other.Keyboard) &&
				   this.IsPersistent == other.IsPersistent &&
				   this.ResizeKeyboard == other.ResizeKeyboard &&
				   this.OneTimeKeyboard == other.OneTimeKeyboard &&
				   this.InputFieldPlaceholder == other.InputFieldPlaceholder &&
				   this.Selective == other.Selective;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 1966068018;
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<IEnumerable<KeyboardButton>>>.Default.GetHashCode(this.Keyboard);
			hashCode = hashCode * -1521134295 + this.IsPersistent.GetHashCode();
			hashCode = hashCode * -1521134295 + this.ResizeKeyboard.GetHashCode();
			hashCode = hashCode * -1521134295 + this.OneTimeKeyboard.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.InputFieldPlaceholder);
			hashCode = hashCode * -1521134295 + this.Selective.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ReplyKeyboardMarkup? left, ReplyKeyboardMarkup? right)
		{
			return EqualityComparer<ReplyKeyboardMarkup>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ReplyKeyboardMarkup? left, ReplyKeyboardMarkup? right)
		{
			return !(left == right);
		}

	}
}
