using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Riviera_Business.Models;
using Microsoft.AspNetCore.Authorization;

namespace Riviera_Business.Controllers
{
    [Route("Estados")]
    public class CEstadosController : Controller
    {
        // GET: HomeController1
        [Route("Index")]
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CEstados.ToList();
            return View(list);
        }

        // GET: HomeController1/Details/5
        [Route("Detalles")]
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.CEstados.Where(s => s.IdEstados == id).First() is CEstados e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        [Route("Agregar")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [Route("Agregar")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CEstados a)
        {
            try
            {
                // TODO: Add insert logic here
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CEstados.Add(a);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        [Route("Editar")]
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.CEstados.Where(s => s.IdEstados == id).First() is CEstados e)
            {
                return View(e);
            }
            return NotFound();
            
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [Route("Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CEstados a )
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CEstados.FirstOrDefault(ce => ce.IdEstados == a.IdEstados);
                if (objectEdit != null)
                {
                    objectEdit.Descripcion = a.Descripcion;
                    context.CEstados.Update(objectEdit);
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
