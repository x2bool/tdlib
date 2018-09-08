using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetMapThumbnailFile : Function<File>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getMapThumbnailFile";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public Location Location { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("zoom")]
            public int Zoom { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("height")]
            public int Height { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("scale")]
            public int Scale { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }
        }
    }
}