using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public string VehicleTypeName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Status { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
