using BusinessKatman.Abstract;
using BusinessKatman.ValidationRules;
using EntityKatman.concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route ("Admin/Guide")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        [Route("")]
        [Route("Index")]

        public IActionResult Index()
        {
            var values = _guideService.HGetList();
            return View(values);
        }

        [Route("AddGuide")]
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [Route("AddGuide")]
        [HttpPost]

        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.HAdd(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        [Route("EditGuide")]
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.HGetByID(id);
            return View(values);
        }
        [Route("EditGuide")]
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.HUpdate(guide);
            return RedirectToAction("Index");
        }

        [Route("ChangetoTrue/{id}")]
        public IActionResult ChangetoTrue(int id)
        {
            _guideService.HChangeToTrueByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

        [Route("ChangetoFalse/{id}")]
        public IActionResult ChangetoFalse(int id)
        {
            _guideService.HChangeToFalseByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

    }
}

