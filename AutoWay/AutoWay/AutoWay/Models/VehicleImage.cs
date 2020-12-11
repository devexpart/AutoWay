using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class VehicleImage
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string FilePath { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
