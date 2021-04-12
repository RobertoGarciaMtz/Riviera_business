using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class TbDatosPersonaController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbDatosPersona.ToList();
            foreach (TbDatosPersona ti in list)
            {
                ti.IdPmDpNavigation = context.TbDatosPersonaMoral.Where(pm => pm.IdDatosPm == ti.IdPmDp).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(es => es.IdEstados == ti.IdEstado).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Personamoral = context.TbDatosPersonaMoral.Select(pm => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = pm.DenominacionRazonSocial, Value = pm.IdDatosPm.ToString() });
            if (context.TbDatosPersona.Where(td => td.IdDatosPersona == id).First() is TbDatosPersona e)
            {
                return View(e);
            }
            return NotFound();
            
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Personamoral = context.TbDatosPersonaMoral.Select(pm => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = pm.DenominacionRazonSocial, Value = pm.IdDatosPm.ToString() });
            ViewBag.Estado = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbDatosPersona a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbDatosPersona.Add(a);
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
            ViewBag.Estado = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Personamoral = context.TbDatosPersonaMoral.Select(pm => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = pm.DenominacionRazonSocial, Value = pm.IdDatosPm.ToString() });
            if (context.TbDatosPersona.Where(td=>td.IdDatosPersona ==id).First() is TbDatosPersona e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbDatosPersona a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbDatosPersona.FirstOrDefault(td => td.IdDatosPersona == a.IdDatosPersona);
                if (objectEdit!=null)
                {
                    
                    objectEdit.ActividadUOcupacion = a.ActividadUOcupacion;
                    objectEdit.ApellidoMaterno = a.ApellidoMaterno;
                    objectEdit.ApellidoPaterno = a.ApellidoPaterno;
                    objectEdit.AutoridadEmite = a.AutoridadEmite;
                    objectEdit.Cd = a.Cd;
                    objectEdit.Colonia = a.Colonia;
                    objectEdit.Cp = a.Cp;
                    objectEdit.Curp = a.Curp;
                    objectEdit.Estado = a.Estado;
                    objectEdit.FechaNacimiento = a.FechaNacimiento;
                    objectEdit.FechaPoderNotorial = a.FechaPoderNotorial;
                    objectEdit.FisicaOMoral = a.FisicaOMoral;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.IdPmDp = a.IdPmDp;
                    objectEdit.Nacionalidad = a.Nacionalidad;
                    objectEdit.NoExterior = a.NoExterior;
                    objectEdit.NoInterior = a.NoInterior;
                    objectEdit.Nombre = a.Nombre;
                    objectEdit.NombreCalle = a.NombreCalle;
                    objectEdit.NoPoderNotorial = a.NoPoderNotorial;
                    objectEdit.NumeroTelefono = a.NumeroTelefono;
                    objectEdit.Rfc = a.Rfc;
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
