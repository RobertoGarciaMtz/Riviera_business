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
    [Route("Conceptos")]
    public class CConceptoController : Controller
    {
        // GET: HomeController1
        
        [Route("Index")]
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CConcepto.ToList();
            return View(list);
        }

        // GET: HomeController1/Details/5

        [Route("Detalles")]
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.CConcepto.Where(s => s.IdCConcepto == id).First() is CConcepto e)
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
        public ActionResult Create(CConcepto a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CConcepto.Add(a);
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
            if (context.CConcepto.Where(s => s.IdCConcepto == id).First() is CConcepto e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [Route("Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CConcepto a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CConcepto.FirstOrDefault(co => co.IdCConcepto== a.IdCConcepto);
                if (objectEdit != null)
                {
                    objectEdit.DescripcionConcepto = a.DescripcionConcepto;
                    context.CConcepto.Update(objectEdit);
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
