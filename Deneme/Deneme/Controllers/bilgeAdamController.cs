using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers
{
    public class bilgeAdamController : Controller
    {
        public IActionResult Ogrenci()
        {
            return View();
        }
    }
}