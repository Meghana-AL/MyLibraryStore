using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyLibraryStore.Controllers
{
    public class Customer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Meghana()
        {
            return Content("Hiiii Meghana.....");
        }
    }
}
