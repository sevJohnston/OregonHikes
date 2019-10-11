using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OregonHikes.Models;

namespace OregonHikes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()    //view for the home page
        {
            return View();
        }

        public IActionResult About()    //view for the about/history page
        {
            return View("About");
        }

        [HttpGet]
        public ViewResult ReviewForm()     //default constructor
        {
            return View("ReviewForm");
        }
        //overloaded constructor
        [HttpPost]
        public ViewResult ReviewForm(UserReviews userReviews)   //adds a review to the list, thanks the user
        {
            Repository.AddResponse(userReviews);
            return View("Submitted", userReviews);
        }

        public ViewResult HikeReviews()     
        {
            return View(Repository.reviews);
        }

        public IActionResult Contact()      //view for the contact page
        {
            return View("Contact");
        }

        public ViewResult Resources()       //view for the resources page
        {
            return View("Resources");
        }

        public ViewResult Books()       //view for the print resources page
        {
            return View("Books");
        }

        public ViewResult Links()       //view for the online resources pages
        {
            return View("Links");
        }

        public IActionResult Privacy()      //view for the default privacy page
        {
            return View();
        }

        //not sure what this method does-- default method
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
