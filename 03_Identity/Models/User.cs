using Microsoft.AspNetCore.Identity;

namespace _03_Identity.Models
{
    public class User : IdentityUser 
    {
        public string Country { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
