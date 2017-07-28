using CarConfigurator.Frontend.Forms.Pages;
using Xamarin.Forms;
using CarConfigurator.Frontend.Forms.Services;
using CarConfigurator.Frontend.Forms.Models;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Distribute;

namespace CarConfigurator.Frontend.Forms
{
    public partial class App : Application
    {
        public static CarConfiguration CurrentCarConfiguration;

        public App()
        {
            InitializeComponent();

            CurrentCarConfiguration = new CarConfiguration();

            var navigationPage = new NavigationPage(new MainPage());
            navigationPage.BarBackgroundColor = Color.FromHex("#403D58");
            navigationPage.BarTextColor = Color.White;
            navigationPage.BackgroundColor = Color.FromHex("#F2EFEA");

            MainPage = navigationPage;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start(
                "ios=53312bba-2752-4a8c-b2b3-982c99f3660f;",
                typeof(Analytics),
                typeof(Crashes),
                typeof(Distribute));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
