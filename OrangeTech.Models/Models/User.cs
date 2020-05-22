using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.Models.Models
{
    public class User
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        public Guid RoleId { get; set; }
    }
}
