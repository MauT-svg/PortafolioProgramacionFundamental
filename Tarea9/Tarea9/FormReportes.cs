using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca1
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Datos.Libros.Count > 0)
            {
                string nombre = Datos.Libros[0].Nombre;
                Datos.Libros.RemoveAt(0);
                txtResultado.Text = "Se eliminó: " + nombre;
            }
            else
            {
                txtResultado.Text = "No hay libros para eliminar";
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Cantidad de libros: " + Datos.Libros.Count;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
