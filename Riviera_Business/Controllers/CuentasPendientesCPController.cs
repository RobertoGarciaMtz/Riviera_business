using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Riviera_Business.Controllers
{
    [Route("Cuentas")]
    public class CuentasPendientesCPController : Controller
    {
        // GET: HomeController1
        [Route("Index")]
        public ActionResult Index()
        {

            if (HttpContext.Session.GetInt32("tipoUsuario") ==1 || HttpContext.Session.GetInt32("tipoUsuario")==6) //Si el usuario no es Admin
            {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CuentasPendientesCP.Where(cpc=>cpc.CuentasCobrarPagarOtras==1).ToList();
            foreach (CuentasPendientesCP ti in list)
            {
                
                ti.IdCarroNavigation = context.TbCarros.Where(car => car.IdCarros == ti.IdCarro).FirstOrDefault();
                ti.IdConceptoNavigation = context.CConcepto.Where(con => con.IdCConcepto == ti.IdConcepto).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(te => te.IdEstados == ti.IdEstado).FirstOrDefault();
             /* ti.IdCarroNavigation.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdCarroNavigation.IdVersion).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModelo).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                    (mar => mar.IdMarcaCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
                   */
                }
                return View(list);
            }
            return RedirectToAction("Index", "Home");    //Regresas a Home
        }
        [Route("Index/Pagar")]

        public ActionResult IndexPP()
        {

            if (HttpContext.Session.GetInt32("tipoUsuario") == 1 || HttpContext.Session.GetInt32("tipoUsuario") == 6) //Si el usuario no es Admin
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var list = context.CuentasPendientesCP.Where(cpp=>cpp.CuentasCobrarPagarOtras==2).ToList();
                foreach (CuentasPendientesCP ti in list)
                {

                    ti.IdCarroNavigation = context.TbCarros.Where(car => car.IdCarros == ti.IdCarro).FirstOrDefault();
                    ti.IdConceptoNavigation = context.CConcepto.Where(con => con.IdCConcepto == ti.IdConcepto).FirstOrDefault();
                    ti.IdEstadoNavigation = context.CEstados.Where(te => te.IdEstados == ti.IdEstado).FirstOrDefault();
                    /* ti.IdCarroNavigation.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdCarroNavigation.IdVersion).FirstOrDefault();
                       ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModelo).FirstOrDefault();
                       ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                           (mar => mar.IdMarcaCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
                          */
                }
                return View(list);
            }
            return RedirectToAction("Index", "Home");    //Regresas a Home
        }

        [Route("Index/Otras")]
        // GET: HomeController1/Details/5
        public ActionResult IndexOC()
        {

            if (HttpContext.Session.GetInt32("tipoUsuario") == 1 || HttpContext.Session.GetInt32("tipoUsuario") == 6) //Si el usuario no es Admin
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var list = context.CuentasPendientesCP.Where(oc=>oc.CuentasCobrarPagarOtras==3).ToList();
                foreach (CuentasPendientesCP ti in list)
                {

                    ti.IdCarroNavigation = context.TbCarros.Where(car => car.IdCarros == ti.IdCarro).FirstOrDefault();
                    ti.IdConceptoNavigation = context.CConcepto.Where(con => con.IdCConcepto == ti.IdConcepto).FirstOrDefault();
                    ti.IdEstadoNavigation = context.CEstados.Where(te => te.IdEstados == ti.IdEstado).FirstOrDefault();
                    /* ti.IdCarroNavigation.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdCarroNavigation.IdVersion).FirstOrDefault();
                       ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModelo).FirstOrDefault();
                       ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                           (mar => mar.IdMarcaCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
                          */
                }
                return View(list);
            }
            return RedirectToAction("Index", "Home");    //Regresas a Home
        }

        [Route("Detalles")]
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            
            if (context.CuentasPendientesCP.Where(cu => cu.IdCuentaPendiente == id).First() is CuentasPendientesCP e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        [Route("Por_cobrar")]
        public ActionResult CuentasCobrar()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Concepto = context.CConcepto.Select(con => new SelectListItem { Text = con.DescripcionConcepto,Value = con.IdCConcepto.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
                .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
            ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
            return View();
        }

        [Route("Por_pagar")]
        public ActionResult CuentasPagar()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Concepto = context.CConcepto.Select(con => new SelectListItem { Text = con.DescripcionConcepto, Value = con.IdCConcepto.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
                .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
            ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
            return View();
        }
        [Route("Otras")]
        public ActionResult OtrasCuentas()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Concepto = context.CConcepto.Select(con => new SelectListItem { Text = con.DescripcionConcepto, Value = con.IdCConcepto.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
                .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
            ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [Route("Por_cobrar")]
        [ValidateAntiForgeryToken]
        public ActionResult CuentasCobrar(CuentasPendientesCP a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CuentasPendientesCP.Add(a);
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
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Concepto = context.CConcepto.Select(con => new SelectListItem { Text = con.DescripcionConcepto, Value = con.IdCConcepto.ToString() });
            var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
                .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
            ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
            if (context.CuentasPendientesCP.Where(cu=>cu.IdCuentaPendiente== id).First() is CuentasPendientesCP e) 
            { 
            return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [Route("Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CuentasPendientesCP a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var ObjectEdit = context.CuentasPendientesCP.FirstOrDefault(cu => cu.IdCuentaPendiente == id);
                if (ObjectEdit != null)
                {
                    ObjectEdit.Anticipo = a.Anticipo;
                    ObjectEdit.CuentasCobrarPagarOtras = a.CuentasCobrarPagarOtras;
                    ObjectEdit.Detalle = a.Detalle;
                    ObjectEdit.Fecha = a.Fecha;
                    ObjectEdit.Folio = a.Folio;
                    ObjectEdit.IdCarro = a.IdCarro;
                    ObjectEdit.IdCliente = a.IdCliente;
                    ObjectEdit.IdConcepto = a.IdConcepto;
                    ObjectEdit.IdEstado = a.IdEstado;
                    ObjectEdit.IdProveedor = a.IdProveedor;
                    ObjectEdit.Importe = a.Importe;
                    context.CuentasPendientesCP.Update(a);
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
