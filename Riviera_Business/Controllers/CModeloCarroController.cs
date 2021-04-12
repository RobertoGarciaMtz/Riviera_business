using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
using Microsoft.AspNetCore.Authorization;

namespace Riviera_Business.Controllers
{
    [Route("Modelo")]
    public class CModeloCarroController : Controller
    {
        // GET: HomeController1

        [Route("Index")]
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CModeloCarro.ToList();
            foreach(CModeloCarro ti in list)
            {
                ti.IdMarcaNavigation = context.CMarcaCarro.Where(te => te.IdMarcaCarro == ti.IdMarca).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5

        [Route("Detalles/{id:int}")]
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.CModeloCarro.Where(s => s.IdModeloCarro == id).First() is CModeloCarro e)
            {
                return View(e);
            }
            return NotFound();
            
        }

        // GET: HomeController1/Create

        [Route("Agregar")]
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Marcas = context.CMarcaCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.NombreMarca, Value = s.IdMarcaCarro.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [Route("Agregar")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CModeloCarro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CModeloCarro.Add(a);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5

        [Route("Editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Marcas = context.CMarcaCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.NombreMarca, Value = s.IdMarcaCarro.ToString() });
            if(context.CModeloCarro.Where(s=>s.IdModeloCarro == id).First() is CModeloCarro e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [Route("Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CModeloCarro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CModeloCarro.Where(mc => mc.IdModeloCarro == a.IdModeloCarro).FirstOrDefault();
                if(objectEdit != null)
                {
                    objectEdit.ModeloCarro = a.ModeloCarro;
                    objectEdit.IdMarca = a.IdMarca;
                    objectEdit.Usuario = a.Usuario;
                    context.CModeloCarro.Update(objectEdit);
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
