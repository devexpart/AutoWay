using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class TblVehicle
    {
        public int Id { get; set; }
        public int VhclTypeId { get; set; }
        public string VhclName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string KmsDriven { get; set; }
        public string Rent { get; set; }
        public int? LastRentedBy { get; set; }
        public string SellingPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Status { get; set; }
    }
}
