using BussinesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterDal()); //normalde EfWriterMessageDal olacak

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListReceiverMessage(p);
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            
            var messageList = writerMessageManager.GetListSenderMessage(p);
            
            return View(messageList);
        }

        [HttpGet]
        [Route("MessageDetails/{id}")]
        
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }

        [HttpGet]
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            string imageUrl = values.ImageUrl;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            p.ImageUrl = imageUrl;
            Context c = new Context();
            var usernameSurname = c.Users.Where(x => x.Email == p.Receiver).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            p.ReceiverName = usernameSurname;

            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
