using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XamUIChallenges
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new Xamarin.Forms.NavigationPage(new Views.MainView())
            {
                BarBackgroundColor = Color.FromHex("fafaf9")
            };
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(navPage, false);
            navPage.On<iOS>().SetUseSafeArea(true);
            navPage.On<iOS>().SetHideNavigationBarSeparator(true);
            MainPage = navPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
