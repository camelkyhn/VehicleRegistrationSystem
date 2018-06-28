using System;
using Microsoft.EntityFrameworkCore.Internal;
using VehicleRegistrationSystem.Common.Entities;

namespace VehicleRegistrationSystem.DAL.Context
{
    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            //Look for a vehicle
            if (context.Vehicles.Any())
            {
                return; //DB has been seeded.
            }

            var vehicles = new Vehicle[]
            {
                new Vehicle(){ Brand = "Hyundai", Color = "Red", Model = "i10", ModelYear = 2008, Type = "Hatchbek", Plate = "35asd123", NickName = "MuswelHill", IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Vehicle(){ Brand = "Skoda", Color = "Red", Model = "Octavia", ModelYear = 2008, Type = "Sedan", Plate = "35qwe456", NickName = "Archway", IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Vehicle(){ Brand = "LandRover", Color = "Red", Model = "Discovery", ModelYear = 2008, Type = "SUV", Plate = "35zxc789", NickName = "North", IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            };

            foreach (var vehicle in vehicles)
            {
                context.Vehicles.Add(vehicle);
            }

            context.SaveChanges();
        }
    }
}