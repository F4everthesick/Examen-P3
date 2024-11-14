using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Examen_P3.Controller
{
    public class Usuarios
    {
        public Usuarios(string nombreUsu, string contrasena)
        {
            NombreUsu = nombreUsu;
            this.contrasena = contrasena;
        }

        public Usuarios() { }

        public string NombreUsu { get; set; }
        public string contrasena { get; set; }
    }
}