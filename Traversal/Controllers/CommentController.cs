using BusinessKatman.Concrete;
using DataAccessKatman.EntityFramework;
using EntityKatman.concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        private readonly UserManager<AppUser> _userManager;

        public CommentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult AddComment()
        {
            //ViewBag.destID = id;
            //var value =  _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userID = value.Id;
            return RedirectToAction("Destination");
        }
        [HttpPost]

        public IActionResult AddComment(Comment p)
        {

            var value = _userManager.FindByNameAsync(User.Identity.Name);

            if (value.Result.Name == null)
            {
                ViewBag.metin = "Yorum Yapmak İçin Giriş Yapın";
            }
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            ViewBag.userID = value.Result.Name;
            commentManager.HAdd(p);
            return RedirectToAction("Index", "Destination");
        }

    }
}
