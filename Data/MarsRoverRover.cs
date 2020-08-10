using System;
using System.Text.Json.Serialization;

namespace MarsRoverHeneghan
{
    public class MarsRoverRover
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("landing_date")]
        public DateTime LandingDate { get; set; }

        [JsonPropertyName("launch_date")]
        public DateTime LaunchDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
