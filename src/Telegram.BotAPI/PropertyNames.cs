﻿// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>Contains contant strings with all Bot API property names.</summary>
public static partial class PropertyNames
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public const string AddedToAttachmentMenu = "added_to_attachment_menu";
	public const string Address = "address";
	public const string Action = "action";
	public const string ActiveUsernames = "active_usernames";
	public const string AllowedUpdates = "allowed_updates";
	public const string AllowSendingWithoutReply = "allow_sending_without_reply";
	public const string AllowsMultipleAnswers = "allows_multiple_answers";
	public const string Amount = "amount";
	public const string Animation = CommonNames.Animation;
	public const string Audio = CommonNames.Audio;
	public const string AudioDuration = "audio_duration";
	public const string AudioFileId = "audio_file_id";
	public const string AudioUrl = "audio_url";
	public const string AuthorSignature = "author_signature";
	public const string BigFileId = "big_file_id";
	public const string BigFileUniqueId = "big_file_unique_id";
	public const string Bio = "bio";
	public const string BotAdministratorRights = "bot_administrator_rights";
	public const string BotIsMember = "bot_is_member";
	public const string BotUsername = "bot_username";
	public const string ButtonText = "button_text";
	public const string CacheTime = "cache_time";
	public const string CallbackData = "callback_data";
	public const string CallbackGame = "callback_game";
	public const string CallbackQuery = CommonNames.CallbackQuery;
	public const string CallbackQueryId = "callback_query_id";
	public const string CanAddWebPagePreviews = "can_add_web_page_previews";
	public const string CanBeEdited = "can_be_edited";
	public const string CanChangeInfo = "can_change_info";
	public const string CanDeleteMessages = "can_delete_messages";
	public const string CanEditMessages = "can_edit_messages";
	public const string CanInviteUsers = "can_invite_users";
	public const string CanJoinGroups = "can_join_groups";
	public const string CanManageChat = "can_manage_chat";
	public const string CanManageTopics = "can_manage_topics";
	public const string CanManageVideoChats = "can_manage_video_chats";
	public const string CanPinMessages = "can_pin_messages";
	public const string CanPostMessages = "can_post_messages";
	public const string CanPromoteMembers = "can_promote_members";
	public const string CanReadAllGroupMessages = "can_read_all_group_messages";
	public const string CanRestrictMembers = "can_restrict_members";
	public const string CanSendAudios = "can_send_audios";
	public const string CanSendDocuments = "can_send_documents";
	public const string CanSendMessages = "can_send_messages";
	public const string CanSendOtherMessages = "can_send_other_messages";
	public const string CanSendPhotos = "can_send_photos";
	public const string CanSendPolls = "can_send_polls";
	public const string CanSendVideoNotes = "can_send_video_notes";
	public const string CanSendVideos = "can_send_videos";
	public const string CanSendVoiceNotes = "can_send_voice_notes";
	public const string CanSetStickerSet = "can_set_sticker_set";
	public const string Caption = "caption";
	public const string CaptionEntities = "caption_entities";
	public const string Certificate = "certificate";
	public const string ChannelChatCreated = "channel_chat_created";
	public const string ChannelPost = CommonNames.ChannelPost;
	public const string Chat = CommonNames.Chat;
	public const string ChatId = "chat_id";
	public const string ChatIsChannel = "chat_is_channel";
	public const string ChatIsCreated = "chat_is_created";
	public const string ChatIsForum = "chat_is_forum";
	public const string ChatInstance = "chat_instance";
	public const string ChatHasUsername = "chat_has_username";
	public const string ChatJoinRequest = CommonNames.ChatJoinRequest;
	public const string ChatMember = CommonNames.ChatMember;
	public const string ChatShared = "chat_shared";
	public const string ChatType = "chat_type";
	public const string ChosenInlineResult = CommonNames.ChosenInlineResult;
	public const string City = "city";
	public const string CloseDate = "close_date";
	public const string Command = "command";
	public const string Commands = "commands";
	public const string ConnectedWebsite = "connected_website";
	public const string Contact = CommonNames.Contact;
	public const string CorrectOptionId = "correct_option_id";
	public const string CountryCode = "country_code";
	public const string CreatesJoinRequest = "creates_join_request";
	public const string Creator = "creator";
	public const string Credentials = "credentials";
	public const string Currency = "currency";
	public const string CustomEmojiId = "custom_emoji_id";
	public const string CustomEmojiIds = "custom_emoji_ids";
	public const string CustomTitle = "custom_title";
	public const string Data = CommonNames.Data;
	public const string DataHash = "data_hash";
	public const string Date = "date";
	public const string DeleteChatPhoto = "delete_chat_photo";
	public const string Description = "description";
	public const string Dice = "dice";
	public const string DisableContentTypeDetection = "disable_content_type_detection";
	public const string DisableEditMessage = "disable_edit_message";
	public const string DisableNotification = "disable_notification";
	public const string DisableWebPagePreview = "disable_web_page_preview";
	public const string Distance = "distance";
	public const string Document = CommonNames.Document;
	public const string DocumentFileId = "document_file_id";
	public const string DocumentUrl = "document_url";
	public const string DropPendingUpdates = "drop_pending_updates";
	public const string Duration = "duration";
	public const string EditDate = "edit_date";
	public const string EditedChannelPost = CommonNames.EditedChannelPost;
	public const string EditedMessage = CommonNames.EditedMessage;
	public const string ElementHash = "element_hash";
	public const string Email = "email";
	public const string Emoji = "emoji";
	public const string EmojiList = "emoji_list";
	public const string EmojiStatusCustomEmojiId = "emoji_status_custom_emoji_id";
	public const string Entities = "entities";
	public const string ErrorMessage = "error_message";
	public const string Errors = "errors";
	public const string Explanation = "explanation";
	public const string ExplanationEntities = "explanation_entities";
	public const string ExplanationParseMode = "explanation_parse_mode";
	public const string ExpireDate = "expire_date";
	public const string FieldName = "field_name";
	public const string FileDate = "file_date";
	public const string FileHash = "file_hash";
	public const string FileHashes = "file_hashes";
	public const string FileId = "file_id";
	public const string FileName = "file_name";
	public const string FilePath = "file_path";
	public const string Files = "files";
	public const string FileSize = "file_size";
	public const string FileUniqueId = "file_unique_id";
	public const string FirstName = "first_name";
	public const string ForChannels = "for_channels";
	public const string Force = "force";
	public const string ForceReply = "force_reply";
	public const string ForumTopicClosed = "forum_topic_closed";
	public const string ForumTopicCreated = "forum_topic_created";
	public const string ForumTopicEdited = "forum_topic_edited";
	public const string ForumTopicReopened = "forum_topic_reopened";
	public const string ForwardDate = "forward_date";
	public const string ForwardFrom = "forward_from";
	public const string ForwardFromChat = "forward_from_chat";
	public const string ForwardFromMessageId = "forward_from_message_id";
	public const string ForwardSenderName = "forward_sender_name";
	public const string ForwardSignature = "forward_signature";
	public const string ForwardText = "forward_text";
	public const string FoursquareId = "foursquare_id";
	public const string FoursquareType = "foursquare_type";
	public const string From = "from";
	public const string FromChatId = "from_chat_id";
	public const string FrontSide = "front_side";
	public const string Game = CommonNames.Game;
	public const string GameShortName = "game_short_name";
	public const string GeneralForumTopicHidden = "general_forum_topic_hidden";
	public const string GeneralForumTopicUnhidden = "general_forum_topic_unhidden";
	public const string GifDuration = "gif_duration";
	public const string GifFileId = "gif_file_id";
	public const string GifHeight = "gif_height";
	public const string GifUrl = "gif_url";
	public const string GifWidth = "gif_width";
	public const string GooglePlaceId = "google_place_id";
	public const string GooglePlaceType = "google_place_type";
	public const string GroupChatCreated = "group_chat_created";
	public const string HasSpoiler = "has_spoiler";
	public const string HasCustomCertificate = "has_custom_certificate";
	public const string Hash = "hash";
	public const string HasAggressiveAntiSpamEnabled = "has_aggressive_anti_spam_enabled";
	public const string HasHiddenMembers = "has_hidden_members";
	public const string HasPrivateForwards = "has_private_forwards";
	public const string HasMediaSpoiler = "has_media_spoiler";
	public const string HasRestrictedVoiceAndVideoMessages = "has_restricted_voice_and_video_messages";
	public const string HasProtectedContent = "has_protected_content";
	public const string Heading = "heading";
	public const string Height = "height";
	public const string HideUrl = "hide_url";
	public const string HorizontalAccuracy = "horizontal_accuracy";
	public const string IconColor = "icon_color";
	public const string IconCustomEmojiId = "icon_custom_emoji_id";
	public const string Id = "id";
	public const string InlineKeyboard = "inline_keyboard";
	public const string InlineMessageId = "inline_message_id";
	public const string InlineQuery = CommonNames.InlineQuery;
	public const string InlineQueryId = "inline_query_id";
	public const string InputFieldPlaceholder = "input_field_placeholder";
	public const string InputMessageContent = "input_message_content";
	public const string InviteLink = "invite_link";
	public const string Invoice = "invoice";
	public const string InvoicePayload = "invoice_payload";
	public const string IpAddress = "ip_address";
	public const string IsAnimated = "is_animated";
	public const string IsAnonymous = "is_anonymous";
	public const string IsAutomaticForward = "is_automatic_forward";
	public const string IsBot = "is_bot";
	public const string IsClosed = "is_closed";
	public const string IsFlexible = "is_flexible";
	public const string IsForum = "is_forum";
	public const string IsMember = "is_member";
	public const string IsPersistent = "is_persistent";
	public const string IsPersonal = "is_personal";
	public const string IsPremium = "is_premium";
	public const string IsPrimary = "is_primary";
	public const string IsRevoked = "is_revoked";
	public const string IsTopicMessage = "is_topic_message";
	public const string IsVideo = "is_video";
	public const string JoinByRequest = "join_by_request";
	public const string JoinToSendMessages = "join_to_send_messages";
	public const string Keyboard = "keyboard";
	public const string Keywords = "keywords";
	public const string Label = "label";
	public const string Language = "language";
	public const string LanguageCode = "language_code";
	public const string LastErrorDate = "Last_error_date";
	public const string LastErrorMessage = "last_error_message";
	public const string LastName = "last_name";
	public const string LastSynchronizationErrorDate = "last_synchronization_error_date";
	public const string Latitude = "latitude";
	public const string LeftChatMember = "left_chat_member";
	public const string Length = "length";
	public const string Limit = "limit";
	public const string LinkedChatId = "linked_chat_id";
	public const string LivePeriod = "live_period";
	public const string Location = CommonNames.Location;
	public const string LoginUrl = "login_url";
	public const string Longitude = "longitude";
	public const string MaskPosition = "mask_position";
	public const string MaxConnections = "max_connections";
	public const string MaxTipAmount = "max_tip_amount";
	public const string Media = "media";
	public const string MediaGroupId = "media_group_id";
	public const string MemberLimit = "member_limit";
	public const string MenuButton = "menu_button";
	public const string Message = CommonNames.Message;
	public const string MessageAutoDeleteTime = "message_auto_delete_time";
	public const string MessageAutoDeleteTimerChanged = "message_auto_delete_timer_changed ";
	public const string MessageId = "message_id";
	public const string MessageText = "message_text";
	public const string MessageThreadId = "message_thread_id";
	public const string MigrateFromChatId = "migrate_from_chat_id";
	public const string MigrateToChatId = "migrate_to_chat_id";
	public const string MimeType = "mime_type";
	public const string Mpeg4Duration = "mpeg4_duration";
	public const string Mpeg4FileId = "mpeg4_file_id";
	public const string Mpeg4Height = "mpeg4_height";
	public const string Mpeg4Url = "mpeg4_url";
	public const string Mpeg4Width = "mpeg4_width";
	public const string MyChatMember = CommonNames.MyChatMember;
	public const string Name = "name";
	public const string NeedEmail = "need_email";
	public const string NeedName = "need_name";
	public const string NeedPhoneNumber = "need_phone_number";
	public const string NeedShippingAddress = "need_shipping_address";
	public const string NeedsRepainting = "needs_repainting";
	public const string NewChatMember = "new_chat_member";
	public const string NewChatMembers = "new_chat_members";
	public const string NewChatPhoto = "new_chat_photo";
	public const string NewChatTitle = "new_chat_title";
	public const string NextOffset = "next_offset";
	public const string Offset = "offset";
	public const string Ok = "ok";
	public const string OldChatMember = "old_chat_member";
	public const string OneTimeKeyboard = "one_time_keyboard";
	public const string OnlyIfBanned = "only_if_banned";
	public const string OpenPeriod = "open_period";
	public const string OptionIds = "option_ids";
	public const string Options = "options";
	public const string OrderInfo = "order_info";
	public const string ParseMode = "parse_mode";
	public const string PassportData = "passport_data";
	public const string Pay = "pay";
	public const string Payload = "payload";
	public const string PendingJoinRequestCount = "pending_join_request_count";
	public const string PendingUpdateCount = "pending_update_count";
	public const string Performer = "performer";
	public const string Permissions = "permissions";
	public const string ProtectContent = "protect_content";
	public const string PremiumAnimation = "premium_animation";
	public const string PhoneNumber = "phone_number";
	public const string Photo = CommonNames.Photo;
	public const string PhotoFileId = "photo_file_id";
	public const string PhotoHeight = "photo_height";
	public const string Photos = "photos";
	public const string PhotoSize = "photo_size";
	public const string PhotoUrl = "photo_url";
	public const string PhotoWidth = "photo_width";
	public const string PinnedMessage = "pinned_message";
	public const string Point = "point";
	public const string Poll = CommonNames.Poll;
	public const string PollAnswer = CommonNames.PollAnswer;
	public const string PollId = "poll_id";
	public const string Position = "position";
	public const string PostCode = "post_code";
	public const string PreCheckoutQuery = CommonNames.PreCheckoutQuery;
	public const string Prices = "prices";
	public const string ProviderData = "provider_data";
	public const string ProviderPaymentChargeId = "provider_payment_charge_id";
	public const string ProviderToken = "provider_token";
	public const string ProximityAlertRadius = "proximity_alert_radius";
	public const string ProximityAlertTriggered = "proximity_alert_triggered";
	public const string Query = "query";
	public const string Question = "question";
	public const string RemoveKeyboard = "remove_keyboard";
	public const string Rights = "rights";
	public const string ReplyMarkup = "reply_markup";
	public const string ReplyToMessage = "reply_to_message";
	public const string ReplyToMessageId = "reply_to_message_id";
	public const string RequestChat = "request_chat";
	public const string RequestContact = "request_contact";
	public const string RequestId = "request_id";
	public const string RequestLocation = "request_location";
	public const string RequestPoll = "request_poll";
	public const string RequestUser = "request_user";
	public const string RequestWriteAccess = "request_write_access";
	public const string ResizeKeyboard = "resize_keyboard";
	public const string ResultId = "result_id";
	public const string Result = "result";
	public const string Results = "results";
	public const string RetryAfter = "retry_after";
	public const string RevokeMessages = "revoke_messages";
	public const string ReverseSide = "reverse_side";
	public const string Scale = "scale";
	public const string Score = "score";
	public const string Scope = "scope";
	public const string Secret = "secret";
	public const string SecretToken = "secret_token";
	public const string Selective = "selective";
	public const string Selfie = "selfie";
	public const string SendEmailToProvider = "send_email_to_provider";
	public const string SenderChat = "sender_chat";
	public const string SenderChatId = "sender_chat_id";
	public const string SendPhoneNumberToProvider = "send_phone_number_to_provider";
	public const string SetName = "set_name";
	public const string ShippingAddress = "shipping_address";
	public const string ShippingOptionId = "shipping_option_id";
	public const string ShippingOptions = "shipping_options";
	public const string ShippingQuery = CommonNames.ShippingQuery;
	public const string ShippingQueryId = "shipping_query_id";
	public const string ShowAlert = "show_alert";
	public const string ShortDescription = "short_description";
	public const string SlowModeDelay = "slow_mode_delay";
	public const string SmallFileId = "small_file_id";
	public const string SmallFileUniqueId = "small_file_unique_id";
	public const string Source = "source";
	public const string StartDate = "start_date";
	public const string StartParameter = "start_parameter";
	public const string State = "state";
	public const string Status = "status";
	public const string Sticker = CommonNames.Sticker;
	public const string StickerFileId = "sticker_file_id";
	public const string StickerFormat = "sticker_format";
	public const string Stickers = "stickers";
	public const string StickerSetName = "sticker_set_name";
	public const string StickerType = "sticker_type";
	public const string StreetLine1 = "street_line1";
	public const string StreetLine2 = "street_line2";
	public const string SuccessfulPayment = "successful_payment";
	public const string SuggestedTipAmounts = "suggested_tip_amounts";
	public const string SupergroupChatCreated = "supergroup_chat_created";
	public const string SupportsInlineQueries = "supports_inline_queries";
	public const string SupportsStreaming = "supports_streaming";
	public const string SwitchInlineQuery = "switch_inline_query";
	public const string SwitchInlineQueryCurrentChat = "switch_inline_query_current_chat";
	public const string SwitchPmParameter = "switch_pm_parameter";
	public const string SwitchPmText = "switch_pm_text";
	public const string TelegramPaymentChargeId = "telegram_payment_charge_id";
	public const string Text = "text";
	public const string TextEntities = "text_entities";
	public const string Thumbnail = "thumbnail";
	public const string ThumbnailHeight = "thumbnail_height";
	public const string ThumbnailMimeType = "thumbnail_mime_type";
	public const string ThumbnailUrl = "thumbnail_url";
	public const string ThumbnailWidth = "thumbnail_width";
	public const string Timeout = "timeout";
	public const string Title = "title";
	public const string TotalAmount = "total_amount";
	public const string TotalCount = "total_count";
	public const string TotalVoterCount = "total_voter_count";
	public const string Translation = "translation";
	public const string Traveler = "traveler";
	public const string Type = "type";
	public const string UntilDate = "until_date";
	public const string UpdateId = "update_id";
	public const string Url = "url";
	public const string UseIndependentChatPermissions = "use_independent_chat_permissions";
	public const string User = "user";
	public const string UserAdministratorRights = "user_administrator_rights";
	public const string UserChatId = "user__chat_id";
	public const string UserId = "user_id";
	public const string UserIsBot = "user_is_bot";
	public const string UserIsPremium = "user_is_premium";
	public const string Username = "username";
	public const string Users = "users";
	public const string UserShared = "user_shared";
	public const string Value = "value";
	public const string Vcard = "vcard";
	public const string Venue = CommonNames.Venue;
	public const string ViaBot = "via_bot";
	public const string Video = CommonNames.Video;
	public const string VideoChatEnded = "video_chat_ended";
	public const string VideoChatParticipantsInvited = "video_chat_participants_invited";
	public const string VideoChatScheduled = "video_chat_scheduled ";
	public const string VideoChatStarted = "video_chat_started";
	public const string VideoDuration = "video_duration";
	public const string VideoFileId = "video_file_id";
	public const string VideoHeight = "video_height";
	public const string VideoNote = "video_note";
	public const string VideoUrl = "video_url";
	public const string VideoWidth = "video_width";
	public const string Voice = CommonNames.Voice;
	public const string VoiceDuration = "voice_duration";
	public const string VoiceFileId = "voice_file_id";
	public const string VoiceUrl = "voice_url";
	public const string VoterCount = "voter_count";
	public const string Watcher = "watcher";
	public const string WebApp = CommonNames.WebApp;
	public const string WebAppData = "web_app_data";
	public const string WebAppQueryId = "web_app_query_id";
	public const string Width = "width";
	public const string WriteAccessAllowed = "write_access_allowed";
	public const string XShift = "x_shift";
	public const string YShift = "y_shift";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
