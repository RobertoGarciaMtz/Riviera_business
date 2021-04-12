using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
using System.Security.Cryptography;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Riviera_Business.Controllers
{
    public class Login_Controller : Controller
    {
        // GET: HomeController1
        public ActionResult Index(string ReturnURL)
        {
            if (User.Identity.IsAuthenticated == false)
            {
                if (ReturnURL != null)
                    ViewData.Add("ReturnURL", ReturnURL);
                else
                    ViewData.Add("ReturnURL", "");
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home"); //Action,Controller
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Index(Usuarios model)
        {
            
            string pass = "";
            try
            {
                var tc = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                using (MD5 md5hash = MD5.Create())
                {
                    pass = SignupController.GetMd5Hash(md5hash, model.Contraseña);
                }
                Usuarios log = tc.Usuarios.Where(p => p.NombreUsuario == model.NombreUsuario && p.Contraseña == pass).FirstOrDefault();

                if (log != null)
                {

                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, model.NombreUsuario));

                    var userIdentity = new ClaimsIdentity(claims, "login");
                    var principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync("PKAT", principal);

                    HttpContext.Session.SetInt32("idUsuario", log.IdUsuarios);
                    HttpContext.Session.SetString("nomUsuario", log.NombreUsuario);
                    HttpContext.Session.SetInt32("tipoUsuario", (int)log.TipoUsuario);

                    return RedirectToAction("Index", "Home");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content("" + e);
            }



            return RedirectToAction("Index", "Login");

        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync("PKAT");
            return RedirectToAction("Index", "Login_");
        }


    }
}
