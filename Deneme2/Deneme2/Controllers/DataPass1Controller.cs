using Microsoft.AspNetCore.Mvc;

namespace Deneme2.Controllers
{
    public class DataPass1Controller : Controller
    {
        public IActionResult Pass1()
        {
            new Data.User();
            new Helper.Class1();
            ViewBag.Username = "BilgeAdam";
            ViewData["degisken"] = "bu da diğeri";
            return View();
        }
    }
}