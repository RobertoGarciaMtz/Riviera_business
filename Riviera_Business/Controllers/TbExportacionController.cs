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
    public class TbExportacionController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbExportacion.ToList();
            foreach (TbExportacion ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(es => es.IdEstados == ti.IdEstado).FirstOrDefault();
                ti.IdPersonaNavigation = context.TbDatosPersona.Where(es => es.IdDatosPersona == ti.IdPersona).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Personas = context.TbDatosPersona.Select(per => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = per.Curp, Value = per.IdDatosPersona.ToString() });
            if (context.TbExportacion.Where(te => te.IdExportacion == id).First() is TbExportacion e)
            {
                return View(e);
            }
            return NotFound();
            
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            var lista = context.TbDatosPersona.Where(x => x.IdDatosPersona >= 0)
            .Select(x => new { nombrecc = x.IdDatosPersona.ToString(), desc = x.Nombre + " " + x.ApellidoPaterno });
            ViewBag.Datospersona = new SelectList(lista, "nombrecc", "desc");
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbExportacion a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbExportacion.Add(a);
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
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Personas = context.TbDatosPersona.Select(per => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = per.Curp, Value = per.IdDatosPersona.ToString() });
            if(context.TbExportacion.Where(te=>te.IdExportacion ==id).First() is TbExportacion e) { 
            return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbExportacion a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbExportacion.FirstOrDefault(te => te.IdExportacion == a.IdExportacion);
                if (objectEdit!=null)
                {
                    objectEdit.CartaPoderId = a.CartaPoderId;
                    objectEdit.Cfdi = a.Cfdi;
                    objectEdit.CfdiFpA = a.CfdiFpA;
                    objectEdit.Entregada = a.Entregada;
                    objectEdit.FechaFactura = a.FechaFactura;
                    objectEdit.FechaPago = a.FechaPago;
                    objectEdit.FechaPromesaEntrega = a.FechaPromesaEntrega;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.IdPersona = a.IdPersona;
                    objectEdit.NoFactura = a.NoFactura;
                    objectEdit.ObservacionesReclamos = a.ObservacionesReclamos;
                    objectEdit.OrdenCompra = a.OrdenCompra;
                    objectEdit.Pagada = a.Pagada;
                    objectEdit.PedimientoImpOk = a.PedimientoImpOk;
                    objectEdit.SalidaAgencia = a.SalidaAgencia;
                    objectEdit.ValorFactura = a.ValorFactura;
                    objectEdit.Xml = a.Xml;
                    context.TbExportacion.Update(objectEdit);
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
