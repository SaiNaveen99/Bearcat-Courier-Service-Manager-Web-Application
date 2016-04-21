using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BearcatExpress.Models;

namespace BearcatExpress.Controllers
{
    public class ShippingAddressesController : Controller
    {
        private ApplicationDbContext _context;

        public ShippingAddressesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ShippingAddresses
        public IActionResult Index()
        {
            return View(_context.ShippingAddress.ToList());
        }

        // GET: ShippingAddresses/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ShippingAddress shippingAddress = _context.ShippingAddress.Single(m => m.AddressId == id);
            if (shippingAddress == null)
            {
                return HttpNotFound();
            }

            return View(shippingAddress);
        }

        // GET: ShippingAddresses/Create
        public IActionResult Create()
        {
            if(User.Identity.IsAuthenticated)
            {
                return View("Create");
            }
            else
            {
                return View("ShippingWithoutLogin");
            }
          
        }

        // POST: ShippingAddresses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ShippingAddress shippingAddress)
        {
            if (ModelState.IsValid)
            {
                _context.ShippingAddress.Add(shippingAddress);
                _context.SaveChanges();
                return RedirectToAction("ShipmentDetails");
            }
            return View(shippingAddress);
        }

        // GET: ShippingAddresses/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ShippingAddress shippingAddress = _context.ShippingAddress.Single(m => m.AddressId == id);
            if (shippingAddress == null)
            {
                return HttpNotFound();
            }
            return View(shippingAddress);
        }

        // POST: ShippingAddresses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ShippingAddress shippingAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Update(shippingAddress);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shippingAddress);
        }

        // GET: ShippingAddresses/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ShippingAddress shippingAddress = _context.ShippingAddress.Single(m => m.AddressId == id);
            if (shippingAddress == null)
            {
                return HttpNotFound();
            }

            return View(shippingAddress);
        }

        // POST: ShippingAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            ShippingAddress shippingAddress = _context.ShippingAddress.Single(m => m.AddressId == id);
            _context.ShippingAddress.Remove(shippingAddress);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ShipmentDetails()
        {
            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
