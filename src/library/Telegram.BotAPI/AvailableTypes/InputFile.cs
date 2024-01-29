// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Net.Http;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents the contents of a file to be uploaded. Must be posted using multipart/form-data in the usual way that files are uploaded via the browser.
/// </summary>
public sealed class InputFile : IEquatable<InputFile>
{
	/// <summary>
	/// HTTP file content.
	/// </summary>
	[JsonIgnore]
	public StreamContent Content { get; private set; }
	/// <summary>
	/// File name.
	/// </summary>
	[JsonIgnore]
	public string Filename { get; private set; }

	/// <summary>New InputFile.</summary>
	/// <param name="streamcontent">HTTP file content.</param>
	/// <param name="filename">File name.</param>
	public InputFile(StreamContent streamcontent, string filename)
	{
		this.Content = streamcontent;
		this.Filename = filename;
	}

	/// <summary>New InputFile.</summary>
	/// <param name="stream">Stream file.</param>
	/// <param name="filename">File name.</param>
	public InputFile(Stream stream, string filename)
	{
		this.Content = new StreamContent(stream);
		this.Filename = filename;
	}

	/// <summary>New InputFile.</summary>
	/// <param name="file">File.</param>
	/// <param name="filename">File name.</param>
	public InputFile(byte[] file, string filename)
	{
		this.Content = new StreamContent(new MemoryStream(file));
		this.Filename = filename;
	}

	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as InputFile);
	}
	/// <inheritdoc/>
	public bool Equals(InputFile? other)
	{
		return other != null &&
			   EqualityComparer<StreamContent>.Default.Equals(this.Content, other.Content) &&
			   this.Filename == other.Filename;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1463301466;
		hashCode = hashCode * -1521134295 + EqualityComparer<StreamContent>.Default.GetHashCode(this.Content);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Filename);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InputFile? left, InputFile? right)
	{
		return EqualityComparer<InputFile>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InputFile? left, InputFile? right)
	{
		return !(left == right);
	}

}
