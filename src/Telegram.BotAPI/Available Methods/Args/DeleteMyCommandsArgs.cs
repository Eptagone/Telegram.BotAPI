// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SetMyCommands method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class DeleteMyCommandsArgs
{
	/// <summary>Inititalize a new instance of <see cref="DeleteMyCommandsArgs"/>.</summary>
	/// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands.</param>
	public DeleteMyCommandsArgs([Optional] BotCommandScope scope, [Optional] string languageCode)
	{
		this.Scope = scope;
		this.LanguageCode = languageCode;
	}

	/// <summary>Optional. A <see cref="BotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</summary>
	[JsonPropertyName(PropertyNames.Scope)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public BotCommandScope Scope { get; set; }
	/// <summary>Optional. A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands.</summary>
	[JsonPropertyName(PropertyNames.LanguageCode)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string LanguageCode { get; set; }
}
