using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class TblVehicleType
    {
        public int Id { get; set; }
        public int VhclId { get; set; }
        public string VhclTypeName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Status { get; set; }
    }
}
