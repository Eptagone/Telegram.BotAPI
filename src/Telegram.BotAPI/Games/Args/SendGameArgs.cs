// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.Games
{
	/// <summary>SendGame method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SendGameArgs : SendMessageBase<long>, ICustomizableReplyMarkup<InlineKeyboardMarkup>
	{
		/// <summary>
		/// Initialize a new instance of <see cref="SendGameArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat.</param>
		/// <param name="gameShortName">Short name of the game, serves as the unique identifier for the game. Set up your games via BotFather.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendGameArgs(long chatId, string gameShortName) : base(chatId)
		{
			this.ChatId = chatId;
			this.GameShortName = gameShortName ?? throw new ArgumentNullException(nameof(gameShortName));
		}

		/// <summary>Unique identifier for the target chat.</summary>
		[JsonPropertyName(PropertyNames.ChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override long ChatId { get; }
		/// <summary>Short name of the game, serves as the unique identifier for the game. Set up your games via BotFather.</summary>
		[JsonPropertyName(PropertyNames.GameShortName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string GameShortName { get; }
		/// <summary>Optional. A JSON-serialized object for an inline keyboard. If empty, one ‘Play game_title’ button will be shown. If not empty, the first button must launch the game.</summary>
		[JsonPropertyName(PropertyNames.ReplyMarkup)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InlineKeyboardMarkup? ReplyMarkup { get; set; }
	}
}
