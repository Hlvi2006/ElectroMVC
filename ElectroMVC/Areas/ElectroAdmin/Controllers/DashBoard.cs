using Microsoft.AspNetCore.Mvc;

namespace ElectroMVC.Areas.ElectroAdmin.Controllers
{
    [Area("ElectroAdmin")]
    public class DashBoard : Controller
    {
        
        public IActionResult Index()
        {
            return View();
       }
    }
}
