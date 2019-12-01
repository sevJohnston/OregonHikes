using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OregonHikes.Models;
using OregonHikes.Repositories;

namespace OregonHikes.Controllers
{
    public class HomeController : Controller
    {
        IHikeRepository repo;
        public HomeController(IHikeRepository r)
        {
            repo = r;
        }

        public IActionResult Index()    //using ViewBag and ViewData to send info from controller to index view
        {
            List<Hike> hikes = Repository.Hikes;        
            ViewData["newestHike"] = hikes[hikes.Count - 1].TrailName;  //the hikes sort by region before this is figured out, screwing up the newest hike!
            ViewBag.hikeCount = hikes.Count;
            return View(hikes);
        }

        public IActionResult About()    //view for the about/history page
        {
            return View("About");
        }

        public IActionResult AddHike()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddHike(string trailName, string region, string description)
        {
            Hike hike = new Hike { TrailName = trailName, Region = region, Description = description };
            Repository.AddHike(hike);

            return RedirectToAction("Hikes");
        }
       
        public IActionResult ReviewForm(string trailName)
        {
            return View("ReviewForm", HttpUtility.HtmlDecode(trailName));
        }

        [HttpPost]
        public RedirectToActionResult ReviewForm(string trailName, string userName, string review)
        {
            Hike hike = Repository.GetHikeByTrailName(trailName);
            UserReview userReview = new UserReview { Review = review};
            hike.UserReviews.Add(userReview);
            
            return RedirectToAction("Hikes");
        }       

        public IActionResult People()
        {
            List<Person> people = Repository.People;
            people.Sort((p1, p2) => string.Compare(p1.PeopleName, p2.PeopleName, StringComparison.Ordinal));
            return View(people);
        }

        public IActionResult Hikes()        // see if the name change messes it up!
        {
            List<Hike> hikes = Repository.Hikes;
            hikes.Sort((h1, h2) => string.Compare(h1.Region, h2.Region, StringComparison.Ordinal));
            return View(hikes);
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
