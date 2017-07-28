using System;
using System.Collections.Generic;

using Xamarin.Forms;
using CarConfigurator.Frontend.Forms.Services;

namespace CarConfigurator.Frontend.Forms.Pages
{
    public partial class ResultPage : ContentPage
    {
        private PricePredictionService pricePredictionService;

        public ResultPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");

            pricePredictionService = new PricePredictionService();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            LoadingIndicator.IsRunning = true;
            var predictedPrice = await pricePredictionService.PredictPrice(App.CurrentCarConfiguration);

            LoadingIndicator.IsRunning = false;
            PricePrediction.Text = $"$ {Math.Round(predictedPrice, 2)}";
        }

        public void MoreButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/azure/machine-learning/machine-learning-create-experiment"));
        }
    }
}