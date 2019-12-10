using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamUIChallenges.Models.FoodAndDrinks
{
    /// <summary>
    /// Item model
    /// </summary>
    public class Item : BaseModel
    {
        string header;
        public string Header
        {
            get => header;
            set => SetProperty(ref header, value);
        }

        string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        string desc;
        public string Description
        {
            get => desc;
            set => SetProperty(ref desc, value);
        }

        decimal price;
        public decimal Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }

        string image;
        public string Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }

        Color lightColor;
        public Color LightColor
        {
            get => lightColor;
            set => SetProperty(ref lightColor, value);
        }

        Color darkColor;
        public Color DarkColor
        {
            get => darkColor;
            set => SetProperty(ref darkColor, value);
        }

        public ImageSource ImageSource
        {
            get => ImageSource.FromUri(new Uri(Image));
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
