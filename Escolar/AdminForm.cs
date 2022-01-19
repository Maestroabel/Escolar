using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escolar
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            MainForm login = new MainForm();
            login.Show();
            Close();
        }

        private void btnCrearAsig_Click(object sender, EventArgs e) {
            AgregarAsignaturaForm form = new AgregarAsignaturaForm();
            form.Show();
        }

        private void btnVerEst_Click(object sender, EventArgs e) {
            
            DataTable record = new DataTable();
            ControlDB.VerEstudiantes().Fill(record);
            dataGridView1.DataSource = record;
        }

        private void btnVerProf_Click(object sender, EventArgs e) {
            DataTable record = new DataTable();
            ControlDB.VerProfesores().Fill(record);
            dataGridView1.DataSource = record;
        }

        private void btnVerAsig_Click(object sender, EventArgs e) {
            DataTable record = new DataTable();
            ControlDB.VerAsignaturas().Fill(record);
            dataGridView1.DataSource = record;
        }

        private void btnModAsig_Click(object sender, EventArgs e) {
            ModAsignaturaForm form = new ModAsignaturaForm();
            form.Show();
        }
    }
}
