using DataAcessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Web.Security;

namespace MVCProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminuserinfo = c.Admins.FirstOrDefault(x=>x.AdminUserName == p.AdminUserName 
                && x.AdminPassword == p.AdminPassword);
            if(adminuserinfo != null)
            {
                return RedirectToAction("Index","AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
