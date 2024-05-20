

using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewCompenents.Feature
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
        //.OrderByDescending(x=>x.ExperienceID)
    }
}
