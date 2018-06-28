using System;
using System.Collections.Generic;
using System.Data;
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
        
        [HttpPost]
        public IActionResult Create(Vehicle vehicle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    VehicleManager.Insert(vehicle);

                    return RedirectToAction("Index");
                }
            }
            catch (DataException e)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
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