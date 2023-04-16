// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents the scope of bot commands, covering a specific chat.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class BotCommandScopeChat : BotCommandScope, IEquatable<BotCommandScopeChat>
{
	/// <summary>Initialize a new instance of <see cref="BotCommandScopeChat"/></summary>
	public BotCommandScopeChat()
	{
		this.ChatId = null!;
	}

	/// <summary>Initialize a new instance of <see cref="BotCommandScopeChat"/></summary>
	/// <param name="chatId"><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	public BotCommandScopeChat(long chatId)
	{
		this.ChatId = chatId;
	}
	/// <summary>Initialize a new instance of <see cref="BotCommandScopeChat"/></summary>
	/// <param name="chatId"><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	public BotCommandScopeChat(string chatId)
	{
		this.ChatId = chatId;
	}

	/// <summary>Scope type, must be chat.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => BotCommandScopeType.Chat;
	/// <summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }

	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as BotCommandScopeChat);
	}
	/// <inheritdoc/>
	public bool Equals(BotCommandScopeChat? other)
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
	public static bool operator ==(BotCommandScopeChat? left, BotCommandScopeChat? right)
	{
		return EqualityComparer<BotCommandScopeChat>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(BotCommandScopeChat? left, BotCommandScopeChat? right)
	{
		return !(left == right);
	}
}
