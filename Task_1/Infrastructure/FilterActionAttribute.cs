using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Task_1.Infrastructure
{
    public class FilterActionAttribute : ActionFilterAttribute
    {
        public static int CountUsers { get; set; }
        public static string[] _users = new string[1000];

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (ClaimsPrincipal.Current?.Identity != null)
            {
                string nameUser = ClaimsPrincipal.Current?.Identity.Name;
                StreamWriter stream = new StreamWriter("File/text.txt");
                if (!_users.Contains(nameUser))
                {
                    _users[CountUsers] = nameUser;
                    stream.WriteLine("Количество пользователей посетивших приложение - {0}", ++CountUsers);
                }
            
                stream.WriteLine("Количество пользователей посетивших приложение - {0}", CountUsers);
                stream.Close();
            }
        }

    }

}
