using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MarsRoverHeneghan
{
    public class MarsRover
    {
        [JsonIgnore]
        public IEnumerable<MarsRoverPicture> Photos { get; set; }

    }
}
