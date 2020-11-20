using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class TblUser
    {
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
        public string AuthKey { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordResetToken { get; set; }
        public string Password { get; set; }
    }
}
