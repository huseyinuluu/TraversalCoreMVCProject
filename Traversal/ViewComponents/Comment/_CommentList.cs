using BusinessKatman.Concrete;
using DataAccessKatman.Concrete;
using DataAccessKatman.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.ViewComponents.Comment
{
    public class _CommentList  :ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = context.Comments.Where(x => x.DestinationID == id).Count();
            var values = commentManager.HGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
