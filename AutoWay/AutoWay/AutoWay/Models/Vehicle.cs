using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            VehicleImages = new HashSet<VehicleImage>();
            VehicleTypes = new HashSet<VehicleType>();
        }

        public int Id { get; set; }
        public int VehicleTypeId { get; set; }
        public string VehicleName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string KmsDrivce { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Status { get; set; }
        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        public virtual VehicleType VehicleType { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<VehicleImage> VehicleImages { get; set; }
        public virtual ICollection<VehicleType> VehicleTypes { get; set; }
    }
}
