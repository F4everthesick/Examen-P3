using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_P3.Models.ExamenTATableAdapters;
using Examen_P3.Controller;

namespace Examen_P3.Views
{
    public partial class Index : System.Web.UI.Page
    {
        videojuegosTableAdapter videojuegos = new videojuegosTableAdapter();
        ControlInfo controlInfo = new ControlInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["klopez"] != null)
            {
                Lbl2.Text = Session["klopez"].ToString();
            }
            else
            {
                Lbl2.Text = "Sesion no encontrada. ";
            }
        }

        protected void btnAgregarJuego_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            decimal costo = decimal.Parse(txtCosto.Text);
            string imagenUrl = null;
 
            if (fileimagen.HasFile)
            {
                string fileName = Path.GetFileName(fileimagen.PostedFile.FileName);
                string filePath = Server.MapPath("~/Imagenes/") + fileName;

                try
                {
                    // fileimagen.SaveAs(filePath);
                    fileimagen.SaveAs(filePath);
                    imagenUrl = "~/Imagenes/" + fileName; // Ruta para guardar en la base de datos
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error al subir la imagen: " + ex.Message + "');</script>");
                    return;
                }
            }

            try
            {
                bool result = controlInfo.AgregarVideoJuego(nombre, cantidad, (double)costo, imagenUrl);

                if (result)
                {
                    Response.Write("<script>alert('Producto agregado.');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Hubo un error al momento de agregar el producto.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
            CargarJuegos();  // Llama a CargarProductos solo cuando se hace clic en "Mostrar Productos"
        }


        private void CargarJuegos()
        {
            ControlInfo controlInfo = new ControlInfo();
            var juegos = controlInfo.ObtenerJuegos();
            GridDatos.DataSource = juegos;
            GridDatos.DataBind();  // Enlaza los datos al GridView
        }

    }
}