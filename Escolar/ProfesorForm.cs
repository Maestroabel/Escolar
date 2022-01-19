using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escolar {
    public partial class ProfesorForm : Form {

        public string ID { get; set; }
        public ProfesorForm() {
            InitializeComponent();
        }

        private void ProfesorForm_Load(object sender, EventArgs e) {
            lblBienvenido.Text += ID;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            ID = "";
            MainForm login = new MainForm();
            login.Show();
            Close();
        }

        private void btnVerEst_Click(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            DataTable record = new DataTable();
            ControlDB.VerEstudiantesAsigProf(ID).Fill(record);
            dataGridView1.DataSource = record;
        }

        private void btnVerAsig_Click(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            DataTable record = new DataTable();
            ControlDB.VerAsignaturasProfesor(ID).Fill(record);
            dataGridView1.DataSource = record;
        }

        private void btnImpartirAsig_Click(object sender, EventArgs e) {
            ImparticionAsigForm form = new ImparticionAsigForm();
            form.ID = ID;
            form.Show();
        }

        private void btnBorrarProf_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere eliminar su cuenta?", "Confirmación", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes) {
                ControlDB con = new ControlDB();
                if(ControlDB.BorrarProfesor(ID)) {
                    MessageBox.Show("Se eliminó la cuenta satisfactoriamente.", "Éxito");
                    btnCerrarSesion.PerformClick();
                }
                else {
                    MessageBox.Show("No se pudo eliminar la cuenta.", "Fracaso");
                }
            }

        }

        private void btnModificarProf_Click(object sender, EventArgs e) {
            ModProfesorForm form = new ModProfesorForm();
            form.ID = ID;
            form.Show();
            Close();
        }

        private void btnAsignarCal_Click(object sender, EventArgs e) {
            AsignarCaliForm form = new AsignarCaliForm();
            form.ID = ID;
            form.Show();
        }

        private void btnModificarCal_Click(object sender, EventArgs e) {
            ModCalificacionForm form = new ModCalificacionForm();
            form.ID = ID;
            form.Show();
        }

        private void btnVerCal_Click(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            DataTable record = new DataTable();
            ControlDB.VerCalificacionesProfesor(ID).Fill(record);
            dataGridView1.DataSource = record;
        }
    }
}
