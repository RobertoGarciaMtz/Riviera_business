using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Riviera_Business.Models;
using Microsoft.AspNetCore.Authorization;

namespace Riviera_Business.Controllers
{
    [Route("Bancos")]
    public class CBancosController : Controller
    {
        // GET: HomeController1
        [Route("Index")]
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CBanco;
            return View(list);
        }

        // GET: HomeController1/Details/5
        [Route("Detalles")]
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.CBanco.Where(s => s.IdBanco == id).First() is CBanco e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        [Route("Agregar")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [Route("Agregar")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CBanco a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CBanco.Add(a);
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
            if (context.CBanco.Where(s => s.IdBanco == id).First() is CBanco e){
                return View(e);
            }
        return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [Route("Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,CBanco a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CBanco.FirstOrDefault(ce => ce.IdBanco == a.IdBanco);
                if(objectEdit != null)
                {
                    objectEdit.Nombre = a.Nombre;
                    context.CBanco.Update(objectEdit);
                    context.SaveChanges() ;
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
