using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4.Models
{
    public class UserRestaurant
    {
        // Used to set rank when it is first created
        public string Name { get; set; }
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } //can be null
        public string? RestaurantPhone { get; set; } //can be null
    }
}