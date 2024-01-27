// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SetChatPhoto method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SetChatPhotoArgs
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SetChatPhotoArgs"/> class.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="photo">New chat photo, uploaded using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="chatId"/> or <paramref name="photo"/> is null.</exception>
	public SetChatPhotoArgs(long chatId, InputFile photo)
	{
		this.ChatId = chatId;
		this.Photo = photo ?? throw new ArgumentNullException(nameof(photo));
	}
	/// <summary>
	/// Initializes a new instance of the <see cref="SetChatPhotoArgs"/> class.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="photo">New chat photo, uploaded using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="chatId"/> or <paramref name="photo"/> is null.</exception>
	public SetChatPhotoArgs(string chatId, InputFile photo)
	{
		this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
		this.Photo = photo ?? throw new ArgumentNullException(nameof(photo));
	}

	/// <summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>New chat photo, uploaded using multipart/form-data.</summary>
	[JsonPropertyName(PropertyNames.Photo)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputFile Photo { get; set; }
}
