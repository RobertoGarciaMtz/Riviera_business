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
    public class TbGastosController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbGastos.ToList();
            foreach(TbGastos ti in list)
            {
                if( ti.IdTipoGasto==2)
                {
                    ti.IdEstadoNavigation = context.CEstados.Where(es => es.IdEstados == ti.IdEstado).FirstOrDefault();
                    ti.IdTipoGastoNavigation = context.CTipoGasto.Where(es => es.IdTipoGasto == ti.IdTipoGasto).FirstOrDefault();
                }
                if(ti.IdTipoGasto==3) { 
                ti.IdCarroNavigation = context.TbCarros.Where(car => car.IdCarros == ti.IdCarro).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdCarroNavigation.IdVersion).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModelo).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                    (mar => mar.IdMarcaCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(es => es.IdEstados == ti.IdEstado).FirstOrDefault();
                ti.IdTipoGastoNavigation = context.CTipoGasto.Where(es => es.IdTipoGasto == ti.IdTipoGasto).FirstOrDefault();
                }
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Carros = context.TbCarros.Select(car => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = car.NoSerie, Value = car.IdCarros.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Gastos = context.CTipoGasto.Select(ga => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ga.Descripcion, Value = ga.IdTipoGasto.ToString() });
            if (context.TbGastos.Where(gas => gas.IdGastos == id).First() is TbGastos e)
            {
                return View(e);
            }
            return NotFound();
            
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Carros = context.TbCarros.Select(car=> new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {Text =car.NoSerie,Value=car.IdCarros.ToString() }); 
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text=es.Descripcion, Value=es.IdEstados.ToString()}); 
            ViewBag.Gastos = context.CTipoGasto.Select(ga=> new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {Text=ga.Descripcion,Value=ga.IdTipoGasto.ToString() }); 
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbGastos a)
        {
            try
            {
                var context  = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                if (a.IdTipoGasto == 1 || a.IdTipoGasto == 2)
                    a.IdCarro = 1;
                context.TbGastos.Add(a);
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
            ViewBag.Gastos = context.CTipoGasto.Select(ga => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ga.Descripcion, Value = ga.IdTipoGasto.ToString() });
            if (context.TbGastos.Where(gas => gas.IdGastos == id).First() is TbGastos e) { 
                return View(e);
              }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbGastos a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbGastos.FirstOrDefault(gas => gas.IdGastos == a.IdGastos);
                if (objectEdit != null)
                {
                    objectEdit.Descripcion = a.Descripcion;
                    objectEdit.Fecha = a.Fecha;
                    objectEdit.IdCarro = a.IdCarro;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.IdTipoGasto = a.IdTipoGasto;
                    objectEdit.Monto = a.Monto;
                    context.TbGastos.Update(objectEdit);
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
