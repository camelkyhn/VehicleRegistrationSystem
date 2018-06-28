using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VehicleRegistrationSystem.BLL.Managers;
using VehicleRegistrationSystem.Common.Entities;

namespace VehicleRegistrationSystem.WEB.Controllers
{
    public class VehicleController : Controller
    {
        VehicleManager VehicleManager = new VehicleManager();

        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult Delete()
        {
            return View();
        }
        
        public IActionResult Details()
        {
            return View();
        }
        
        public IActionResult Edit()
        {
            return View();
        }
        
        // GET
        public IActionResult Index()
        {
            var vehicles = VehicleManager.GetList();
            return View(vehicles);
        }
    }
}