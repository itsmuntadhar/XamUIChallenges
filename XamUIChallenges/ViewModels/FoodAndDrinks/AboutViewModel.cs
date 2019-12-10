using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamUIChallenges.ViewModels.FoodAndDrinks
{
    public class AboutViewModel : BaseViewModel
    {
        private readonly string LINK = "https://dribbble.com/shots/8928476-Food-and-drinks-app";

        public ICommand BackCommand { get; }

        public AboutViewModel(INavigation navigation) : base(navigation)
        {
            Title = "About";
            BackCommand = new Command(Back);
        }

        async void Back()
        {
            await Navigation.PopModalAsync();
        }
    }
}
