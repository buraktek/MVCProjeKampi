using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        public IActionResult Inbox()
        {
            var messagelist = mm.GetListInbox();
            return View(messagelist);
        }

        public IActionResult Sendbox()
        {
            var messagelist = mm.GetListSendbox();
            return View(messagelist);
        }

        [HttpGet]
        public IActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMessage(Message p)
        {
            mm.MessageAdd(p);
            return View("Index");
        }
    }
}
