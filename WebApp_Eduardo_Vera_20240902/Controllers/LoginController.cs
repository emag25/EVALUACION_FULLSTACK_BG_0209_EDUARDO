using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApp_Eduardo_Vera_20240902.Models;
using WebApp_Eduardo_Vera_20240902.Services;

namespace WebApp_Eduardo_Vera_20240902.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioService _services;

        public LoginController(IUsuarioService services)
        {
            _services = services;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(string nombreUsuario, string contraseña)
        {
          
            Login login = new Login();
            login.username = nombreUsuario;
            login.password = contraseña;

            var usuario = _services.login(login);



            if (usuario != null)
            {
                return RedirectToAction("Index", "Alojamiento");
            }
            else
            {
                ViewBag.Error = "Nombre de usuario o contraseña incorrectos.";
                return View();
            }
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }


    }
}
