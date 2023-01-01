// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
	/// <summary>SetPassportDataErrors method parameters.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SetPassportDataErrorsArgs
	{
		/// <summary>
		/// Initialize a new instance of <see cref="SetPassportDataErrorsArgs"/>.
		/// </summary>
		/// <param name="userId">User identifier.</param>
		/// <param name="errors">A <see cref="PassportElementError"/> array describing the errors.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SetPassportDataErrorsArgs(long userId, IEnumerable<PassportElementError> errors)
		{
			this.UserId = userId;
			this.Errors = errors ?? throw new ArgumentNullException(nameof(errors));
		}

		/// <summary>User identifier.</summary>
		[JsonPropertyName(PropertyNames.UserId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public long UserId { get; }
		/// <summary>A <see cref="PassportElementError"/> array describing the errors.</summary>
		[JsonPropertyName(PropertyNames.Errors)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<PassportElementError> Errors { get; }
	}
}
