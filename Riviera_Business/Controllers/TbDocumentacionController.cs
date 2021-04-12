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
    public class TbDocumentacionController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbDocumentacion.ToList();
            foreach (TbDocumentacion ti in list)
            {
                ti.IdDatosPersonaNavigation = context.TbDatosPersona.Where(dp => dp.IdDatosPersona == ti.IdDatosPersona).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(es => es.IdEstados == ti.IdEstado).FirstOrDefault();

            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Datospersona = context.TbDatosPersona.Select(dp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = dp.Nombre, Value = dp.IdDatosPersona.ToString() });
            ViewBag.Estado = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            if (context.TbDocumentacion.Where(le => le.IdDocumentos == id).First() is TbDocumentacion e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estado = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
          var lista = context.TbDatosPersona.Where(x => x.IdDatosPersona>= 0)
          .Select(x => new { nombrecc = x.IdDatosPersona.ToString(), desc = x.Nombre + " " + x.ApellidoPaterno + " " + x.ApellidoMaterno+ " - Curp: " + x.Curp });
        ViewBag.Datospersona = new SelectList(lista, "nombrecc", "desc");
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbDocumentacion a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbDocumentacion.Add(a);
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
            ViewBag.Datospersona = context.TbDatosPersona.Select(dp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = dp.Curp, Value = dp.IdDatosPersona.ToString() });
            ViewBag.Estado = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            if (context.TbDocumentacion.Where(le => le.IdDocumentos == id).First() is TbDocumentacion e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbDocumentacion a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbDocumentacion.FirstOrDefault(te => te.IdDocumentos == a.IdDocumentos);
                if(objectEdit != null)
                {
                    objectEdit.ActaConstitutivaBoletaRpc = a.ActaConstitutivaBoletaRpc;
                    objectEdit.CifSat = a.CifSat;
                    objectEdit.ComprobDomicilio = a.ComprobDomicilio;
                    objectEdit.ConocimientoDuenoBeneficiario = a.ConocimientoDuenoBeneficiario;
                    objectEdit.ConstanciaConocimiento = a.ConstanciaConocimiento;
                    objectEdit.Curp = a.Curp;
                    objectEdit.PersonaFM = a.PersonaFM;
                    objectEdit.IdDatosPersona = a.IdDatosPersona;
                    objectEdit.IdentificacionVig = a.IdentificacionVig;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.MesCorrespondiente = a.MesCorrespondiente;
                    objectEdit.PoderLegarExp = a.PoderLegarExp;
                    context.TbDocumentacion.Update(objectEdit);
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
