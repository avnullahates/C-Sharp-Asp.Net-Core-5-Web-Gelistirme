using BussinesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterDal()); 

        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = _writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = _writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = _writerMessageManager.TGetByID(id);
            return View(values);
        }
        public IActionResult AdminMessageDeleteReciver(int id)
        {
            var values = _writerMessageManager.TGetByID(id);
            _writerMessageManager.TDelete(values);
            return RedirectToAction("ReceiverMessageList");
        }

        public IActionResult AdminMessageDeleteSender(int id)
        {
            var values = _writerMessageManager.TGetByID(id);
            _writerMessageManager.TDelete(values);
            return RedirectToAction("SenderMessageList");
        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Now;
            Context c = new Context();
            var usernameSurname = c.Users.Where(x => x.Email == p.Receiver).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            p.ReceiverName = usernameSurname;
            _writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }

    }
}
