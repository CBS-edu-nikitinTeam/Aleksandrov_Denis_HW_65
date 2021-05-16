using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;

namespace AddTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Thread.Sleep(2000);
            return View();
        }

        public IActionResult Action()
        {
            Thread.Sleep(1000);
            return View();
        }

        public IActionResult Err()
        {
            throw new Exception("Error_D");
            return View();
        }

    }
}
