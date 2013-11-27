using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropzoneDemo.Models
{
    public class Cuenta
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public string UploadedFiles { get; set; }
    }
}