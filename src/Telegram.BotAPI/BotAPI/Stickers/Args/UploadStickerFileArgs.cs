using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>UploadStickerFile method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class UploadStickerFileArgs
    {
        /// <summary>User identifier of sticker file owner.</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int UserId { get; set; }
        /// <summary>Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px.</summary>
        [JsonPropertyName(PropertyNames.PngSticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputFile PngSticker { get; set; }
    }
}
