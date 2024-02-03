// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>
/// Defines a property to send attached files through multipart/form-data.
/// </summary>
public abstract class AttachedFilesArgsBase
{
	/// <summary>
	/// Files to send.
	/// </summary>
	[JsonIgnore]
	public IDictionary<string, InputFile> Files { get; set; } = new Dictionary<string, InputFile>();
}
