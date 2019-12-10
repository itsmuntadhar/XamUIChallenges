using MagicGradients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamUIChallenges.Interfaces;

namespace XamUIChallenges.Views.FoodAndDrinks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemView : ContentPage
    {
        public ItemView(Models.FoodAndDrinks.Item item)
        {
            InitializeComponent();
            BindingContext = new ViewModels.FoodAndDrinks.ItemViewModel(Navigation, item);
            GradientView.GradientSource = new LinearGradient
            {
                Angle = 0,
                Stops = new List<GradientStop>
                {
                    new GradientStop { Color = item.LightColor, Offset = 0 },
                    new GradientStop { Color = item.DarkColor, Offset = 0.4f },
                }
            };
            if (Device.RuntimePlatform != Device.UWP)
            {
                DependencyService.Get<IStatusBarStyleManager>().SetStatusBarColor(item.LightColor);
            }

            Appearing += ItemView_Appearing;
            //Disappearing += ItemView_Disappearing;
        }

        private void ItemView_Disappearing(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                DependencyService.Get<IStatusBarStyleManager>().SetStatusBarColor(Color.FromHex("fafaf9"));
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                DependencyService.Get<IStatusBarStyleManager>().SetStatusBarColor(Color.FromHex("303F9F"));
            }
        }

        async void ItemView_Appearing(object sender, EventArgs e)
        {
            await Task.WhenAll(
                Image.FadeTo(1, 1000, Easing.SinInOut),
                Image.TranslateTo(0, 0, 1000, Easing.SinInOut),
                lblPrice.TranslateTo(0, 0, 700, Easing.SinInOut),
                btnAdd.TranslateTo(0, 0, 700, Easing.SinInOut)
                );
        }
    }
}