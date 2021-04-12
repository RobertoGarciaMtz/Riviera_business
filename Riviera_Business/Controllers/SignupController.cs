using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
using System.Security.Cryptography;
using System.Text;

namespace Riviera_Business.Controllers
{
    public class SignupController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Usuarios u)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                using (MD5 md5hash = MD5.Create())
                {
                    u.Contraseña = GetMd5Hash(md5hash, u.Contraseña);
                }
                u.IdEstado = 1;
                context.Usuarios.Add(u);
                context.SaveChanges();
                return RedirectToAction("Index", "Usuarios");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content("" + e);

            }
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }


    }
}
