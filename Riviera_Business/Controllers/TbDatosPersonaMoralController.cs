using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class TbDatosPersonaMoralController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbDatosPersonaMoral.ToList();
            foreach (TbDatosPersonaMoral ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(ce=>ce.IdEstados == ti.IdEstado).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(dpm => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = dpm.Descripcion, Value = dpm.IdEstados.ToString() });
            if (context.TbDatosPersonaMoral.Where(dpm => dpm.IdDatosPm == id).First() is TbDatosPersonaMoral e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(dpm => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = dpm.Descripcion, Value = dpm.IdEstados.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbDatosPersonaMoral a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbDatosPersonaMoral.Add(a);
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
            ViewBag.Estados = context.CEstados.Select(dpm => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = dpm.Descripcion, Value = dpm.IdEstados.ToString() });
            if(context.TbDatosPersonaMoral.Where(dpm=> dpm.IdDatosPm == id).First() is TbDatosPersonaMoral e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbDatosPersonaMoral a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbDatosPersonaMoral.FirstOrDefault(dpm=> dpm.IdDatosPm == a.IdDatosPm);
                if (objectEdit != null)
                {
                    
                    objectEdit.ActividadGiroMercantilObjeto = a.ActividadGiroMercantilObjeto;
                    objectEdit.Cd = a.Cd;
                    objectEdit.Colonia = a.Colonia;
                    objectEdit.CorreoElectronico = a.CorreoElectronico;
                    objectEdit.Cp = a.Cp;
                    objectEdit.DenominacionRazonSocial = a.DenominacionRazonSocial;
                    objectEdit.Estado = a.Estado;
                    objectEdit.FechaConstitucion = a.FechaConstitucion;
                    objectEdit.FechaRegistroPublicoComercio = a.FechaRegistroPublicoComercio;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.Nacionalidad = a.Nacionalidad;
                    objectEdit.NoActa = a.NoActa;
                    objectEdit.NombreCalle = a.NombreCalle;
                    objectEdit.NoRegistroPublicoComercio = a.NoRegistroPublicoComercio;
                    objectEdit.NumExterior = a.NumExterior;
                    objectEdit.NumInterior = a.NumInterior;
                    objectEdit.NumTelefono = a.NumTelefono;
                    objectEdit.Rfc = a.Rfc;
                    context.TbDatosPersonaMoral.Update(objectEdit);
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
