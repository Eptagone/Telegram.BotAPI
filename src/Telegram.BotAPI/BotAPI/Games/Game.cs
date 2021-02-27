// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Games
{
    /// <summary>This object represents a game. Use BotFather to create and edit games, their short names will act as unique identifiers.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Game : IEquatable<Game>
    {
        /// <summary>Title of the game.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Description of the game.</summary>
        [JsonPropertyName(PropertyNames.Description)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Photo that will be displayed in the game message in chats.</summary>
        [JsonPropertyName(PropertyNames.Photo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize[] Photo { get; set; }
        /// <summary>Optional. Brief description of the game or high scores included in the game message. Can be automatically edited to include current high scores for the game when the bot calls setGameScore, or manually edited using editMessageText. 0-4096 characters.</summary>
        [JsonPropertyName(PropertyNames.Text)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>Optional. Special entities that appear in text, such as usernames, URLs, bot commands, etc.</summary>
        [JsonPropertyName(PropertyNames.TextEntities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] TextEntities { get; set; }
        /// <summary>Optional. Animation that will be displayed in the game message in chats. Upload via BotFather.</summary>
        [JsonPropertyName(PropertyNames.Animation)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Animation Animation { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as Game);
        }

        public bool Equals(Game other)
        {
            return other != null &&
                   Title == other.Title &&
                   Description == other.Description &&
                   EqualityComparer<PhotoSize[]>.Default.Equals(Photo, other.Photo) &&
                   Text == other.Text &&
                   EqualityComparer<MessageEntity[]>.Default.Equals(TextEntities, other.TextEntities) &&
                   EqualityComparer<Animation>.Default.Equals(Animation, other.Animation);
        }

        public override int GetHashCode()
        {
            int hashCode = -817216167;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize[]>.Default.GetHashCode(Photo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageEntity[]>.Default.GetHashCode(TextEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<Animation>.Default.GetHashCode(Animation);
            return hashCode;
        }

        public static bool operator ==(Game left, Game right)
        {
            return EqualityComparer<Game>.Default.Equals(left, right);
        }

        public static bool operator !=(Game left, Game right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
