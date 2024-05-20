using BussinesLayer.Concrete;
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
    public class SkillController : Controller
    {

        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult SkillIndex()
        {
            
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
         
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("SkillIndex");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("SkillIndex");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            
            var vaalues = skillManager.TGetByID(id);
            return View(vaalues);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("SkillIndex");
        }
    }
}
