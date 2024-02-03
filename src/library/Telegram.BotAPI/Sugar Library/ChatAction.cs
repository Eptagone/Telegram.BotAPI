// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// Provides the available actions to be used when sending a chat action.
/// </summary>
[Obsolete("Use Telegram.BotAPI.ChatActions instead.")]
public static class ChatAction
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public const string Typing = ChatActions.Typing;
	public const string UploadPhoto = ChatActions.UploadPhoto;
	public const string RecordVideo = ChatActions.RecordVideo;
	public const string UploadVideo = ChatActions.UploadVideo;
	public const string RecordVoice = ChatActions.RecordVoice;
	public const string UploadVoice = ChatActions.UploadVoice;
	public const string UploadDocument = ChatActions.UploadDocument;
	public const string FindLocation = ChatActions.FindLocation;
	public const string RecordVideoNote = ChatActions.RecordVideoNote;
	public const string UploadVideoNote = ChatActions.UploadVideoNote;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
