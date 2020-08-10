using System;
using System.Text.Json.Serialization;

namespace MarsRoverHeneghan
{
    public class MarsRoverPicture
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("sol")]
        public int SOL { get; set; }

        [JsonPropertyName("camera")]
        public MarsRoverCamera Camera { get; set; }

        [JsonPropertyName("img_src")]
        public string ImgSrc { get; set; }

        public string ImageName { get; set; }

        [JsonPropertyName("earth_date")]
        public DateTime EarthDate { get; set; }

        [JsonPropertyName("rover")]
        public MarsRoverRover Rover { get; set; }

    }
}
