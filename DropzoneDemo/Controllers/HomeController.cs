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

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                var filePath = Server.MapPath("~/Uploads/" + file.FileName);
                file.SaveAs(filePath);
                return Json(new { uploadPath = filePath });
            }
            catch (Exception exception)
            {
                Response.StatusCode = 501;
                return Json(new {Success = false});
            }
        }

        public ActionResult CreateAccount(Cuenta cuenta)
        {
            string nombresArchivo = cuenta.UploadedFiles;
            string Nombres = cuenta.Nombre;
            string Apellidos = cuenta.Apellidos;

            return View("CreateAccount", cuenta);
        }

    }
}
