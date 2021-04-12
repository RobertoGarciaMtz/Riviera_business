using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class TbPapelesCarroController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbPapelesCarro.ToList();
            foreach (TbPapelesCarro ti in list)
            {
                ti.IdCarroNavigation = context.TbCarros.Where(car => car.IdCarros == ti.IdCarro).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdCarroNavigation.IdVersion).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModelo).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                    (mar => mar.IdMarcaCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(es => es.IdEstados == ti.IdEstado).FirstOrDefault();
            }

            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Carros = context.TbCarros.Select(car => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = car.NoSerie, Value = car.IdCarros.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            if (context.TbPapelesCarro.Where(pa => pa.IdCarro == id).First() is TbPapelesCarro e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Carros = context.TbCarros.Select(car => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = car.NoSerie, Value = car.IdCarros.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbPapelesCarro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbPapelesCarro.Add(a);
                context.SaveChanges();

                TbLineaTiempo linea = new TbLineaTiempo();
                linea.IdCarro = a.IdCarro;
                linea.Fecha = DateTime.Today;
                linea.IdEstado = 16;

                context.TbLineaTiempo.Add(linea);
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
            if(context.TbPapelesCarro.Where(pa=>pa.IdPapelesCarro ==id).First() is TbPapelesCarro e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbPapelesCarro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbPapelesCarro.FirstOrDefault(pa=> pa.IdCarro== a.IdCarro);
                if(objectEdit != null)
                {
                    objectEdit.Baja = a.Baja;
                    objectEdit.FactOrigen = a.FactOrigen;
                    objectEdit.FechaUlltimaVerificacion = a.FechaUlltimaVerificacion;
                    objectEdit.IdCarro = a.IdCarro;
                    objectEdit.IdEmisor = a.IdEmisor;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.Mes = a.Mes;
                    objectEdit.RefactCompleta = a.RefactCompleta;
                    objectEdit.Repuve = a.Repuve;
                    objectEdit.Tenencias4Anos = a.Tenencias4Anos;
                    objectEdit.Transunionfolio = a.Transunionfolio;
                    objectEdit.Verificacion = a.Verificacion;
                    context.TbPapelesCarro.Update(objectEdit);
                    context.SaveChanges();

                    TbLineaTiempo linea = new TbLineaTiempo();
                    linea.IdCarro = a.IdCarro;
                    linea.Fecha = DateTime.Today;
                    linea.IdEstado = 17;

                    context.TbLineaTiempo.Add(linea);
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
    }
}
