using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AnnouncementController : Controller
    {

        AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IActionResult IndexAnnouncement()
        {
            var values = _announcementManager.TGetList();
            return View(values);
        }

        //ADD
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            _announcementManager.TAdd( announcement);
            return RedirectToAction("IndexAnnouncement");
        }

        //EDIT
        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {

            var values = _announcementManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditAnnouncement(Announcement announcement)
        {
            _announcementManager.TUpdate(announcement);
            return RedirectToAction("IndexAnnouncement");
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementManager.TGetByID(id);
            _announcementManager.TDelete(values);
            return RedirectToAction("IndexAnnouncement");
        }
    }
}
