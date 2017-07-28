using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace CarConfigurator.Frontend.Forms.Models
{
    public class CarConfiguration
    {
        [JsonProperty("make")]
        public string Make { get; set; }
        [JsonProperty("body-style")]
        public string BodyStyle { get; set; }
        [JsonProperty("wheel-base")]
        public double WheelBase { get; set; }
        [JsonProperty("engine-size")]
        public int EngineSize { get; set; }
        [JsonProperty("horsepower")]
        public int HorsePower { get; set; }
        [JsonProperty("peak-rpm")]
        public int PeakRpm { get; set; }
        [JsonProperty("highway-mpg")]
        public int HighwayMpg { get; set; }
    }
}
