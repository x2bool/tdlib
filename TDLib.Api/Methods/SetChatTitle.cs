using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SetChatTitle : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "setChatTitle";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("title")]
        public string Title { get; set; }

    }

}