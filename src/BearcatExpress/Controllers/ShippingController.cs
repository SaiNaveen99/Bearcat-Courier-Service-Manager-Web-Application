using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authentication;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using BearcatExpress.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BearcatExpress.Controllers
{
    public class ShippingController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shipping()
        {
           if (User.Identity.IsAuthenticated)
            {
                return View("Shipping");
            }
            else
            {
                return View("ShippingWithoutLogin");
            }
        }
        

     
        public IActionResult ShippingAddress()
        {
            
            return View("ShippingAddress");
        }
     
      //  [HttpPost]
        //public IActionResult ShippingAddress(ShippingAddress model)
        //{
          //  if(ModelState.IsValid)
            //{
              //  return View("ShipmentDetails");

            //}
        //}   
    }
}
