using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamUIChallenges.Interfaces;
using FDM = XamUIChallenges.Models.FoodAndDrinks;

namespace XamUIChallenges.ViewModels.FoodAndDrinks
{
    public class ItemViewModel : BaseViewModel
    {
        public FDM.Item Item { get; }

        public ItemViewModel(INavigation navigation, FDM.Item item) : base(navigation)
        {
            Item = item;
            if (Device.RuntimePlatform != Device.UWP)
            {
                DependencyService.Get<IStatusBarStyleManager>().SetStatusBarColor(Item.LightColor);
            }
        }
    }
}
