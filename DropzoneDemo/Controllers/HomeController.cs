using DropzoneDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropzoneDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CargarArchivo(Cuenta cuenta, IEnumerable<HttpPostedFileBase> file)
        {
            string nombreArchivo = file.FirstOrDefault().FileName;
            string Nombres = cuenta.Nombre;
            string Apellidos = cuenta.Apellidos;

            return RedirectToAction("Index");
        }

    }
}
