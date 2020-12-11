using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string OwnerFname { get; set; }
        public string OwnerLname { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
