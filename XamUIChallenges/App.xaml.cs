using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamUIChallenges
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new Views.MainView());
            NavigationPage.SetHasNavigationBar(navPage, false);
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
