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
    public partial class FormBiblioteca : Form
    {
        public FormBiblioteca()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textNombre.Text.Trim() == "" || textAutor.Text.Trim() == "" || textAnio.Text.Trim() == "")
            {
                MessageBox.Show("Nombre, autor y año son obligatorios");
                return;
            }

            foreach (char c in textAutor.Text)
            {
                if (!(char.IsLetter(c) || c == ' '))
                {
                    MessageBox.Show("El autor solo puede tener letras y espacios");
                    return;
                }
            }

            if (!int.TryParse(textAnio.Text, out int anio) || anio < 1450 || anio > DateTime.Now.Year)
            {
                MessageBox.Show("El año debe ser un número entre 1450 y " + DateTime.Now.Year);
                return;
            }

            foreach (Libro l in Datos.Libros)
            {
                if (l.Nombre.ToLower() == textNombre.Text.Trim().ToLower())
                {
                    MessageBox.Show("Ese libro ya está registrado");
                    return;
                }
            }

            Datos.Libros.Add(new Libro { Nombre = textNombre.Text.Trim(), Autor = textAutor.Text.Trim(), Anio = anio });
            textNombre.Clear();
            textAutor.Clear();
            textAnio.Clear();
            MessageBox.Show("Libro guardado. Total: " + Datos.Libros.Count);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsgte_Click(object sender, EventArgs e)
        {
            if (Datos.Libros.Count == 0)
            {
                MessageBox.Show("Registra al menos un libro antes de continuar");
                return;
            }
            new FormLista().Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
