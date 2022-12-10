using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class WriteruserController : Controller
    {
        WriterUserManager userManager = new WriterUserManager(new EfWriterUserDal());

        public IActionResult Index()
        {            
            return View();
        }


        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(userManager.TGetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddUser(WriterUser t)
        {
            userManager.TAdd(t);
            var values = JsonConvert.SerializeObject(t);
            return Json(values);
        }
    }
}
