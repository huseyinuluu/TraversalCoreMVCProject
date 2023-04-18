using BusinessKatman.Concrete;
using DataAccessKatman.EntityFramework;
using EntityKatman.concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Areas.Member.Controllers
{
    [Area("Member")]
    public class VisitController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        VisitManager visitManager = new VisitManager(new EfVisitDal());

        private readonly UserManager<AppUser> _userManager;

        public VisitController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyActiveVisit()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = visitManager.GetListWithVisitByAppRoval(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyOldVisit()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = visitManager.GetListWithVisitByLast(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyAppRovalVisit()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = visitManager.GetListWithVisitByWaitAppRoval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewVisit()
        {            
            
            List<SelectListItem> values = (from x in destinationManager.HGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();            
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewVisit(Visit p)
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var userID = values.Id;
            p.AppUserID = userID;
            p.Status = "Onay Bekliyor";
            visitManager.HAdd(p);
            return RedirectToAction("Index");
        }
    }
}
