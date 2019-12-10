using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using FDM = XamUIChallenges.Models.FoodAndDrinks;

namespace XamUIChallenges.ViewModels.FoodAndDrinks
{
    public class HomeViewModel : BaseViewModel
    {
        List<FDM.Item> items;
        public List<FDM.Item> Items
        {
            get => items;
            set => SetProperty(ref items, value);
        }

        public ICommand ItemDetailsCommand { get; }

        public ICommand AboutCommand { get; }

        public HomeViewModel(INavigation navigation) : base(navigation)
        {
            Title = "Food And Drinks";
            ItemDetailsCommand = new Command<FDM.Item>(ItemDetails);
            AboutCommand = new Command(About);
            LoadItems();
        }

        async void LoadItems()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            Items = await Services.FoodAndDrinks.DataService.GetItems();
            IsBusy = false;
        }

        /// <summary>
        /// View a specific item
        /// </summary>
        /// <param name="item">The item</param>
        async void ItemDetails(FDM.Item item)
        {
            if (IsBusy)
                return;
            IsBusy = true;
            await Navigation.PushModalAsync(new Views.FoodAndDrinks.ItemView(item));
            IsBusy = false;
        }

        async void About()
        {
            await Navigation.PushModalAsync(new Views.FoodAndDrinks.AboutView());
        }
    }
}
