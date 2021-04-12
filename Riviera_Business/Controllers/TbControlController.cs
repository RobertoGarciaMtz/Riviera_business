using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
/// <summary>
/// //////////////////////////////////////////////PENDIENTE///////////////////////////////////////
/// </summary>
namespace Riviera_Business.Controllers
{
    public class TbControlController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbControl.Where(lis=>lis.CompraVenta==2).ToList();
            foreach (TbControl ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(ce=> ce.IdEstados ==ti.IdEstado).FirstOrDefault();
                ti.IdMetodoPagoNavigation = context.CMetodoPago.Where(fp => fp.IdMetodoPago == ti.IdMetodoPago).FirstOrDefault();
                ti.IdBancoNavigation = context.CBanco.Where(bc => bc.IdBanco == bc.IdBanco).FirstOrDefault();
                ViewBag.Persona = context.TbDatosPersona.ToList();
                ViewBag.Personamoral = context.TbDatosPersonaMoral.ToList();
                ViewBag.Autos = context.TbCarros.ToList();
                ViewBag.Exportacion = context.TbExportacion.ToList();
            }
            return View(list);
        }

        public ActionResult IndexdeCompras()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbControl.Where(li=>li.CompraVenta==1).ToList();
            foreach (TbControl ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(ce => ce.IdEstados == ti.IdEstado).FirstOrDefault();
                ti.IdMetodoPagoNavigation = context.CMetodoPago.Where(fp => fp.IdMetodoPago == ti.IdMetodoPago).FirstOrDefault();
                ti.IdBancoNavigation = context.CBanco.Where(bc => bc.IdBanco == bc.IdBanco).FirstOrDefault();
                ViewBag.Persona = context.TbDatosPersona.ToList();
                ViewBag.Personamoral = context.TbDatosPersonaMoral.ToList();
                ViewBag.Autos = context.TbCarros.ToList();
                 ViewBag.Estados = context.CEstados.Select(es=> new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {Text=es.Descripcion,Value=es.IdEstados.ToString() });
                ViewBag.Metodopago = context.CMetodoPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdMetodoPago.ToString() });
                ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
                ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
                ViewBag.Auto = context.TbCarros.Select(au => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = au.NoSerie, Value = au.IdCarros.ToString() });

            }

            foreach (var item in list) 
            {
                Console.WriteLine(item.TipoVenta);
            }

            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Metodopago = context.CMetodoPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdMetodoPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            if (context.TbControl.Where(tc => tc.IdMovimiento == id).First() is TbControl e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult CompraAut()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es=> new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {Text=es.Descripcion,Value=es.IdEstados.ToString() });
            ViewBag.Metodopago = context.CMetodoPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdMetodoPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
            ViewBag.Auto = context.TbCarros.Where(est=>est.IdEstado==14 || est.IdEstado==15).Select(au => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = au.NoSerie, Value = au.IdCarros.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompraAut(TbControl a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbControl.Add(a);
                context.SaveChanges();

                TbLineaTiempo linea = new TbLineaTiempo();
                linea.IdCarro = a.IdCarros;
                linea.Fecha = DateTime.Today;
                linea.IdEstado = 19;
                context.TbLineaTiempo.Add(linea);
                context.SaveChanges();

                var carro = context.TbCarros.Where(tc => tc.IdCarros == a.IdCarros).FirstOrDefault();
                carro.IdEstado = 19;

                context.TbCarros.Update(carro);
                context.SaveChanges();

                return RedirectToAction(nameof(IndexdeCompras));
            }
            catch
            {
                return View();
            }
        }
        /// <summary>
        /// ///////////////////////////////////////////////////// fase beta
        public ActionResult VentaRetail()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Metodopago = context.CMetodoPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdMetodoPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VentaRetail(TbControl a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbControl.Add(a);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// </summary>
        /// <returns></returns>


        public ActionResult VentaAut()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Metodopago = context.CMetodoPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdMetodoPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
            ViewBag.Auto = context.TbCarros.Where(con=>con.IdEstado>=19&&con.IdEstado<=22).Select(au => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = au.NoSerie, Value = au.IdCarros.ToString() });
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VentaAut(TbControl a)  {
            try {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbControl.Add(a);
                context.SaveChanges();

                TbLineaTiempo linea = new TbLineaTiempo();
                linea.IdCarro = a.IdCarros;
                linea.Fecha = DateTime.Today;
                linea.IdEstado = 23;

                context.TbLineaTiempo.Add(linea);
                context.SaveChanges();

                var carro = context.TbCarros.Where(tc => tc.IdCarros == a.IdCarros).FirstOrDefault();
                carro.IdEstado = 23;
                context.TbCarros.Update(carro);

                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public List<ModeloApoyo> getProveedores(int tipo)
        {
            List<ModeloApoyo> list = new List<ModeloApoyo>();
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (tipo == 1)
            {
                var lista = context.TbDatosPersonaMoral.ToList();
                foreach (TbDatosPersonaMoral campo in lista)
                {
                    var apoyo = new ModeloApoyo();
                    apoyo.tipo = campo.IdDatosPm;
                    apoyo.valor = campo.DenominacionRazonSocial;
                    list.Add(apoyo);
                }
            }
            if(tipo == 2){
                var lista = context.TbDatosPersona.ToList();
                foreach (TbDatosPersona campo in lista)
                {
                    if( campo.Rfc != null)
                    {
                        var apoyo = new ModeloApoyo();
                        apoyo.tipo = campo.IdDatosPersona;
                        apoyo.valor = campo.Rfc;
                        list.Add(apoyo);
                    }
                    
                }
            }
            if(tipo == 3)  {
                var lista = context.TbExportacion.Join(
                        context.TbDatosPersona,
                        exporta => exporta.IdPersona,
                        persona => persona.IdDatosPersona,
                        (exporta, persona) => new { persona.IdDatosPersona, persona.Nombre, persona.Rfc }
                    ).ToList();
                foreach (var campo in lista)
                {
                    var apoyo = new ModeloApoyo();
                    apoyo.tipo = campo.IdDatosPersona;
                    apoyo.valor = campo.Nombre.ToString();
                    list.Add(apoyo);
                }
            }

            return list;
        }

        /*------------_______________________----------------------____________________________-----------------------*/
        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Metodopago = context.CMetodoPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdMetodoPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
            ViewBag.Auto = context.TbCarros.Select(au => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = au.NoSerie, Value = au.IdCarros.ToString() });
            if (context.TbControl.Where(tc =>tc.IdMovimiento ==id).First() is TbControl e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbControl a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbControl.FirstOrDefault(tc => tc.IdMovimiento == a.IdMovimiento);
                if (objectEdit!=null)
                {
                    objectEdit.BajaCambProp = a.BajaCambProp;
                    objectEdit.CantidadDebida = a.CantidadDebida;
                    objectEdit.ClienteVenta = a.ClienteVenta;
                    objectEdit.CompraVenta = a.CompraVenta;
                    objectEdit.ComprobantesPago = a.ComprobantesPago;
                    objectEdit.ComprobarId = a.ComprobarId;
                    objectEdit.ConstanciaFiscal = a.ConstanciaFiscal;
                    objectEdit.Contrato = a.Contrato;
                    objectEdit.CurpPf = a.CurpPf;
                    objectEdit.Debiendo = a.Debiendo;
                    objectEdit.FechaES = a.FechaES;
                    objectEdit.FechaFactura = a.FechaFactura;
                    objectEdit.FechaFacturaToma = a.FechaFacturaToma;
                    objectEdit.FolioFiscal = a.FolioFiscal;
                    objectEdit.IdBanco = a.IdBanco;
                    objectEdit.IdCarros = a.IdCarros;
                    objectEdit.IdCliente = a.IdCliente;
                    objectEdit.IdMetodoPago = a.IdMetodoPago;
                    objectEdit.Iva = a.Iva;
                    objectEdit.LeyAntilavado = a.LeyAntilavado;
                    objectEdit.FormaPago = a.FormaPago;
                    objectEdit.NoFacturaArv = a.NoFacturaArv;
                    objectEdit.PagadaCobrada = a.PagadaCobrada;
                    objectEdit.PrecioPactado = a.PrecioPactado;
                    objectEdit.SubTotal = a.SubTotal;
                    objectEdit.TipoVenta = a.TipoVenta;
                    objectEdit.Total = a.Total;
                    objectEdit.VoBoFacturarSat = a.VoBoFacturarSat;
                    objectEdit.VoBoLeyAntiLavado = a.VoBoLeyAntiLavado;

                    TbLineaTiempo linea = new TbLineaTiempo();
                    linea.IdCarro = a.IdCarros;
                    linea.Fecha = DateTime.Today;
                    linea.IdEstado = a.IdEstado;

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

         public ActionResult LlenadoExtra()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Metodopago = context.CMetodoPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdMetodoPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            return View();
        }



        [HttpPost]
        public ActionResult LlenadoExtra(TbControl a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                TbControl copia = new TbControl();
                copia.Anticipo = a.Anticipo;
                copia.AnticipoSN = a.AnticipoSN;
                copia.BajaCambProp = a.BajaCambProp;
                copia.CantidadDebida = a.CantidadDebida;
                copia.ClienteVenta = a.ClienteVenta;
                copia.CompraVenta = a.CompraVenta;
                copia.ComprobantesPago = a.ComprobantesPago;
                copia.ComprobarId = a.ComprobarId;
                copia.ConstanciaFiscal = a.ConstanciaFiscal;
                copia.Contrato = a.Contrato;
                copia.CurpPf = a.CurpPf;
                copia.Debiendo = a.Debiendo;
                copia.FechaES = a.FechaES;
                copia.FechaFactura = a.FechaFactura;
                copia.FechaFacturaToma = a.FechaFacturaToma;
                copia.FolioFiscal = a.FolioFiscal;
                copia.IdAsesorVenta = a.IdAsesorVenta;
                copia.IdBanco = a.IdBanco;
                copia.IdCarros = a.IdCarros;
                copia.IdCliente = a.IdCliente;
                copia.IdCliente = a.IdCliente;
                copia.IdEstado = a.IdEstado;
                copia.FormaPago = a.FormaPago;
                copia.Iva = a.Iva;
                copia.LeyAntilavado = a.LeyAntilavado;
                copia.IdMetodoPago = a.IdMetodoPago;
                copia.NoFacturaArv = a.NoFacturaArv;
                copia.PagadaCobrada = a.PagadaCobrada;
                copia.PrecioPactado = a.PrecioPactado;
                copia.SubTotal = a.SubTotal;
                copia.TipoVenta = a.TipoVenta;
                copia.Total = a.Total;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                Console.WriteLine("Hubo un error");
                return View(a);
            }
        }
    }
}
