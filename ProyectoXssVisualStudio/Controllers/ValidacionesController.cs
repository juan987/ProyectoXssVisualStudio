using ProyectoXssVisualStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoXssVisualStudio.Controllers
{
    public class ValidacionesController : Controller
    {
        // GET: Validaciones
        public ActionResult Index()
        {
            Empleado emp = new Empleado();
            return View(emp);
        }

        [HttpPost]
        public ActionResult Index(Empleado emp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Correcto");
            }
            return View(emp);
        }

        public ActionResult Correcto()
        {
            return View();
        }
    }
}