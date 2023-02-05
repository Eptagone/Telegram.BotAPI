// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	///<summary>This object represents one button of the reply keyboard. For simple text buttons String can be used instead of this object to specify text of the button. Optional fields are mutually exclusive.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class KeyboardButton : IEquatable<KeyboardButton?>
	{
		/// <summary>Creates a new keyboard button.</summary>
		/// <param name="text">Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed.</param>
		public KeyboardButton(string text)
		{
			this.Text = text;
		}

		/// <summary>
		/// Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed
		/// </summary>
		[JsonPropertyName(PropertyNames.Text)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Text { get; set; }
		/// <summary>
		/// Optional. If specified, pressing the button will open a list of suitable users. Tapping on any user will send their identifier to the bot in a “user_shared” service message. Available in private chats only.
		/// </summary>
		[JsonPropertyName(PropertyNames.RequestUser)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public KeyboardButtonRequestUser? RequestUser { get; set; }
		/// <summary>
		/// Optional. If specified, pressing the button will open a list of suitable chats. Tapping on a chat will send its identifier to the bot in a “chat_shared” service message. Available in private chats only.
		/// </summary>
		[JsonPropertyName(PropertyNames.RequestChat)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public KeyboardButtonRequestChat? RequestChat { get; set; }
		/// <summary>
		/// Optional. If True, the user's phone number will be sent as a contact when the button is pressed. Available in private chats only.
		/// </summary>
		[JsonPropertyName(PropertyNames.RequestContact)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? RequestContact { get; set; }
		/// <summary>
		/// Optional. If True, the user's current location will be sent when the button is pressed. Available in private chats only.
		/// </summary>
		[JsonPropertyName(PropertyNames.RequestLocation)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? RequestLocation { get; set; }
		/// <summary>
		/// Optional. If specified, the user will be asked to create a poll and send it to the bot when the button is pressed. Available in private chats only.
		/// </summary>
		[JsonPropertyName(PropertyNames.RequestPoll)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public KeyboardButtonPollType? RequestPoll { get; set; }
		/// <summary>
		/// Optional. If specified, the described Web App will be launched when the button is pressed. The Web App will be able to send a “web_app_data” service message. Available in private chats only.
		/// </summary>
		[JsonPropertyName(PropertyNames.WebApp)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public WebAppInfo? WebApp { get; set; }

		/// <inheritdoc/>
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as KeyboardButton);
		}
		/// <inheritdoc/>
		public bool Equals(KeyboardButton? other)
		{
			return other is not null &&
				   this.Text == other.Text &&
				   EqualityComparer<KeyboardButtonRequestUser?>.Default.Equals(this.RequestUser, other.RequestUser) &&
				   EqualityComparer<KeyboardButtonRequestChat?>.Default.Equals(this.RequestChat, other.RequestChat) &&
				   this.RequestContact == other.RequestContact &&
				   this.RequestLocation == other.RequestLocation &&
				   EqualityComparer<KeyboardButtonPollType?>.Default.Equals(this.RequestPoll, other.RequestPoll) &&
				   EqualityComparer<WebAppInfo?>.Default.Equals(this.WebApp, other.WebApp);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 1592818789;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Text);
			hashCode = hashCode * -1521134295 + EqualityComparer<KeyboardButtonRequestUser?>.Default.GetHashCode(this.RequestUser);
			hashCode = hashCode * -1521134295 + EqualityComparer<KeyboardButtonRequestChat?>.Default.GetHashCode(this.RequestChat);
			hashCode = hashCode * -1521134295 + this.RequestContact.GetHashCode();
			hashCode = hashCode * -1521134295 + this.RequestLocation.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<KeyboardButtonPollType?>.Default.GetHashCode(this.RequestPoll);
			hashCode = hashCode * -1521134295 + EqualityComparer<WebAppInfo?>.Default.GetHashCode(this.WebApp);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(KeyboardButton? left, KeyboardButton? right)
		{
			return EqualityComparer<KeyboardButton>.Default.Equals(left, right);
		}
		/// <inheritdoc/>
		public static bool operator !=(KeyboardButton? left, KeyboardButton? right)
		{
			return !(left == right);
		}
	}
}
