using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CarConfigurator.Frontend.Forms.Pages
{
    public partial class MotorSelectionPage : ContentPage
    {
        public MotorSelectionPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");

            // Prepare UI
            var fuelTypes = new string[] { "gas", "diesel" };
            FuelTypePicker.ItemsSource = fuelTypes;
            FuelTypePicker.SelectedIndex = 0;

            var engineSizes = new int[] { 90, 130, 152, 200 };
            EngineSizePicker.ItemsSource = engineSizes;
            EngineSizePicker.SelectedIndex = 0;

            var horsePowers = new int[] { 68, 76, 90, 110 };
            HorsePowerPicker.ItemsSource = horsePowers;
            HorsePowerPicker.SelectedIndex = 0;

            var peakRpms = new int[] { 4250, 5000, 5500, 5800, 6000 };
            PeakRpmPicker.ItemsSource = peakRpms;
            PeakRpmPicker.SelectedIndex = 0;

            var highwayMpgs = new int[] { 16, 38, 22, 26, 27, 30, 32, 41, 50 };
            HighwayMpgPicker.ItemsSource = highwayMpgs;
            HighwayMpgPicker.SelectedIndex = 0;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Restore selection
            //FuelTypePicker.SelectedItem = App.CurrentCarConfiguration.FuelType != null ? App.CurrentCarConfiguration.FuelType : FuelTypePicker.SelectedItem;
            EngineSizePicker.SelectedItem = App.CurrentCarConfiguration.EngineSize != 0 ? App.CurrentCarConfiguration.EngineSize : EngineSizePicker.SelectedItem;
            HorsePowerPicker.SelectedItem = App.CurrentCarConfiguration.HorsePower != 0 ? App.CurrentCarConfiguration.HorsePower : HorsePowerPicker.SelectedItem;
            PeakRpmPicker.SelectedItem = App.CurrentCarConfiguration.PeakRpm != 0 ? App.CurrentCarConfiguration.PeakRpm : PeakRpmPicker.SelectedItem;
            HighwayMpgPicker.SelectedItem = App.CurrentCarConfiguration.HighwayMpg != 0 ? App.CurrentCarConfiguration.HighwayMpg : HighwayMpgPicker.SelectedItem;
        }

        async void NextButton_Clicked(object sender, System.EventArgs e)
        {
            // Set selection and navigate to next page
            //App.CurrentCarConfiguration.FuelType = FuelTypePicker.SelectedItem as string;
            App.CurrentCarConfiguration.EngineSize = (int)EngineSizePicker.SelectedItem;
            App.CurrentCarConfiguration.HorsePower = (int)HorsePowerPicker.SelectedItem;
            App.CurrentCarConfiguration.PeakRpm = (int)PeakRpmPicker.SelectedItem;
            App.CurrentCarConfiguration.HighwayMpg = (int)HighwayMpgPicker.SelectedItem;

            await Navigation.PushAsync(new BodySelectionPage());
        }
    }
}
