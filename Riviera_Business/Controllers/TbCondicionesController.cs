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
    public class TbCondicionesController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var list = context.TbCondiciones.ToList();
            foreach(TbCondiciones ti in list)
            {
                ti.IdCarroNavigation = context.TbCarros.Where(cn => cn.IdCarros == ti.IdCarro).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(te => te.IdEstados == ti.IdEstado).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.TbCondiciones.Where(tc => tc.IdCondiciones == id).First() is TbCondiciones e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var lista = context.TbControl.Where(x => x.IdMovimiento >= 0)
             .Select(x => new { movimiento = x.IdMovimiento.ToString(), desc = x.IdMovimiento.ToString() + "-LineaCapt:" + x.FolioFiscal + "-ID_carro:" + x.IdCarros + "-ID_Cliente:" + x.IdCliente });
            ViewBag.Control = new SelectList(lista, "movimiento", "desc");
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbCondiciones a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbCondiciones.Add(a);
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
            var lista = context.TbControl.Where(x => x.IdMovimiento >= 0)
 .Select(x => new { movimiento = x.IdMovimiento.ToString(), desc = x.IdMovimiento.ToString() + "-LineaCapt:" + x.FolioFiscal + "-ID_carro:" + x.IdCarros + "-ID_Cliente:" + x.IdCliente });
            ViewBag.Control = new SelectList(lista, "movimiento", "desc");
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            if (context.TbCondiciones.Where(tc=> tc.IdCondiciones == id).First() is TbCondiciones e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbCondiciones a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbCondiciones.FirstOrDefault(tc => tc.IdCondiciones == a.IdCondiciones);
                if (objectEdit!=null)
                {
                    objectEdit.LlantaDi = a.LlantaDi;
                    objectEdit.LlanraTi = a.LlanraTi;
                    objectEdit.LlantaDd = a.LlantaDd;
                    objectEdit.LlantaTd = a.LlantaTd;
                    objectEdit.IdEstado = a.IdEstado;
                    context.TbCondiciones.Update(objectEdit);
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
