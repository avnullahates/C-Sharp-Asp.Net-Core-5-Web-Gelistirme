using BussinesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewCompenents.Dashboard
{
    public class AdminNavBarMessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterDal());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            string p = "admin@avnullahates.com";
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList(); 
     
            return View(values);
        }
    }
}
