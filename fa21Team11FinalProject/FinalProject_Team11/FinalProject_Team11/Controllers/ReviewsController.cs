using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject_Team11.DAL;
using FinalProject_Team11.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject_Team11.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reviews.ToListAsync());
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }
        // GET: Reviews/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create(Int32 PropertyID)
        {
            List<Reservation> Reservations = _context.Reservations.Where(r => r.Property.PropertyID == PropertyID && r.Order.User.UserName == User.Identity.Name && r.Order.OrderStatus == OrderStatus.Complete).ToList();
            if (Reservations.Count() == 0)
            {
                return View("Error", new String[] { "You haven't been to this property yet!" });
            }
            List<Review> Reviews = _context.Reviews.Where(r => r.User.UserName == User.Identity.Name && r.Property.PropertyID == PropertyID).ToList();
            if (Reviews.Count() > 0)
            {
                return View("Error", new String[] { "You have reviewed this property!" });
            }
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Review review)
        {
            //Associate the review with Users and Properties
            review.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            
            //review.Property = _context.Properties.FirstOrDefault(p => p.PropertyID == review.Property.PropertyID);

            //make sure all properties are valid
            if (ModelState.IsValid == false)
            {
                return View(review);
            }

            //if code gets this far, add the registration to the database
            _context.Add(review);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,rating,TextReivew,DisputeReview")] Review review)
        {
            if (id != review.ReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.ReviewID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }

        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.ReviewID == id);
        }
        public IActionResult ReviewsIndex(int? id)
        {
            List<Review> reviews = _context.Reviews.Where(r => r.Property.PropertyID == id).ToList();
            ViewBag.PropertyAddress = _context.Properties.Find(id).PropertyAddress;
            ViewBag.PropertyRatings = _context.Properties.Find(id).PropertyRating;
            return View(reviews);
        }
    }
}
