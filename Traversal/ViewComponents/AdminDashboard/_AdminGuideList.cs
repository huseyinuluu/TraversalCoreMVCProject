﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.ViewComponents.AdminDashboard
{
    public class _AdminGuideList :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
