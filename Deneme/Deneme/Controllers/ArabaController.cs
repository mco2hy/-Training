using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers
{
    public class ArabaController : Controller
    {
        public IActionResult Ford()
        {
            return View();
        }
        public IActionResult Mercedes()
        {
            return View();
        }
    }
}