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

    public class TbCarrosController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbCarros.ToList();
            foreach (TbCarros ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(tc => tc.IdEstados == ti.IdEstado).FirstOrDefault();
                ti.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdVersion).FirstOrDefault();
                ti.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdVersionNavigation.IdModelo).FirstOrDefault();
                ti.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                    (mar => mar.IdMarcaCarro == ti.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();

                ViewBag.Persona = context.TbDatosPersona.ToList();
                ViewBag.Personamoral = context.TbDatosPersonaMoral.ToList();

            }
            return View(list);

        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var nombre = "";
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.VersionCarro, Value = ma.IdVersionCarro.ToString() });
            if (context.TbCarros.Where(tc => tc.IdCarros == id).First() is TbCarros e)
            {
                if (e.TipoCompraCanal == 1)
                {
                    nombre = context.TbDatosPersonaMoral.Where(dpm => dpm.IdDatosPm == e.IdProveedor).First().DenominacionRazonSocial;
                }
                else {
                    nombre = context.TbDatosPersona.Where(dp => dp.IdDatosPersona == e.IdProveedor).First().Nombre;
                }
                ViewBag.Nombre = nombre;
                return View(e);
            }
            return NotFound();
        }
        /*----------------------------------------_________________________________________---------------
          Seccion requerida para recuperar los datos de los proveedores*/
        [HttpGet]
        public ActionResult Extras()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.VersionCarro, Value = ma.IdVersionCarro.ToString() });
            ViewBag.Modelo = context.CModeloCarro.Select(mo => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mo.ModeloCarro, Value = mo.IdModeloCarro.ToString() });
            ViewBag.Marca = context.CMarcaCarro.Select(mo => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mo.NombreMarca, Value = mo.IdMarcaCarro.ToString() });
            
            return View();
        }

        [HttpPost]
        public List<ModeloApoyo> getProveedores(int tipo) {
            List<ModeloApoyo> list = new List<ModeloApoyo>();
            
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if( tipo == 1)
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
            if( tipo == 2)
            {
                var lista = context.TbDatosPersona.ToList();
                foreach (TbDatosPersona campo in lista)
                {
                    if (campo.Rfc != null)
                    {
                        var apoyo = new ModeloApoyo();
                        apoyo.tipo = campo.IdDatosPersona;
                        apoyo.valor = campo.Rfc;
                        list.Add(apoyo);
                    }
                }
            }
            if( tipo == 3)
            {
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

        [HttpPost]
        public ActionResult Extras(ZMMVCarro copia)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                
                TbCarros objectEdit= new TbCarros();
                    objectEdit.Modelo = copia.Modelo;
                    objectEdit.Antiguedad = copia.Antiguedad;
                    objectEdit.TipoCompraCanal = copia.TipoCompraCanal;
                    objectEdit.ClaveVehicular = copia.ClaveVehicular;
                    objectEdit.IdVersion = copia.IdVersion;
                    objectEdit.ColorExt = copia.ColorExt;
                    objectEdit.ColorInt = copia.ColorInt;
                    objectEdit.DuenoAnterior = copia.DuenoAnterior;
                    objectEdit.FechaFactToma = copia.FechaFactToma;
                    objectEdit.FolioFiscal = copia.FolioFiscal;
                    objectEdit.IdEstado = copia.IdEstado;
                    objectEdit.Kms = copia.Kms;
                    objectEdit.MvaOpc = copia.MvaOpc;
                    objectEdit.NoMotor = copia.NoMotor;
                    objectEdit.NoSerie = copia.NoSerie;
                    objectEdit.NumEconomicoOpc = copia.NumEconomicoOpc;
                    objectEdit.Origen = copia.Origen;
                    objectEdit.PropuestaCliente = copia.PropuestaCliente;
                    objectEdit.Transmision = copia.Transmicion;
                    objectEdit.IdProveedor = copia.IdProveedor;
                    objectEdit.Ubicacion = copia.Ubicacion;
                    objectEdit.FechaOferta = copia.FechaOferta;
                    /*------------------------------------------------------------*/
                    context.TbCarros.Add(objectEdit);
                    context.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return View(copia);
            }
        }
        /*
         --------------------------__________________________________________-----------------------*/
        // GET: HomeController1/Create
        public ActionResult Create()
        {

            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            //ViewBag.Version = context.CVersionCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.VersionCarro, Value = ma.IdVersionCarro.ToString() });
            ViewBag.Version = context.CVersionCarro.ToList();
            //ViewBag.Modelo = context.CModeloCarro.Select(mo => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mo.ModeloCarro, Value = mo.IdModeloCarro.ToString() });
            ViewBag.Modelo = context.CModeloCarro.ToList();
            //ViewBag.Marca = context.CMarcaCarro.Select(mo => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mo.NombreMarca, Value = mo.IdMarcaCarro.ToString() });
            ViewBag.Marca = context.CMarcaCarro.ToList();
            return View();
        }

     
        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbCarros a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;

                a.IdEstado = 14;

                context.TbCarros.Add(a);

                /*
                T

                //Order by
                context.TbControl.OrderBy( x => x.IdCarros).Take(1);
                //Order by Descending
                context.TbControl.OrderByDescending(x => x.IdCarros).Take(10);*/

                Console.WriteLine("Valor del id" + a.IdVersion);
                Console.WriteLine("Aqui si entramos");
                Console.WriteLine("Aqui si entramos"+a);
                
                
                context.SaveChanges();


                TbLineaTiempo linea = new TbLineaTiempo();
                linea.IdCarro = a.IdCarros;
                linea.Fecha = DateTime.Today;
                linea.IdEstado = 14;

                Console.WriteLine(linea);

                context.TbLineaTiempo.Add(linea);
                context.SaveChanges();
                Console.WriteLine("Aqui no entramos ");
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                Console.WriteLine("Aqui si entramos" + e);
                return View(a);
            }
        }



        // POST: HomeController1/Create
        [HttpPost]
        public List<CModeloCarro> RecuperarModelo1(int id) {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;            
            List<CModeloCarro> listaCorrecta = new List<CModeloCarro>();
            var lista = context.CModeloCarro.ToList();
            /*foreach(CModeloCarro a in lista){
                if(a.IdMarca == id)
                {
                    listaCorrecta.Add(a);
                }
            }
            Console.WriteLine("Imprimir lista correcta");
            Console.WriteLine(listaCorrecta);
            return listaCorrecta;*/
            var list = context.CModeloCarro.Where(x => x.IdMarca == id).ToList();
            Console.WriteLine(list);
            foreach (CModeloCarro v in list){
                v.IdMarcaNavigation = null;
                v.CVersionCarro = null;
            }
            return list;
        }

        [HttpPost]
        public List<CVersionCarro> RecuperarVersion1(int id) {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            List<CVersionCarro> cVersion = new List<CVersionCarro>();
            var lista = context.CVersionCarro.ToList();
            /*
              foreach(CVersionCarro a in lista){
                  if(a.IdModelo== id)
                  {
                      cVersion.Add(a);
                  }
              }
            return cVersion;
        */
            var list = context.CVersionCarro.Where(y => y.IdModelo == id).ToList();
             foreach (CVersionCarro v in list){
                 v.IdModeloNavigation = null;
                v.CGuiaAutometricaEbc = null;                
             }
            Console.WriteLine(cVersion);
            return list;
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.VersionCarro, Value = ma.IdVersionCarro.ToString() });
            if (context.TbCarros.Where(tc => tc.IdCarros == id).First() is TbCarros e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbCarros a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbCarros.FirstOrDefault(tc => tc.IdCarros == a.IdCarros);
                if (objectEdit != null)
                {
                    objectEdit.Modelo = a.Modelo;
                    objectEdit.Antiguedad = a.Antiguedad;
                    objectEdit.TipoCompraCanal = a.TipoCompraCanal;
                    objectEdit.ClaveVehicular = a.ClaveVehicular;
                    objectEdit.IdVersion = a.IdVersion;
                    objectEdit.ColorExt = a.ColorExt;
                    objectEdit.ColorInt = a.ColorInt;
                    objectEdit.DuenoAnterior = a.DuenoAnterior;
                    objectEdit.FechaFactToma = a.FechaFactToma;
                    objectEdit.FolioFiscal = a.FolioFiscal;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.Kms = a.Kms;
                    objectEdit.MvaOpc = a.MvaOpc;
                    objectEdit.NoMotor = a.NoMotor;
                    objectEdit.NoSerie = a.NoSerie;
                    objectEdit.NumEconomicoOpc = a.NumEconomicoOpc;
                    objectEdit.Origen = a.Origen;
                    objectEdit.PropuestaCliente = a.PropuestaCliente;
                    objectEdit.Transmision = a.Transmision;
                    objectEdit.IdProveedor = a.IdProveedor;
                    objectEdit.Ubicacion = a.Ubicacion;
                    objectEdit.FechaOferta = a.FechaOferta;
                    context.TbCarros.Update(objectEdit);
                    context.SaveChanges();

                    TbLineaTiempo linea = new TbLineaTiempo();
                    linea.IdCarro = a.IdCarros;
                    linea.Fecha = DateTime.Today;
                    linea.IdEstado = 15;

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

        public ActionResult Delete(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.TbCarros.Where(tc => tc.IdCarros == id).First() is TbCarros e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TbCarros a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                TbCarros objectdel = a;

                context.TbCarros.Remove(objectdel);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
