using EntityKatman.concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.ViewComponents.AdminLayout
{
    public class _AdminLayoutUser : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AdminLayoutUser(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            TempData["userName"] = values.Name + " " + values.Surname;
            ViewBag.userName = values.Name + " " + values.Surname;
            ViewBag.userImage = values.ImageUrl;
            return View();
        }
    }
}
