// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Defines a property to send attached files through multipart/form-data.
/// </summary>
/// <param name="files">List of attached files to send.</param>
public abstract class AttachedFilesArgsBase(IDictionary<string, InputFile>? files = null)
{
	/// <summary>
	/// List of files to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.
	/// </summary>
	[JsonIgnore]
	[Newtonsoft.Json.JsonIgnore]
	[Obsolete("Use Files instead.")]
	public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new List<AttachedFile>();

	/// <summary>
	/// Files to send.
	/// </summary>
	[JsonIgnore]
	[Newtonsoft.Json.JsonIgnore]
	public IDictionary<string, InputFile> Files { get; set; } = files ?? new Dictionary<string, InputFile>();
}
