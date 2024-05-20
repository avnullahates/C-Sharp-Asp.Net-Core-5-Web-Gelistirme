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

namespace Core_Proje.ViewCompenents.Dashboard
{
    public class UserList : ViewComponent
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EfWriterUserDal());
        public IViewComponentResult Invoke()
        {
            var values = writerUserManager.TGetList();
            return View(values);
        }

    }
}
