using BusinessKatman.Concrete;
using DataAccessKatman.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Areas.Member.Controllers
{
        [Area("Member")]
        [Route("Member/[controller]/[action]")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index(string searcString)
        {
            
            ViewData["CurrentFilter"] = searcString;
            var values = from x in destinationManager.HGetList() select x;
            if (!string.IsNullOrEmpty(searcString))
            {
                values = values.Where(y => y.City.ToLower().Contains(searcString.ToLower()));
            }
            return View(values.ToList());
        }
        
    }
    
}
