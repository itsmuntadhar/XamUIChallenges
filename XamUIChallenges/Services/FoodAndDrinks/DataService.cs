using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FDM = XamUIChallenges.Models.FoodAndDrinks;

namespace XamUIChallenges.Services.FoodAndDrinks
{
    /// <summary>
    /// A data service, where items and others are normally get from an API.
    /// <para />
    /// For demo purposes, they're all here :3
    /// </summary>
    public static class DataService
    {
        static readonly List<FDM.Item> items = new List<FDM.Item>
        {
            new FDM.Item { Id = 0, Header = "ANTIOXIEND", Title = "Tomato", Image = "https://i.imgur.com/cRyWZDl.png", DarkColor = Color.FromHex("B71717"), LightColor = Color.FromHex("FA6453"), Price = 40, Description = "The tomato is the edible, often red, berry of the plant Solanum lycopersicum, commonly known as a tomato plant. The species originated in western South America and Central America. The Nahiatl" },
            new FDM.Item { Id = 1, Header = "ANTIOXIEND", Title = "Mangold", Image = "https://i.imgur.com/qJ0IKoG.png", DarkColor = Color.FromHex("498D2A"), LightColor = Color.FromHex("90CC76"), Price = 45, Description = "Consuming a diet rich in a wide variety of vegetables and fruits has been shown to lower heart disease risk factors, such as inflammation, high cholesterol and high blood pressure" },
        };

        /// <summary>
        /// Normally perform a web request...
        /// </summary>
        /// <returns>Task of List of Item</returns>
        public static Task<List<FDM.Item>> GetItems()
        {
            return Task.Run(() => 
            {
                return items;
            });
        }
    }
}
