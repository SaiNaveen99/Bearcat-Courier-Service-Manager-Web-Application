using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace BearcatExpress.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult FAQs()
        {
            return View();
        }
        public IActionResult Track()
        {
            return View("Track");
        }

        public IActionResult TrackOrderResult()
        {
            return View("TrackOrderResult");
        }

    }
}
