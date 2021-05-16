using Individual_User_Accounts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Individual_User_Accounts.Controllers
{
    public class HomeController : Controller
    {
       [Authorize]
        public IActionResult Index()
        {
            return View();
        }

    }
}
