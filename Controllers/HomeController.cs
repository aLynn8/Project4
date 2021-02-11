using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//Aubrey Farnbach (wright) section 2 group 1
namespace Project4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Loads Index page
        public IActionResult Index()
        {
            //Creates string to house list with restaurant details
            List<string> restaurantList = new List<string>();

            //Formats and adds strings to list
            foreach(BestRestaurant r in BestRestaurant.GetRestaurants())
            {
                //Default value for null or empty Favorite Dish
                if (String.IsNullOrEmpty(r.FavoriteDish))
                {
                    r.FavoriteDish = "It's all tasty!";
                }

                //Default value for null or empty Website
                if (String.IsNullOrEmpty(r.Website))
                {
                    r.Website = "Coming Soon.";
                }

                //Creates strings and adds them to the list
                restaurantList.Add(string.Format("{1}. {0} | {2} | Contact: {3} {4} {5}", r.RestaurantName, r.Rank, r.FavoriteDish, r.RestaurantPhone, r.Website, r.Address));
            }

            //Returns the view and passes the list in as a parameter
            return View(restaurantList);
        }
        
        //Returns view with all restaurants enterred by user that session, passing in the restaurant items in TempStorage
        public IActionResult AllRestaurants()
        {
            return View(TempStorage.Applications);
        }

        //Returns AddRestaurants view on a Get requuest
        [HttpGet]
        public IActionResult AddRestaurants()
        {
            return View();
        }

        //Returns Confirmation with the appResponse data from the form
        [HttpPost]
        public IActionResult AddRestaurants(UserRestaurant appResponse)
        {
            //Default value for null or empty Favorite Dish
            if (String.IsNullOrEmpty(appResponse.FavoriteDish))
            {
                appResponse.FavoriteDish = "It's all tasty!";
            }

            //adds apppResponse data to TempStorage
            TempStorage.AddApplication(appResponse);

            //Passes in form data
            return View("Confirmation", appResponse);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
