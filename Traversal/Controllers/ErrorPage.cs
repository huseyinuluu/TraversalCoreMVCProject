﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Controllers
{
    [AllowAnonymous]
    public class ErrorPage : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
