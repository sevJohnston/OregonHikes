using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OregonHikes.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OregonHikes.Controllers
{
    public class DemoController : Controller
    {
        // GET: /<controller>/
        public ViewResult DemoIndex()
        {
            ViewBag.Message = "Hello, this is the DemoIndex";
            return View();
        }
        
        public IActionResult RedirectDemo()
        {
            ViewBag.Message = "Hello, this is the RedirectDemo view";
            return View();
        }

        /*could not get this to work:/
        public RedirectToActionResult RedirectDemo(string message)
        {
            ViewBag.Message = "Redirected message to ResultDemo";
            return RedirectToAction("ResultDemo");
        }
        */
        
        public String StringDemo()
        {
            return "This is a StringDemo";
        }

        public ContentResult DemoTest(string myString)
        {
            return Content("Hello, this is a ContentResult demo!");
        }

       public JsonResult ResultDemo(string message)
        {
            return Json(message= "Hello, this is a JsonResult demo.");
        }

    }
}
