using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamUIChallenges.Interfaces;
using FDM = XamUIChallenges.Models.FoodAndDrinks;

namespace XamUIChallenges.ViewModels.FoodAndDrinks
{
    public class ItemViewModel : BaseViewModel
    {
        public FDM.Item Item { get; }

        public ICommand BackCommand { get; }

        public ItemViewModel(INavigation navigation, FDM.Item item) : base(navigation)
        {
            Item = item;
            BackCommand = new Command(Back);
        }

        async void Back()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                DependencyService.Get<IStatusBarStyleManager>().SetStatusBarColor(Color.White);
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                DependencyService.Get<IStatusBarStyleManager>().SetStatusBarColor(Color.FromHex("303F9F"));
            }
            await Navigation.PopModalAsync();
        }
    }
}
