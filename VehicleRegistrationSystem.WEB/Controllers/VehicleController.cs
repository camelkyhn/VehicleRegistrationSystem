using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using VehicleRegistrationSystem.BLL.Managers;
using VehicleRegistrationSystem.Common.Entities;

namespace VehicleRegistrationSystem.WEB.Controllers
{
    public class VehicleController : Controller
    {
        private VehicleManager VehicleManager = new VehicleManager();

        // GET: Vehicle/Create
        public IActionResult Create()
        {
            return View();
        }
        
        // POST: Vehicle/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(vehicle);
        }
        
        // GET: Vehicle/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var vehicle = VehicleManager.Find(v => v.Id == id);

            if (vehicle == null)
            {
                return NotFound();
            }
            
            return View(vehicle);
        }
        
        // POST: Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var vehicle = VehicleManager.Find(v => v.Id == id);
            VehicleManager.Delete(vehicle);
            return RedirectToAction("Index");
        }
        
        // GET: Vehicle/Details/5
        public IActionResult Details(int? id)
        {
            return View();
        }
        
        // GET: Vehicle/Edit/5
        public IActionResult Edit(int? id)
        {
            return View();
        }
        
        // POST: Vehicle/Edit
        [HttpPost]
        public IActionResult Edit(Vehicle vehicle)
        {
            return View();
        }
        
        // GET: Vehicle
        public IActionResult Index()
        {
            var vehicles = VehicleManager.GetList();
            return View(vehicles);
        }
    }
}