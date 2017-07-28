using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;

namespace CarConfigurator.Frontend.Forms.Pages
{
    public partial class MakeSelectionPage : ContentPage
    {
        public MakeSelectionPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");

            // Prepare UI
            var makes = new string[] { "BMW", "Toyota", "Alfa-Romero", "Audi", "Chevrolet", "Dodge", "Honda", "Isuzu", "Jaguar", "Mazda", "Mercedes-Benz", "Mitsubishi", "Nissan" };
            MakeListView.ItemsSource = makes;
            MakeListView.SelectedItem = makes[0];
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Restore selection
            MakeListView.SelectedItem = App.CurrentCarConfiguration.Make != null ? App.CurrentCarConfiguration.Make : MakeListView.SelectedItem;
        }

        async void NextButton_Clicked(object sender, System.EventArgs e)
        {
            // Set selection and navigate to next page
            App.CurrentCarConfiguration.Make = (string)MakeListView.SelectedItem;
            await Navigation.PushAsync(new MotorSelectionPage());
        }
    }
}
