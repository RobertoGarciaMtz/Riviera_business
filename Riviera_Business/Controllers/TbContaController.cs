using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class TbContaController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbConta.ToList();
            foreach (TbConta ti in list)
            {
                ti.IdBancoNavigation = context.CBanco.Where(te => te.IdBanco == ti.IdBanco).FirstOrDefault();
            }
            return View(list);
        }

      

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.TbConta.Where(tc => tc.IdConta == id).First() is TbConta e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Bancos = context.CBanco.Select(ba => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ba.Nombre, Value = ba.IdBanco.ToString() });

            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbConta a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbConta.Add(a);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Bancos = context.CBanco.Select(ba => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ba.Nombre, Value = ba.IdBanco.ToString() });
            if (context.TbConta.Where(tc => tc.IdConta == id).First() is TbConta e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbConta a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbConta.FirstOrDefault(tc=> tc.IdConta == a.IdConta);
                if (objectEdit != null)
                {
                    objectEdit.Cantidad = a.Cantidad;
                    objectEdit.CargoAbono = a.CargoAbono;
                    objectEdit.Descripcion = a.Descripcion;
                    objectEdit.FechaTramite = a.FechaTramite;
                    objectEdit.IdBanco = a.IdBanco;
                    context.TbConta.Update(objectEdit);
                    context.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
