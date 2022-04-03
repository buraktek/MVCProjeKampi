using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MVCProjeKampi.Models;

namespace MVCProjeKampi.Controllers
{
    public class StatisticsController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager cm2 = new HeadingManager(new EfHeadingDal());

        public IActionResult Index()
        {
            #region Kategori tablosundaki durum bilgileri için

            List<Category> _category = cm.GetList();
            StatisticsModel _statics = new StatisticsModel();
            _statics.CategoryCheckedCount = 0;
            _statics.TotalCategoryCount = _category.Count;
            foreach (var category in _category)
            {
                if(category.CategoryStatus)
                    _statics.CategoryCheckedCount++;
            }

            #endregion Kategori tablosundaki durum bilgileri için
            #region En fazla başlığa sahip kategori adı
            List<Heading> _heading = cm2.GetList();


            #endregion


            return View(_statics);
        }
    }
}
