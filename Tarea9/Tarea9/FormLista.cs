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
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormReportes().Show();
            this.Hide();
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLista_Load(object sender, EventArgs e)
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = Datos.Libros;
        }
    }
}
