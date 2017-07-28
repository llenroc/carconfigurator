using System;
using System.Threading.Tasks;
using CarConfigurator.Frontend.Forms.Models;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;

namespace CarConfigurator.Frontend.Forms.Services
{
    public class PricePredictionService
    {
        const string apiKey = "WzbuW+hgAMDlXWJ/rxxj63UGaoAJvkhG3iy+qVydz8SN0jN3Ik45Xq3pQ36j+P59bWH/npXi8t+aHC+L5FwWsQ==";

        private HttpClient httpClient = new HttpClient();

        public async Task<double> PredictPrice(CarConfiguration configuration)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            var scoreRequest = new CarPriceScoreRequest(configuration);
            var json = JsonConvert.SerializeObject(scoreRequest);
            var content = new StringContent(json);

            var response = await httpClient.PostAsync("https://ussouthcentral.services.azureml.net/workspaces/8a54fb6daa8b4ce5a77212d3976d677f/services/67a5b6c0e92b424c8e4dad7048ace755/execute?api-version=2.0&format=swagger", content);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<CarPriceScoreResult>(jsonResult);
                return Convert.ToDouble(result.Results.PriceEstimation.First().ScoredLabels);
            }


            return 0;
        }
    }
}
