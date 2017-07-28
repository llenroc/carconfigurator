using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CarConfigurator.Frontend.Forms.Models
{
    public class CarPriceScoreResult
    {
        public Results Results { get; set; }
    }

    public class Priceestimation
    {
        [JsonProperty("Scored Labels")]
        public string ScoredLabels { get; set; }
    }

    public class Results
    {
        public List<Priceestimation> PriceEstimation { get; set; }
    }
}
