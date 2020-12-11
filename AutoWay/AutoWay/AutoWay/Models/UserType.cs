using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
