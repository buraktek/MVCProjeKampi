using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
