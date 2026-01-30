using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneApiJD.Services
{
    public class RestaurantPickerService
    {
        private static readonly string[] Pizza =
        {
            "Domino's", "Pizza Hut", "Little Caesars", "Papa Johns", "Round Table"
        };

        private static readonly string[] Burger =
        {
            "In-N-Out", "Five Guys", "Wendy's", "McDonald's", "Burger King"
        };

        private static readonly string[] Mexican =
        {
            "Taco Bell", "Chipotle", "El Pollo Loco", "Del Taco", "Rubio's"
        };

        public string Pick(string category)
        {
            string clean = category.ToLower();

            if (clean == "pizza") return PickFrom(Pizza);
            if (clean == "burger") return PickFrom(Burger);
            if (clean == "mexican") return PickFrom(Mexican);

            return "Error: choose a category: pizza, burger, or mexican.";
        }

        private string PickFrom(string[] list)
        {
            System.Random rand = new System.Random();
            int index = rand.Next(0, list.Length);
            return list[index];
        }
    }
}