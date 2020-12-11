using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class UserPassword
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
        public string AuthKey { get; set; }
        public string PasswordResetToken { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public virtual User User { get; set; }
    }
}
