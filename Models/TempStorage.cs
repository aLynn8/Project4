using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Aubrey Farnbach (Wright) Section 2 Group 1

namespace Project4.Models
{
    public class TempStorage
    {
        public TempStorage()
        {
        }

        //Creates empty list to store movie data
        private static List<UserRestaurant> applications = new List<UserRestaurant>();

        //Necessary to itterate through
        public static IEnumerable<UserRestaurant> Applications => applications;

        //Adds application to list
        public static void AddApplication(UserRestaurant application)
        {
            applications.Add(application);
        }
    }
}
