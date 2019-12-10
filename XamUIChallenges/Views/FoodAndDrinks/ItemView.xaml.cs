using MagicGradients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

            Appearing += ItemView_Appearing;
        }

        async void ItemView_Appearing(object sender, EventArgs e)
        {
            await Task.WhenAll(
                Image.FadeTo(1, 1000, easing: Easing.SinInOut),
                Image.TranslateTo(0, 0, 1000, easing: Easing.SinInOut),
                lblPrice.TranslateTo(0, 0, 700, Easing.SinInOut),
                btnAdd.TranslateTo(0, 0, 700, Easing.SinInOut)
                );
        }
    }
}