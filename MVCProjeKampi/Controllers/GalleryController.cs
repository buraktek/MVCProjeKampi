using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager im = new ImageFileManager(new EfImageFileDal());
        public IActionResult Index()
        {
            var imagefiles = im.GetList();
            return View(imagefiles);
        }
    }
}
