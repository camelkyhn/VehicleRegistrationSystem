using System;

namespace VehicleRegistrationSystem.Common.Entities
{
    public class Vehicle
    {
        public string Plate { get; set; }
        
        public string NickName { get; set; }
        
        public string Brand { get; set; }
        
        public string Model { get; set; }
        
        public int? ModelYear { get; set; }
        
        public string Type { get; set; }
        
        public string Color { get; set; }
        
        public bool? IsActive { get; set; }
    }
}