using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BearcatExpress.Models;

namespace BearcatExpress.Controllers
{
    public class OffersController : Controller
    {
        private ApplicationDbContext _context;

        public OffersController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Offers
        public IActionResult Index()
        {
            return View(_context.Offer.ToList());
        }

        // GET: Offers/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Offer offer = _context.Offer.Single(m => m.OfferID == id);
            if (offer == null)
            {
                return HttpNotFound();
            }

            return View(offer);
        }

        // GET: Offers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Offers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Offer offer)
        {
            if (ModelState.IsValid)
            {
                _context.Offer.Add(offer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(offer);
        }

        // GET: Offers/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Offer offer = _context.Offer.Single(m => m.OfferID == id);
            if (offer == null)
            {
                return HttpNotFound();
            }
            return View(offer);
        }

        // POST: Offers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Offer offer)
        {
            if (ModelState.IsValid)
            {
                _context.Update(offer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(offer);
        }

        // GET: Offers/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Offer offer = _context.Offer.Single(m => m.OfferID == id);
            if (offer == null)
            {
                return HttpNotFound();
            }

            return View(offer);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Offer offer = _context.Offer.Single(m => m.OfferID == id);
            _context.Offer.Remove(offer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
