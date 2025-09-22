using ElectroMVC.DAL;
using ElectroMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectroMVC.Areas.ElectroAdmin.Controllers
{
    [Area("ElectroAdmin")]
    public class CategoryController : Controller
    {
       private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories =await _context.Categories
                .Include(c => c.Slides)
                .ToListAsync();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
    }

}
