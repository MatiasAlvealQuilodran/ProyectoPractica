using Microsoft.AspNetCore.Mvc;

namespace ProyectoPractica.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
