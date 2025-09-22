using ElectroMVC.DAL;
using ElectroMVC.Models;
using ElectroMVC.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectroMVC.Controllers
{

    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Tags> tags = new List<Tags>
            {
                new Tags { Id = 1, Name = "Electronics" },
                new Tags { Id = 2, Name = "Gadgets" },
                new Tags { Id = 3, Name = "Devices" }
            };


            List<Product> products = _context.Products.ToList();

            List<Slides> slides = _context.Slides
                .Include(s => s.Category)
                .ToList();

            List<BestSellerProducts> bestseller = _context.BestSellerProducts
                .Include(b => b.BestSellerProductsToTags)
                .ThenInclude(bt => bt.Tag)
                .ToList();
            List<BestSellerProductToTag> bestseller1 = _context
                .BestSellerProductToTags
                .ToList();


            HomeVM homeVM = new HomeVM
            {
                Product = products,
                Slides = slides,
                BestSellerProducts = bestseller,
                BestSellerProductToTag = bestseller1

            };

            return View(homeVM);
        }

        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();


        }
    }
}
