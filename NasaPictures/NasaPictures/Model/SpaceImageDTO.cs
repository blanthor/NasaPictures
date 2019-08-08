using System;
using Newtonsoft.Json;

namespace NasaPictures.Model
{
    public class SpaceImageDTO
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        [JsonProperty("hdurl")]
        public string HdUrl { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("service_version")]
        public string Version { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

    }
}
