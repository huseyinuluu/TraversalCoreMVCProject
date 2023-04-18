using BusinessKatman.Abstract;
using EntityKatman.concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IVisitService _visitService;

        public UserController(IAppUserService appUserService, IVisitService visitService)
        {
            _appUserService = appUserService;
            _visitService = visitService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.HGetList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.HGetByID(id);
            _appUserService.HDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _appUserService.HGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.HUpdate(appUser);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser(int id)
        {
            _appUserService.HGetList();
            return View();
        }
        public IActionResult LastVisitUser(int id)
        {
           var values = _visitService.GetListWithVisitByAppRoval(id);
            return View(values);
        }
    }
}
