using System;
using System.Collections.Generic;
namespace CarConfigurator.Frontend.Forms.Models
{
    public class CarPriceScoreRequest
    {
        public Inputs Inputs { get; set; }
        object GlobalParameters;

        public CarPriceScoreRequest(CarConfiguration carConfiguration)
        {
            Inputs = new Inputs();
            Inputs.Carconfig = new List<CarConfiguration>();
            Inputs.Carconfig.Add(carConfiguration);

            GlobalParameters = null;
        }
    }

    public class Inputs
    {
        public List<CarConfiguration> Carconfig { get; set; }
    }
}
