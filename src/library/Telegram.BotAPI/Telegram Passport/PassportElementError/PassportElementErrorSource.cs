// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>Available error sources for <see cref="PassportElementError"/>.</summary>
public static class PassportElementErrorSource
{
	/// <summary>Represents an issue in one of the data fields that was provided by the user. The error is considered resolved when the field's value changes.</summary>
	public const string Data = CommonNames.Data;
	/// <summary>Represents an issue with a document scan. The error is considered resolved when the file with the document scan changes.</summary>
	public const string File = "file";
	/// <summary>Represents an issue with a list of scans. The error is considered resolved when the list of files containing the scans changes.</summary>
	public const string Files = "files";
	/// <summary>Represents an issue with the front side of a document. The error is considered resolved when the file with the front side of the document changes.</summary>
	public const string FrontSide = "front_side";
	/// <summary>Represents an issue with the reverse side of a document. The error is considered resolved when the file with reverse side of the document changes.</summary>
	public const string ReverseSide = "reverse_side";
	/// <summary>Represents an issue with the selfie with a document. The error is considered resolved when the file with the selfie changes.</summary>
	public const string Selfie = "selfie";
	/// <summary>Represents an issue with one of the files that constitute the translation of a document. The error is considered resolved when the file changes.</summary>
	public const string TranslationFile = "translation_file";
	/// <summary>Represents an issue with the translated version of a document. The error is considered resolved when a file with the document translation change.</summary>
	public const string TranslationFiles = "translation_files";
	/// <summary>Represents an issue in an unspecified place. The error is considered resolved when new data is added.</summary>
	public const string Unspecified = "unspecified";
}
