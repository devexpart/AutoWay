using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class User
    {
        public User()
        {
            Owners = new HashSet<Owner>();
            UserPasswords = new HashSet<UserPassword>();
            VehicleImages = new HashSet<VehicleImage>();
        }

        public int Id { get; set; }
        public int UserTypeId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int? Status { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
        public virtual ICollection<UserPassword> UserPasswords { get; set; }
        public virtual ICollection<VehicleImage> VehicleImages { get; set; }
    }
}
