using Microsoft.AspNetCore.Mvc;

namespace BulkyBook_ASPNETCore_Web_MVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
