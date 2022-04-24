using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult Page403()
        {
            Response.StatusCode = 403;
            //Response. = true;
            return View();
        }

        public IActionResult Page404()
        {
            Response.StatusCode = 404;
            //Response. = true;
            return View();
        }
    }
}
