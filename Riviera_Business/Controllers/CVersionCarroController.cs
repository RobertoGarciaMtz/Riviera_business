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
    [Route("Version")]
    public class CVersionCarroController : Controller
    {
        // GET: HomeController1
        [Route("Index")]
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CVersionCarro.ToList();
            foreach (CVersionCarro ti in list)
            {
                ti.IdModeloNavigation = context.CModeloCarro.Where(te => te.IdModeloCarro == ti.IdModelo).FirstOrDefault();
                ti.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where(mar => mar.IdMarcaCarro == ti.IdModeloNavigation.IdMarca).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        [Route("Detalles")]
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;

            if (context.CVersionCarro.Where(s => s.IdVersionCarro == id).First() is CVersionCarro e)
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
            ViewBag.Marcas = context.CMarcaCarro.Select(mar => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mar.NombreMarca, Value = mar.IdMarcaCarro.ToString() });
            var lista = context.CModeloCarro.Where(x => x.IdModeloCarro >= 0)
                           .Select(x => new { noserie = x.IdModeloCarro.ToString(), desc = x.IdModeloCarro.ToString() + "-Modelo:" + x.ModeloCarro + "-Marca:" + x.IdMarcaNavigation.NombreMarca });
            ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
            ViewBag.Modelo = context.CModeloCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.ModeloCarro, Value = s.IdModeloCarro.ToString() });
            return View();
        }

        [HttpPost]
        public List<CModeloCarro> recuperarmodelo(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            List<CModeloCarro> cModelos = new List<CModeloCarro>();
            var list = context.CModeloCarro.Where(x => x.IdMarca == id).ToList();
            Console.WriteLine(list);
            foreach (CModeloCarro v in list)
            {
                v.IdMarcaNavigation = null;
                v.CVersionCarro = null;
            }
            return list;

        }

        // POST: HomeController1/Create
        [HttpPost]
        [Route("Agregar")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CVersionCarro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                a.IdModeloNavigation = context.CModeloCarro.Where(mc => mc.IdModeloCarro == a.IdModelo).FirstOrDefault();
                a.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where(mc => mc.IdMarcaCarro == a.IdModeloNavigation.IdMarca).FirstOrDefault();
                context.CVersionCarro.Add(a);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        [Route("Editar")]
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Modelo = context.CModeloCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.ModeloCarro, Value = s.IdModeloCarro.ToString() });
            if(context.CVersionCarro.Where(s=>s.IdVersionCarro == id).First() is CVersionCarro e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [Route("Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CVersionCarro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CVersionCarro.FirstOrDefault(cv => cv.IdVersionCarro == a.IdVersionCarro);
                if (objectEdit != null)
                {
                    objectEdit.VersionCarro = a.VersionCarro;
                    objectEdit.IdModelo = a.IdModelo;
                    context.CVersionCarro.Update(objectEdit);
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
