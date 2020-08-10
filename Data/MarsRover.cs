using System;
using System.Text.Json.Serialization;

namespace MarsRoverHeneghan
{
    public class MarsRoverCamera
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("rover_id")]
        public int RoverID { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
    }
}
