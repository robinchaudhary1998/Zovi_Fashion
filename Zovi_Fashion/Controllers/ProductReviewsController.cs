using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Zovi_Fashion.Data;
using Zovi_Fashion.Models;
using Microsoft.AspNetCore.Authorization;

namespace Zovi_Fashion.Controllers
{
    [Authorize]
    public class ProductReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MobileReviews
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ProductReviews.Include(m => m.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MobileReviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobileReview = await _context.ProductReviews
                .Include(m => m.Product)
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (mobileReview == null)
            {
                return NotFound();
            }

            return View(mobileReview);
        }

        // GET: MobileReviews/Create
        public IActionResult Create()
        {
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductName");
            return View();
        }

        // POST: MobileReviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewID,Name,Rating,ReviewText,ProductID,ReviewDate")] ProductReview productReview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductName", productReview.ProductID);
            return View(productReview);
        }

        // GET: MobileReviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productReview = await _context.ProductReviews.FindAsync(id);
            if (productReview == null)
            {
                return NotFound();
            }
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductName", productReview.ProductID);
            return View(productReview);
        }

        // POST: MobileReviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,Name,Rating,ReviewText,ProductID,ReviewDate")] ProductReview productReview)
        {
            if (id != productReview.ReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductReviewExists(productReview.ReviewID))
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
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductName", productReview.ProductID);
            return View(productReview);
        }

        // GET: MobileReviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobileReview = await _context.ProductReviews
                .Include(m => m.Product)
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (mobileReview == null)
            {
                return NotFound();
            }

            return View(mobileReview);
        }

        // POST: MobileReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productReview = await _context.ProductReviews.FindAsync(id);
            _context.ProductReviews.Remove(productReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductReviewExists(int id)
        {
            return _context.ProductReviews.Any(e => e.ReviewID == id);
        }
    }
}
