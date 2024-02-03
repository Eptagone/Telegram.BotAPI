// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>
/// Extensions for MessageEntity
/// </summary>
public static partial class MessageEntityExtensions
{
	/// <summary>
	/// Get the entity type as enum.
	/// </summary>
	/// <returns><see cref="MessageEntityType"/></returns>
	[Obsolete("Use the MessageEntity.Type property instead.")]
	public static MessageEntityType GetEntityType(this MessageEntity messageEntity)
	{
		string type = messageEntity.Type.Replace("_", string.Empty);
		return (MessageEntityType)Enum.Parse(typeof(MessageEntityType), type, true);
	}
}
