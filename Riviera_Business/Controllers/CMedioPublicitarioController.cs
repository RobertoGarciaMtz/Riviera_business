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
    [Route("Medios_publicitarios")]
    public class CMedioPublicitarioController : Controller
    {
        // GET: HomeController1
        [Route("Index")]
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CMedioPublicitario.ToList();
            foreach(CMedioPublicitario ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(te => te.IdEstados == ti.IdEstado).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        [Route("Detalles")]
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdEstados.ToString() });
            if (context.CMedioPublicitario.Where(s => s.IdMedioPublicitario == id).First() is CMedioPublicitario e)
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
            ViewBag.Estados = context.CEstados.Select(s=> new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {Text=s.Descripcion, Value= s.IdEstados.ToString() });

            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [Route("Agregar")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CMedioPublicitario a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CMedioPublicitario.Add(a);
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
            ViewBag.Estados = context.CEstados.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdEstados.ToString() });
            if (context.CMedioPublicitario.Where(s=>s.IdMedioPublicitario ==id ).First() is CMedioPublicitario e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [Route("Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CMedioPublicitario a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CMedioPublicitario.FirstOrDefault(mp => mp.IdMedioPublicitario == a.IdMedioPublicitario);
                if(objectEdit != null)
                {
                    objectEdit.Nombre = a.Nombre;
                    objectEdit.IdEstado = a.IdEstado;
                    context.CMedioPublicitario.Update(objectEdit);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
