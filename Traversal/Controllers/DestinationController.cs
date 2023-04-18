using BusinessKatman.Concrete;
using DataAccessKatman.EntityFramework;
using EntityKatman.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {        
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = destinationManager.HGetList();
            return View(values);
        }
        [HttpGet]
        public async Task <IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = value.Id;

            var valueName = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = valueName.Name+ " "+ valueName.Surname;

            var values = destinationManager.HGetDestinationWithGuide(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
