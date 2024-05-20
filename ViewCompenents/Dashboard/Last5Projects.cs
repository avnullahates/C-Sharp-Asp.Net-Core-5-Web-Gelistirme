using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewCompenents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = _portfolioManager.TGetList();      
            return View(values);
        }
    }
}
