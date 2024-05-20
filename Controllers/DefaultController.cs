using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {

        MessageManager message = new MessageManager(new EfMessageDal());
       
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        
        public PartialViewResult SendMessage(Message m)
        {
            return PartialView();
        }

        //[HttpPost]
        //public PartialViewResult SendMessage(Message p)
        //{
        //    MessageManager messageManager = new MessageManager(new EfMessageDal());
        //    p.Date = Convert.ToDateTime(DateTime.Now);
        //    p.Status = true;
        //    messageManager.TAdd(p);
        //    return PartialView();
        //}

        [HttpPost]
        public IActionResult Send(Message m)
        {
            m.Date = Convert.ToDateTime(DateTime.Now);
            m.Status = true;
            message.TAdd(m);
            var values = JsonConvert.SerializeObject(m);
            return Json(values);
        }


    }

}
