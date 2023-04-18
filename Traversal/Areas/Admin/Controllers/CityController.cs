using BusinessKatman.Abstract;
using EntityKatman.concrete;
using HuzurELiProjesi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.HGetList());
            return Json(jsonCity);
        }
        public IActionResult AddCityDestination(Destination destination)
        {
            _destinationService.HAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }
    }

}

