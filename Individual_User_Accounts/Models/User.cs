using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Individual_User_Accounts.Models
{
    public class User : IdentityUser
    {
        public string Country { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
