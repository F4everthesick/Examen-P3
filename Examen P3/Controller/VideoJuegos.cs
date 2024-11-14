using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_P3.Controller
{
    public class VideoJuegos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string ImagenURL { get; set; }
    }
}