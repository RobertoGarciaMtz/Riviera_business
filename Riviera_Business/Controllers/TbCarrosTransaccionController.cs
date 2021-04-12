using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class TbCarrosTransaccionController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbCarrosTransaccion.ToList();
            foreach(TbCarrosTransaccion ti in list)
            {
                ti.IdCarroNavigation = context.TbCarros.Where(car=>car.IdCarros == ti.IdCarro).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdCarroNavigation.IdVersion).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModelo).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                    (mar => mar.IdMarcaCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
                ti.IdControlNavigation = context.TbControl.Where(con => con.IdMovimiento == ti.IdControl).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(es => es.IdEstados == ti.IdEstado).FirstOrDefault();
            }
            return View();
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Carros = context.TbCarros.Select(car => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = car.NoSerie, Value = car.IdCarros.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Control = context.TbControl.Select(con => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = con.FolioFiscal, Value = con.IdCarros.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbCarrosTransaccion a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbCarrosTransaccion.Add(a);
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
            ViewBag.Carros = context.TbCarros.Select(car => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = car.NoSerie, Value = car.IdCarros.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Control = context.TbControl.Select(con => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = con.FolioFiscal, Value = con.IdCarros.ToString() });
            if (context.TbCarrosTransaccion.Where(gas => gas.IdCarrosTransaccion == id).First() is TbCarrosTransaccion e)
            {
                return View(e);
            }
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbCarrosTransaccion a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbCarrosTransaccion.FirstOrDefault(trans => trans.IdCarrosTransaccion == a.IdCarrosTransaccion);
                objectEdit.IdCarro = a.IdCarro;
                objectEdit.IdControl = a.IdControl;
                objectEdit.IdEstado = a.IdEstado;
                context.TbCarrosTransaccion.Update(objectEdit);
                context.SaveChanges();
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
