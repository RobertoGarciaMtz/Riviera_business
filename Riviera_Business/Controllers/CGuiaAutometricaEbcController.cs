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
    [Route("Guias")]
    public class CGuiaAutometricaEbcController : Controller
    {
        // GET: HomeController1
        [Route("Index")]
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CGuiaAutometricaEbc.ToList();
            foreach (CGuiaAutometricaEbc ti in list)
            {
                ti.IdVersionNavigation = context.CVersionCarro.Where(te => te.IdVersionCarro == ti.IdVersion).FirstOrDefault();
                ti.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(te => te.IdModeloCarro == ti.IdVersionNavigation.IdModelo).FirstOrDefault();
                ti.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where(te => te.IdMarcaCarro == ti.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(te => te.IdEstados == ti.IdEstado).FirstOrDefault();

            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        [Route("Detalles")]
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            
            if (context.CGuiaAutometricaEbc.Where(s => s.IdGuiaAutometrica == id).First() is CGuiaAutometricaEbc e)
            {
                return View(id);
            }
            return NotFound();
            
        }

        // GET: HomeController1/Create
        [Route("Autometrica")]
        public ActionResult CreaAutometrica()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdEstados.ToString() });
            ViewBag.Marca = context.CMarcaCarro.Select(mar => new SelectListItem { Text = mar.NombreMarca, Value = mar.IdMarcaCarro.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ver => new SelectListItem { Text = ver.VersionCarro, Value = ver.IdVersionCarro.ToString() });
            return View();
        }
        [HttpPost]
        public List<CModeloCarro> recuperarmodelo(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            List<CModeloCarro> cModelos = new List<CModeloCarro>();
            var list = context.CModeloCarro.Where(ab => ab.IdMarca == id).ToList();
            foreach (CModeloCarro ti in list)
            {
                ti.IdMarcaNavigation = null;
                ti.CVersionCarro = null;
            }
            return list ;
        }

        [HttpPost]
        public List<CVersionCarro> recuperarversion(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            List<CVersionCarro> cVersion = new List<CVersionCarro>();
            var list = context.CVersionCarro.Where(ab => ab.IdVersionCarro== id).ToList();
            foreach (CVersionCarro ti in list)
            {
                ti.IdModeloNavigation = null;
                ti.TbCarros= null;
                ti.CGuiaAutometricaEbc = null;
                
            }
            return list;
        }

        [Route("EBC")]
        public ActionResult CreaEBC()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdEstados.ToString() });
            ViewBag.Marca = context.CMarcaCarro.Select(mar => new SelectListItem {Text=mar.NombreMarca,Value =mar.IdMarcaCarro.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ver => new SelectListItem { Text = ver.VersionCarro, Value = ver.IdVersionCarro.ToString() });
            return View();
        }
        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreaEBC(CGuiaAutometricaEbc a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CGuiaAutometricaEbc.Add(a);
                Console.WriteLine("PAra comrpbar si se pudo agregar o no");
                Console.WriteLine("valor de version que trae " + a.IdVersion);
                Console.WriteLine("valor de la media" + a.Media);
                Console.WriteLine("Valor de id de guia " + a.IdGuiaAutometrica);
                Console.WriteLine("Valor de a" + a.Fecha);
                Console.WriteLine("Valor de a" + a.GuiaAutometricaEbc);
                Console.WriteLine("Valor de a" + a.IdVersionNavigation);
                context.SaveChanges();
                Console.WriteLine("Entramos pero no procedemos");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [Route("Autometrica")]
        [ValidateAntiForgeryToken]
        public ActionResult CreaAutometrica(CGuiaAutometricaEbc a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CGuiaAutometricaEbc.Add(a);
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
            ViewBag.Version = context.CVersionCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.VersionCarro, Value = s.IdVersionCarro.ToString() });
            if (context.CGuiaAutometricaEbc.Where(s => s.IdGuiaAutometrica == id).First() is CGuiaAutometricaEbc e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [Route("Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,CGuiaAutometricaEbc a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CGuiaAutometricaEbc.FirstOrDefault(ce => ce.IdGuiaAutometrica == a.IdGuiaAutometrica);
                if(objectEdit != null)
                {
                    objectEdit.Toma = a.Toma;
                    objectEdit.Venta = a.Venta;
                    objectEdit.Media = a.Media;
                    objectEdit.IdVersion = a.IdVersion;
                    context.CGuiaAutometricaEbc.Update(objectEdit);
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
