using System;
using Xamarin.Forms;

namespace CarConfigurator.Frontend.Forms.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");
        }

        async void BeginButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MakeSelectionPage());
        }

        void MoreAzureMlButton_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://azure.microsoft.com/en-us/services/machine-learning/"));
        }

        void MoreXamarinButton_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.xamarin.com/platform"));
        }
    }
}
