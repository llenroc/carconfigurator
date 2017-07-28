using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CarConfigurator.Frontend.Forms.Pages
{
    public partial class BodySelectionPage : ContentPage
    {
        public BodySelectionPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");

            var bodyStyles = new string[] { "sedan", "hatchback", "convertible", "wagon" };
            BodyStylePicker.ItemsSource = bodyStyles;
            BodyStylePicker.SelectedIndex = 0;

            var wheelBases = new double[] { 88.6 };
            WheelBasePicker.ItemsSource = wheelBases;
            WheelBasePicker.SelectedIndex = 0;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Restore selection
            BodyStylePicker.SelectedItem = App.CurrentCarConfiguration.BodyStyle != null ? App.CurrentCarConfiguration.BodyStyle : BodyStylePicker.SelectedItem;
            WheelBasePicker.SelectedItem = App.CurrentCarConfiguration.WheelBase != 0 ? App.CurrentCarConfiguration.WheelBase : WheelBasePicker.SelectedItem;
        }

        async void FinishButton_Clicked(object sender, System.EventArgs e)
        {
            App.CurrentCarConfiguration.BodyStyle = (string)BodyStylePicker.SelectedItem;
            App.CurrentCarConfiguration.WheelBase = (double)WheelBasePicker.SelectedItem;

            await Navigation.PushAsync(new ResultPage());
        }
    }
}
