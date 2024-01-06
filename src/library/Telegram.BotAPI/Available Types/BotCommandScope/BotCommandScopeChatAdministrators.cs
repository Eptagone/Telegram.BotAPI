// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents the scope of bot commands, covering all administrators of a specific group or supergroup chat.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class BotCommandScopeChatAdministrators : BotCommandScope, IEquatable<BotCommandScopeChatAdministrators>
{
	/// <summary>Inititalize a new instance of <see cref="BotCommandScopeAllChatAdministrators"/>.</summary>
	public BotCommandScopeChatAdministrators()
	{
	}
	/// <summary>Inititalize a new instance of <see cref="BotCommandScopeAllChatAdministrators"/>.</summary>
	/// <param name="chatId"><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	public BotCommandScopeChatAdministrators(long chatId)
	{
		this.ChatId = chatId;
	}
	/// <summary>Inititalize a new instance of <see cref="BotCommandScopeAllChatAdministrators"/>.</summary>
	/// <param name="chatId"><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	public BotCommandScopeChatAdministrators(string chatId)
	{
		this.ChatId = chatId;
	}

	/// <summary>Scope type, must be chat_administrators.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => BotCommandScopeType.ChatAdministrators;
	/// <summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as BotCommandScopeChatAdministrators);
	}
	/// <inheritdoc/>
	public bool Equals(BotCommandScopeChatAdministrators? other)
	{
		return other != null &&
			   EqualityComparer<object>.Default.Equals(this.ChatId, other.ChatId);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		return -1413881002 + EqualityComparer<object>.Default.GetHashCode(this.ChatId);
	}
	/// <inheritdoc/>
	public static bool operator ==(BotCommandScopeChatAdministrators? left, BotCommandScopeChatAdministrators? right)
	{
		return EqualityComparer<BotCommandScopeChatAdministrators>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(BotCommandScopeChatAdministrators? left, BotCommandScopeChatAdministrators? right)
	{
		return !(left == right);
	}

}
