using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamUIChallenges.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand NavigationCommand { get; }

        public MainViewModel(INavigation navigation) : base(navigation)
        {
            Title = "UI Challenges";
            NavigationCommand = new Command<string>(Navigate);
        }

        async void Navigate(string param)
        {
            switch (param.ToUpper())
            {
                case "FOODANDDRINKS":
                    await Navigation.PushAsync(new Views.FoodAndDrinks.HomeView());
                    break;
                default:
                    break;
            }
        }
    }
}
