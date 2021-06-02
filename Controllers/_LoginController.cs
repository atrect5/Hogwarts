using Microsoft.AspNetCore.Mvc;

using Hogwarts_16301106_17100150.Models;

namespace Hogwarts_16301106_17100150.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            var login = new login();

            login.id_user = 2022;
            login.nombre = "Melissa";
            login.contraseña = "2021";
            return View(login);
        }
    }
}