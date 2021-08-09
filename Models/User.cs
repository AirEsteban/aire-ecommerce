using System;
using System.Collections.Generic;

#nullable disable

namespace Back_end.Models
{
    public partial class User
    {
        public User()
        {
            Publications = new HashSet<Publication>();
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Verified { get; set; }
        public string Photo { get; set; }
        public bool? UsrDeleted { get; set; }

        public virtual ICollection<Publication> Publications { get; set; }
    }
}
