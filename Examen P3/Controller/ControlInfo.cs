using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Examen_P3.Models.ExamenTATableAdapters;

namespace Examen_P3.Controller
{
    public class ControlInfo
    {
        public bool AgregarVideoJuego(string nombre, int cantidad, double precio, string imagerurl) 
        {
            try
            {
                using(videojuegosTableAdapter videojuegos = new videojuegosTableAdapter()) 
                {
                    videojuegos.Insert(nombre, cantidad, Convert.ToDecimal(precio), imagerurl);
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<VideoJuegos> ObtenerJuegos() 
        {
            try
            {
                using(videojuegosTableAdapter videojuegos = new videojuegosTableAdapter()) 
                {
                    var datatable = videojuegos.GetData();
                    if (datatable.Rows.Count>0)
                    {
                        List<VideoJuegos> lista = new List<VideoJuegos>();
                        foreach (DataRow row in datatable.Rows)
                        {
                            VideoJuegos video = new VideoJuegos
                            {
                                ID = Convert.ToInt32(row["ID"]),
                                Nombre = row["Nombre"].ToString(),
                                Cantidad = Convert.ToInt32(row["Cantidad"]),
                                Precio = Convert.ToDecimal(row["Precio"]),
                                ImagenURL = row["Imagen"].ToString()
                            };
                            lista.Add(video);
                        }
                        return lista;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}