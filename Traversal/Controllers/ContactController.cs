using BusinessKatman.Abstract;
using BusinessKatman.Concrete;
using DataAccessKatman.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityKatman.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contacUsService;

        public ContactController(IContactUsService contacUsService)
        {
            _contacUsService = contacUsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDTO model)
        {
            if (ModelState.IsValid)
            {
                _contacUsService.HAdd(new ContactUs()
                {
                    MessageBody = model.MessageBody,
                    Mail = model.Mail,
                    MessageStatus = true,
                    Subject = model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
