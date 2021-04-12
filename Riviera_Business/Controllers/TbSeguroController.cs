using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;


namespace Riviera_Business.Controllers
{
    public class TbSeguroController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbSeguro.ToList();
            foreach (TbSeguro ti in list) {
                ti.IdAutoPerteneceNavigation = context.CVersionCarro.Where(ver => ver.IdVersionCarro == ti.IdAutoPertenece).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Version = context.CVersionCarro.Select(cont => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = cont.VersionCarro, Value = cont.IdVersionCarro.ToString() });
            if (context.TbSeguro.Where(seg => seg.IdSeguro == id).First() is TbSeguro e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Version = context.CVersionCarro.Select(cont => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = cont.VersionCarro, Value = cont.IdVersionCarro.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbSeguro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbSeguro.Add(a);
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
            ViewBag.Version = context.CVersionCarro.Select(cont => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = cont.VersionCarro, Value = cont.IdVersionCarro.ToString() });
            if (context.TbSeguro.Where(seg=>seg.IdSeguro == id ).First() is TbSeguro e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbSeguro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbSeguro.FirstOrDefault(seg => seg.IdSeguro == a.IdSeguro);
                if (objectEdit != null)
                {
                    objectEdit.IdAutoPertenece = a.IdAutoPertenece;     
                    objectEdit.Aseguradora = a.Aseguradora;
                    objectEdit.Correo = a.Correo;
                    objectEdit.NombreCliente = a.NombreCliente;
                    objectEdit.NumPoliza = a.NumPoliza;
                    objectEdit.Telefono = a.Telefono;
                    objectEdit.TipoPoliza = a.TipoPoliza;
                    objectEdit.Version = a.Version;
                    context.TbSeguro.Update(objectEdit);
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
