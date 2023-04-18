using BusinessKatman.Abstract;
using BusinessKatman.Concrete;
using DataAccessKatman.EntityFramework;
using EntityKatman.concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.HGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.HAdd(destination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.HGetByID(id);
            _destinationService.HDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.HGetByID(id);
            return View(values);
        } 
        [HttpPost]

        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.HUpdate(destination);
            
            return RedirectToAction("Index");
        }
    }
}
