using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Aubrey Farnbach Section 2 Group 1

namespace Project4.Models
{
    public class BestRestaurant
    {
        // Used to set rank when it is first created
        public BestRestaurant(int rank)
        {
            Rank = rank;
        }

        public int Rank { get; } // read only
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's all tasty!"; //can be null
        public string Address { get; set; }
        public string? RestaurantPhone { get; set; } //can be null
        public string? Website { get; set; } = "Coming soon."; //can be null

        public static BestRestaurant[] GetRestaurants()
        {
            BestRestaurant r1 = new BestRestaurant(1)
            {
                RestaurantName = "Blue nile",
                FavoriteDish = "Red Lentils",
                Address = "1234 Lane",
                RestaurantPhone = "(123)456-789",
                Website = "BlueNile.com"
            };

            BestRestaurant r2 = new BestRestaurant(2)
            {
                RestaurantName = "Pita Pit",
                FavoriteDish = "Falafel Sandwich",
                Address = "1234 Lane",
                RestaurantPhone = "(123)456-789",
                Website = "PitaPit.com"
            };

            BestRestaurant r3 = new BestRestaurant(3)
            {
                RestaurantName = "Pizza Pie Cafe",
                FavoriteDish = null,
                Address = "1234 Lane",
                RestaurantPhone = "(123)456-789",
                Website = "PizzaPieCafe.com"
            };

            BestRestaurant r4 = new BestRestaurant(4)
            {
                RestaurantName = "Cup Bop",
                FavoriteDish = "Doochi Bop",
                Address = "1234 Lane",
                RestaurantPhone = "(123)456-789",
                Website = null
            };

            BestRestaurant r5 = new BestRestaurant(5)
            {
                RestaurantName = "Fat Daddy's Pizzeria",
                FavoriteDish = "Veggie",
                Address = "1234 Lane",
                RestaurantPhone = "(123)456-789",
                Website = "FatDaddyPizza.com"
            };

            return new BestRestaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
