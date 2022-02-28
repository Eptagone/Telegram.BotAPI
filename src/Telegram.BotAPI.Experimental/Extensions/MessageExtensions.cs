// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableTypes
{

    public static class MessageExtensions
    {
        public static DateTime GetDatetime(this Message message) => DateTime.UnixEpoch.AddSeconds(message.Date);

        public static DateTime GetEditDatetime(this Message message)
        {
            var editDate = Convert.ToDouble(message.EditDate);
            return DateTime.UnixEpoch.AddSeconds(editDate);
        }

        public static DateTime GetForwardDatetime(this Message message)
        {
            var forwardDate = Convert.ToDouble(message.ForwardDate);
            return DateTime.UnixEpoch.AddSeconds(forwardDate);
        }

        public static MessageType GetMessageType(this Message message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            else if (!string.IsNullOrEmpty(message.Text))
            {
                return MessageType.Text;
            }
            else if (message.Animation != null)
            {
                return MessageType.Animation;
            }
            else if (message.Audio != null)
            {
                return MessageType.Audio;
            }
            else if (message.Document != null)
            {
                return MessageType.Document;
            }
            else if (message.Photo != null)
            {
                return MessageType.Photo;
            }
            else if (message.Sticker != null)
            {
                return MessageType.Sticker;
            }
            else if (message.Video != null)
            {
                return MessageType.Video;
            }
            else if (message.VideoNote != null)
            {
                return MessageType.VideoNote;
            }
            else if (message.Voice != null)
            {
                return MessageType.Voice;
            }
            else if (message.Contact != null)
            {
                return MessageType.Contact;
            }
            else if (message.Dice != null)
            {
                return MessageType.Dice;
            }
            else if (message.Game != null)
            {
                return MessageType.Game;
            }
            else if (message.Poll != null)
            {
                return MessageType.Poll;
            }
            else if (message.Venue != null)
            {
                return MessageType.Venue;
            }
            else if (message.Location != null)
            {
                return MessageType.Location;
            }
            else if (message.Invoice != null)
            {
                return MessageType.Invoice;
            }
            else if (message.SuccessfulPayment != null)
            {
                return MessageType.SuccessfulPayment;
            }
            else
            {
                return MessageType.Unknown;
            }
        }
    }
}
