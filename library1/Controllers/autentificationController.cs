using Microsoft.AspNetCore.Mvc;

namespace library1
{
    public class AutentificationController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
        public IActionResult createAccount()
        {
            return View();
        }
    }
}
