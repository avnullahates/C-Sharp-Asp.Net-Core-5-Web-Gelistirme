using BussinesLayer.Concrete;
using Core_Proje.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        WriterUserManager _writerUserManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult UserIndex()
        {
            var values = _writerUserManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _writerUserManager.TGetByID(id);
            _writerUserManager.TDelete(values);
            return RedirectToAction("UserIndex");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _writerUserManager.TGetByID(id);
            return View(values);
        }

       
    }
}
