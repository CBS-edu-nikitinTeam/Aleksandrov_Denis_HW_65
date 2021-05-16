using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Individual_User_Accounts.Models
{
    public sealed class UserContext : IdentityDbContext<User>
    {
        public UserContext(DbContextOptions<UserContext> dbContext) : base(dbContext)
        {
            Database.EnsureCreated();
        }
    }
}
