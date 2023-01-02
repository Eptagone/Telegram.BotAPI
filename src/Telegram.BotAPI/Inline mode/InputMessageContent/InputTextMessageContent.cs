// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents the content of a text message to be sent as the result of an inline query.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InputTextMessageContent : InputMessageContent, IEquatable<InputTextMessageContent>
	{
		/// <summary>
		/// Initialize a new instance of <see cref="InputTextMessageContent"/>.
		/// </summary>
		/// <param name="messageText">Text of the message to be sent, 1-4096 characters.</param>
		/// <param name="disableWebPagePreview">Disables link previews for links in the sent message.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public InputTextMessageContent(string messageText, [Optional] bool? disableWebPagePreview)
		{
			this.MessageText = messageText ?? throw new ArgumentNullException(nameof(messageText));
			this.DisableWebPagePreview = disableWebPagePreview;
		}

		/// <summary>
		/// Initialize a new instance of <see cref="InputTextMessageContent"/>.
		/// </summary>
		/// <param name="messageText">Text of the message to be sent, 1-4096 characters.</param>
		/// <param name="parseMode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
		/// <param name="disableWebPagePreview">Disables link previews for links in the sent message.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public InputTextMessageContent(string messageText, string parseMode, [Optional] bool? disableWebPagePreview)
		{
			if (string.IsNullOrEmpty(parseMode))
			{
				throw new ArgumentNullException(nameof(messageText));
			}

			this.MessageText = messageText ?? throw new ArgumentNullException(nameof(messageText));
			this.ParseMode = parseMode;
			this.DisableWebPagePreview = disableWebPagePreview;
		}

		/// <summary>
		/// Initialize a new instance of <see cref="InputTextMessageContent"/>.
		/// </summary>
		/// <param name="messageText">Text of the message to be sent, 1-4096 characters.</param>
		/// <param name="entities">List of special entities that appear in message text, which can be specified instead of parse_mode.</param>
		/// <param name="disableWebPagePreview">Disables link previews for links in the sent message.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public InputTextMessageContent(string messageText, IEnumerable<MessageEntity> entities, [Optional] bool? disableWebPagePreview)
		{
			this.MessageText = messageText ?? throw new ArgumentNullException(nameof(messageText));
			this.Entities = entities ?? throw new ArgumentNullException(nameof(entities));
			this.DisableWebPagePreview = disableWebPagePreview;
		}

		///<summary>Text of the message to be sent, 1-4096 characters.</summary>
		[JsonPropertyName(PropertyNames.MessageText)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string MessageText { get; }
		///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
		[JsonPropertyName(PropertyNames.ParseMode)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ParseMode { get; }
		///<summary>Optional. List of special entities that appear in message text, which can be specified instead of parse_mode.</summary>
		[JsonPropertyName(PropertyNames.Entities)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<MessageEntity>? Entities { get; }
		///<summary>Optional. Disables link previews for links in the sent message.</summary>
		[JsonPropertyName(PropertyNames.DisableWebPagePreview)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? DisableWebPagePreview { get; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InputTextMessageContent);
		}
		/// <inheritdoc/>
		public bool Equals(InputTextMessageContent? other)
		{
			return other != null &&
				   this.MessageText == other.MessageText &&
				   this.ParseMode == other.ParseMode &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.Entities, other.Entities) &&
				   this.DisableWebPagePreview == other.DisableWebPagePreview;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 119831400;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.MessageText);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.Entities);
			hashCode = hashCode * -1521134295 + this.DisableWebPagePreview.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InputTextMessageContent? left, InputTextMessageContent? right)
		{
			return EqualityComparer<InputTextMessageContent>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InputTextMessageContent? left, InputTextMessageContent? right)
		{
			return !(left == right);
		}

	}
}
