﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        public IActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
    }
}
