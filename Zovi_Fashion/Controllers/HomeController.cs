using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zovi_Fashion.Models;
using Zovi_Fashion.Data;
using Microsoft.EntityFrameworkCore;

namespace Zovi_Fashion.Controllers
{
    public class HomeController : Controller
    { 
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.OrderBy(x => Guid.NewGuid()).Take(3).ToListAsync());
        }

        public async Task<IActionResult> ViewProductsByBrand(int? id)
        {
            var applicationDbContext = _context.Products
            .Include(b => b.Brand).Where(m => m.BrandID == id);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> AllBrands()
        {
            return View(await _context.Brands.ToListAsync());
        }

        public async Task<IActionResult> ViewStudios()
        {
            return View(await _context.Studios.ToListAsync());
        }

        public async Task<IActionResult> AllProducts()
        {
            return View(await _context.Products.ToListAsync());
        }


        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(b => b.Brand)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public async Task<IActionResult> StudioDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studio = await _context.Studios
                .FirstOrDefaultAsync(m => m.StudioID == id);
            if (studio == null)
            {
                return NotFound();
            }

            return View(studio);
        }
        public async Task<IActionResult> ViewReviews(int? id)
        {
            var applicationDbContext = _context.ProductReviews
            .Include(b => b.Product).Where(m => m.ProductID == id);
            return View(await applicationDbContext.ToListAsync());
        }

            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
