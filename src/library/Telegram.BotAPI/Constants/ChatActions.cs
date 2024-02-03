// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// Provides the available actions to be used when sending a chat action.
/// </summary>
public static class ChatActions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public const string Typing = "typing";
	public const string UploadPhoto = "upload_photo";
	public const string RecordVideo = "record_video";
	public const string UploadVideo = "upload_video";
	public const string RecordVoice = "record_voice";
	public const string UploadVoice = "upload_voice";
	public const string UploadDocument = "upload_document";
	public const string FindLocation = "find_location";
	public const string RecordVideoNote = "record_video_note";
	public const string UploadVideoNote = "upload_video_note";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
