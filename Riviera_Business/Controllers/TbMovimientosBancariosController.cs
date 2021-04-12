using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Riviera_Business.Controllers
{
    public class TbMovimientosBancariosController : Controller
    {
        // GET: TbMovimientosBancarios
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbMovimientosBancarios.ToList();
            return View(list);
        }

        // GET: TbMovimientosBancarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TbMovimientosBancarios/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Bancos = context.CBanco.Select(ban => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ban.Nombre,Value=ban.IdBanco.ToString() }); ; ;
            return View();
        }

        // POST: TbMovimientosBancarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbMovimientosBancarios a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbMovimientosBancarios.Add(a);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TbMovimientosBancarios/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Bancos = context.CBanco.Select(ban => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ban.Nombre, Value = ban.IdBanco.ToString() }); ; ;
            if (context.TbMovimientosBancarios.Where(mb=>mb.IdTbMovimientosBancarios==id).First() is TbMovimientosBancarios e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: TbMovimientosBancarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbMovimientosBancarios a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbMovimientosBancarios.FirstOrDefault(mb => mb.IdTbMovimientosBancarios == a.IdTbMovimientosBancarios);
                if (objectEdit != null)
                {
                    objectEdit.Concepto = a.Concepto;
                    objectEdit.DepositoRetiro = a.DepositoRetiro;
                    objectEdit.Fecha = a.Fecha;
                    objectEdit.Saldo = a.Saldo;
                    context.TbMovimientosBancarios.Update(objectEdit);
                    context.SaveChanges();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TbMovimientosBancarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TbMovimientosBancarios/Delete/5
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
