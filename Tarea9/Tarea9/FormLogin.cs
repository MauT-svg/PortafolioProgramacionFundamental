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
    public partial class FormLogin : Form
    {
        int intentos = 0;
        public FormLogin()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Usuario y contraseña no pueden estar vacíos");
                return;
            }

            if (txtUsuario.Text == "Johana" && txtClave.Text == "1997")
            {
                new FormBiblioteca().Show();
                this.Hide();
            }
            else
            {
                intentos++;
                if (intentos >= 3)
                {
                    MessageBox.Show("Demasiados intentos");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentos + " de 3");
                }
            }
        }
    }
}
