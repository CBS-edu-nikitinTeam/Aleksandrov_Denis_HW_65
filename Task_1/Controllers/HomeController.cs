using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Task_1.Infrastructure;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class HomeController : Controller
    {
        [FilterAction]
        public IActionResult Index()
        {
            return View();
        }
    }
}
